
// ObjectTree.cs
//
using Easy2.Forms;
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.AdvTree;

namespace Easy2.Components
{
	/// <summary>
	/// 오브젝트 트리클래스는 MySQL 객체를 트리형태 보여주며, 삽입/삭제가 등의 기능을 지원합니다.
	/// </summary>
	public class ObjectTree : AdvTree
	{
		/// <summary>
		/// ObjectTree 인스턴스를 초기화합니다.
		/// </summary>
		public ObjectTree()
		{
			this.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
			this.BeforeExpand += new DevComponents.AdvTree.AdvTreeNodeCancelEventHandler(this.OnBeforeExpand);
		}

		/// <summary>
		/// 선택된 노드가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnSelectionChanged(object sender, EventArgs e)
		{
			Node header = this.SelectedNode;
			if(header == null)
				return;

			while(header.Parent != null)
				header = header.Parent;

			foreach(Node n in this.Nodes)
				n.Image = Resources.TreeServerDeactivate;

			this.m_activateNode = (ObjectNode)header;
			header.Image = Resources.TreeServerActivate;
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
					Program.ActivateCommunicator.UseDatabase(databaseNode.Text);
					Program.ActivateCommunicator.UseDatabaseName = databaseNode.Text;
				}
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(Program.MainFormHandle, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
		}

		/// <summary>
		/// 노드가 펼쳐질 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
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
								reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowTables(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadTables(folderNode, reader);
							}
							else if(folderNode.Text == "뷰")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowViews(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "저장 프로시저")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowStoredProcs(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "함수")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowFunctions(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "트리거")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowTriggers(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
							else if(folderNode.Text == "이벤트")
							{
								reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowEvents(Program.ActivateCommunicator.UseDatabaseName));
								this.ReadObject(folderNode, reader);
							}
						}
						break;

					case ObjectNodeType.MySqlTable:
						Node tableNode = e.Node;
						if(tableNode.Nodes[0].Nodes.Count == 0)
						{
							reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowColumns(tableNode.Text));
							this.ReadColumns(tableNode.Nodes[0], reader);
							reader.Close();
						}
						if(tableNode.Nodes[1].Nodes.Count == 0)
						{
							reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowIndexes(tableNode.Text));
							this.ReadIndexes(tableNode.Nodes[1], reader);
						}
						break;
				}
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(Program.MainFormHandle, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
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
					try
					{
						reader = communicator.ExecuteReader(MySqlGenerator.ShowDatabases());
						while(reader.Read())
							databaseList.Add(reader.GetString(0));
					}
					catch(MySqlException ex)
					{
						EasyToMySqlError.Show(Program.MainFormHandle, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
					}
					finally
					{
						if(reader != null)
							reader.Close();
					}
				}
				else
					databaseList.Add(communicator.ConnectInfo.Database);

				ObjectNode serverNode = new ObjectNode(null, communicator.ConnectInfo.Username + "@" + communicator.ConnectInfo.Host, ObjectNodeType.MySqlServer);
				this.Nodes.Add(serverNode);

				string[] folderList = { "테이블", "뷰", "저장 프로시저", "함수", "트리거", "이벤트" };
				foreach(string databaseName in databaseList)
				{
					ObjectNode databaseNode = new ObjectNode(serverNode, databaseName, ObjectNodeType.MySqlDatabase);
					serverNode.Nodes.Add(databaseNode);

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
				string columnText = MySqlGenerator.MakeColumnInfo(columnData);
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
				string indexText = MySqlGenerator.MakeIndexInfo(reader["Key_name"].ToString(), reader["Column_name"].ToString());
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

		/// <summary>
		/// 데이터베이스 노드를 추가합니다.
		/// </summary>
		/// <param name="dbname">추가될 데이터베이스 노드의 이름입니다.</param>
		public void AddDatabase(string dbname)
		{
			ObjectNode databaseNode = new ObjectNode(this.m_activateNode, dbname, ObjectNodeType.MySqlDatabase);
			string[] folderList = { "테이블", "뷰", "저장 프로시저", "함수", "트리거", "이벤트" };
			m_activateNode.Nodes.Add(databaseNode);

			foreach(string folder in folderList)
			{
				ObjectNode folderNode = new ObjectNode(databaseNode, folder, ObjectNodeType.Folder);
				databaseNode.Nodes.Add(folderNode);
				folderNode.Nodes.Add(new ObjectNode(folderNode, "null", ObjectNodeType.MySqlTable));
			}
		}

		/// <summary>
		/// 현재 활성화된 연결의 인덱스를 나타냅니다.
		/// </summary>
		public int ActivateConnection
		{
			set
			{
				this.SelectedNode = this.Nodes[value];
			}
		}

		public Node ActivateNode
		{
			get
			{
				return this.m_activateNode;
			}
		}

		private ObjectNode m_activateNode = null;
	}
}