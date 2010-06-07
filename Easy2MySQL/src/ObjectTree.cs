
// ObjectTree.cs
//
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.AdvTree;

namespace Easy2
{
	/// <summary>
	/// 오브젝트 트리 뷰 클래스입니다.
	/// </summary>
	public class ObjectTree : AdvTree
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public ObjectTree()
		{
			this.SelectionChanged += new System.EventHandler(OnSelectionChanged);
		}

		/// <summary>
		/// 선택된 노드가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트 객체입니다.</param>
		private void OnSelectionChanged(object sender, EventArgs e)
		{
			Node header = this.SelectedNode;

			if(header == null)
				return;

			while(header.Parent != null)
				header = header.Parent;

			foreach(Node n in this.Nodes)
				n.Image = Properties.Resources.MySqlServerDeactivate;

			header.Image = Properties.Resources.MySqlServerActivate;
			Program.ActivateCommunicator = Program.CoummunicatorList[header.Index];
		}

		/// <summary>
		/// 노드를 추가합니다.
		/// </summary>
		/// <param name="node">추가할 노드입니다.</param>
		public void InsertObject(ObjectNode node)
		{
			if(node.Parent != null)
				node.ParentNode.Nodes.Add(node);
			else
				this.Nodes.Add(node);
		}

		/// <summary>
		/// 트리 데이터를 다시 읽어옵니다.
		/// </summary>
		public void UpdateTree()
		{
			this.Nodes.Clear();
			foreach(MySqlCommunicator communicator in Program.CoummunicatorList)
			{
				MySqlDataReader reader = null;
				List<string> databaseList = new List<string>();
				if(communicator.ConnectInfo.Database.Length == 0)
				{
					MySqlGenerator generator = new MySqlGenerator();
					reader = communicator.ExcuteReader(generator.ShowDatabases());
					while(reader.Read())
						databaseList.Add(reader.GetString(0));
					reader.Close();
				}
				else
					databaseList.Add(communicator.ConnectInfo.Database);

				ObjectNode serverNode = new ObjectNode(null, communicator.ConnectInfo.Username + "@" + communicator.ConnectInfo.Host, ObjectNodeType.MySqlServer);
				this.Nodes.Add(serverNode);
				foreach(string databaseName in databaseList)
				{
					ObjectNode databaseNode = new ObjectNode(serverNode, databaseName, ObjectNodeType.MySqlDatabase);
					serverNode.Nodes.Add(databaseNode);

					string[] folderList = { "테이블", "뷰", "저장 프로시저", "함수", "트리거", "이벤트" };

					foreach(string folder in folderList)
					{
						ObjectNode folderNode = new ObjectNode(databaseNode, folder, ObjectNodeType.Folder);
						databaseNode.Nodes.Add(folderNode);
						folderNode.Nodes.Add(new ObjectNode(folderNode, "null", ObjectNodeType.MySqlTable));
					}
				}
			}
		}
	}
}