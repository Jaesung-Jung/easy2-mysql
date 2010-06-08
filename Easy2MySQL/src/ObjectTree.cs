
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
			this.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
			this.BeforeExpand += new DevComponents.AdvTree.AdvTreeNodeCancelEventHandler(this.OnBeforeExpand);
		}

		/// <summary>
		/// 선택된 노드가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void OnSelectionChanged(object sender, EventArgs e)
		{
			MySqlGenerator generator = new MySqlGenerator();

			Node header = this.SelectedNode;
			if(header == null)
				return;

			while(header.Parent != null)
				header = header.Parent;

			foreach(Node n in this.Nodes)
				n.Image = Properties.Resources.MySqlServerDeactivate;

			header.Image = Properties.Resources.MySqlServerActivate;
			Program.ActivateCommunicator = Program.CoummunicatorList[header.Index];

			Node databaseNode = this.SelectedNode;
			if(databaseNode == null || databaseNode.Parent == null)
				return;

			while(databaseNode.Parent != header)
				databaseNode = databaseNode.Parent;

			try
			{
				if(Program.ActivateCommunicator.UseDatabaseName != databaseNode.Text)
				{
					Program.ActivateCommunicator.Execute(new MySqlGenerator().UseDatabase(databaseNode.Text));
					Program.ActivateCommunicator.UseDatabaseName = databaseNode.Text;
				}
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(Program.MainFormHandle, ex.Message, Properties.Resources.MySqlExecuteFail, ex.Number);
			}
		}

		/// <summary>
		/// 노드가 펼쳐질 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void OnBeforeExpand(object sender, AdvTreeNodeCancelEventArgs e)
		{
			this.SelectedNode = e.Node;
			MySqlDataReader reader = null;

			try
			{
				switch(((ObjectNode)e.Node).NodeType)
				{
					case ObjectNodeType.Folder:
						Node folderNode = e.Node;
						if(folderNode.Nodes.Count == 0)	// 노드가 없다면 테이블을 조회권한이 없다는 의미
							break;

						if(folderNode.Nodes[0].Text == "null")
						{
							folderNode.Nodes.Clear();
							if(folderNode.Text == "테이블")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowTables(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadTables(folderNode, reader);
							}
							else if(folderNode.Text == "뷰")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowViews(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "저장 프로시저")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowStoredProcs(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "함수")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowFunctions(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "트리거")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowTriggers(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "이벤트")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowEvents(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
						}
						break;

					case ObjectNodeType.MySqlTable:
						Node tableNode = e.Node;
						if(tableNode.Nodes[0].Nodes.Count == 0)
						{
							reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowColumns(tableNode.Text));
							this.ReadColumns(tableNode.Nodes[0], reader);
							reader.Close();
						}
						if(tableNode.Nodes[1].Nodes.Count == 0)
						{
							reader = Program.ActivateCommunicator.ExecuteReader(new MySqlGenerator().ShowIndexes(tableNode.Text));
							this.ReadIndexes(tableNode.Nodes[1], reader);
						}
						break;
				}
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(Program.MainFormHandle, ex.Message, Properties.Resources.MySqlExecuteFail, ex.Number);
			}

			if(reader != null)
				reader.Close();
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
					try
					{
						reader = communicator.ExecuteReader(generator.ShowDatabases());
					}
					catch(MySqlException ex)
					{
						EasyToMySqlError.Show(Program.MainFormHandle, ex.Message, Properties.Resources.MySqlExecuteFail, ex.Number);
					}
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

		/// <summary>
		/// 테이블데이터를 읽어 트리에 추가합니다.
		/// </summary>
		/// <param name="folderNode">테이블데이터 폴더의 노드입니다.</param>
		/// <param name="reader">테이블데이터를 가진 객체입니다.</param>
		private void ReadTables(Node folderNode, MySqlDataReader reader)
		{
			while(reader.Read())
			{
				ObjectNode tableNode = new ObjectNode((ObjectNode)folderNode, reader.GetString(0), ObjectNodeType.MySqlTable);
				tableNode.Nodes.Add(new ObjectNode(tableNode, "컬럼", ObjectNodeType.Folder));
				tableNode.Nodes.Add(new ObjectNode(tableNode, "인덱스", ObjectNodeType.Folder));
				folderNode.Nodes.Add(tableNode);
			}
		}

		/// <summary>
		/// 컬럼을 읽어 트리에 추가합니다.
		/// </summary>
		/// <param name="folderNode">컬럼데이터 폴더의 노드입니다.</param>
		/// <param name="reader">컬럼데이터를 가진 객체입니다.</param>
		private void ReadColumns(Node folderNode, MySqlDataReader reader)
		{
			while(reader.Read())
			{
				string[] columnData = { reader["field"].ToString(), reader["type"].ToString(), reader["null"].ToString(), reader["key"].ToString() };
				string columnText = new MySqlGenerator().MakeColumnInfo(columnData);
				if(reader["key"].ToString() == "PRI")
					folderNode.Nodes.Add(new ObjectNode((ObjectNode)folderNode, columnText, ObjectNodeType.MySqlPkColumn));
				else
					folderNode.Nodes.Add(new ObjectNode((ObjectNode)folderNode, columnText, ObjectNodeType.MySqlColumn));
			}
		}

		/// <summary>
		/// 인덱스를 읽어 트리에 추가합니다.
		/// </summary>
		/// <param name="folderNode">인덱스데이터 폴더의 노드입니다.</param>
		/// <param name="reader">인덱스데이터를 가진 객체입니다.</param>
		private void ReadIndexes(Node folderNode, MySqlDataReader reader)
		{
			while(reader.Read())
			{
				string indexText = new MySqlGenerator().MakeIndexInfo(reader["Key_name"].ToString(), reader["Column_name"].ToString());
				if(reader["Key_name"].ToString() == "PRIMARY")
					folderNode.Nodes.Add(new ObjectNode((ObjectNode)folderNode, indexText, ObjectNodeType.MySqlPkIndex));
				else
					folderNode.Nodes.Add(new ObjectNode((ObjectNode)folderNode, indexText, ObjectNodeType.MySqlIndex));
			}
		}

		/// <summary>
		/// 오브젝트를 읽어 트리에 추가합니다.
		/// </summary>
		/// <param name="folderNode">해당 오브젝트 폴더의 노드입니다.</param>
		/// <param name="reader">오브젝트데이터를 가진 객체입니다.</param>
		private void ReadObject(Node folderNode, MySqlDataReader reader)
		{
			while(reader.Read())
			{
				folderNode.Nodes.Add(new ObjectNode((ObjectNode)folderNode, reader.GetString(0), ObjectNodeType.MySqlView));
 			}
		}
	}
}