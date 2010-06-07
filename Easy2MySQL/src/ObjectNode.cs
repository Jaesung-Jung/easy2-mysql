
// ObjectNode.cs
//
using DevComponents.AdvTree;

namespace Easy2
{
	/// <summary>
	/// ObjectTree의 노드클래스입니다.
	/// </summary>
	public class ObjectNode : Node
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="parentNode">부모 노드입니다.</param>
		/// <param name="text">문자열입니다.</param>
		public ObjectNode(ObjectNode parentNode, string text, ObjectNodeType type)
		{
			this.m_parentNode = parentNode;
			this.Text = text;
			this.NodeType = type;

			switch(type)
			{
				case ObjectNodeType.MySqlServer:
					this.Image = Properties.Resources.MySqlServerDeactivate;
					break;
					
				case ObjectNodeType.MySqlDatabase:
					this.Image = Properties.Resources.MySqlDatabase;
					break;

				case ObjectNodeType.MySqlTable:
					this.Image = Properties.Resources.MysqlTable;
					break;

				case ObjectNodeType.MySqlColumn:
					this.Image = Properties.Resources.MySqlColumn;
					break;

				case  ObjectNodeType.MySqlPkColumn:
					this.Image = Properties.Resources.MySqlPrimaryKey;
					break;

				case ObjectNodeType.Folder:
					this.Image = Properties.Resources.FolderClose;
					break;
			}
		}

		/// <summary>
		/// 부모노드를 나타냅니다.
		/// </summary>
		public ObjectNode ParentNode
		{
			get { return this.m_parentNode; }
			set { this.m_parentNode = value; }
		}

		/// <summary>
		/// 노드의 형식을 나타냅니다.
		/// </summary>
		public ObjectNodeType NodeType
		{
			get { return this.m_nodeType; }
			set { this.m_nodeType = value; }
		}

		private ObjectNode m_parentNode;
		private ObjectNodeType m_nodeType;
	}

	/// <summary>
	/// 노드타입을 나타내는 열거형입니다.
	/// </summary>
	public enum ObjectNodeType
	{
		MySqlServer,
		MySqlDatabase,
		MySqlTable,
		MySqlView,
		MySqlStoredProcs,
		MySqlFunction,
		MySqlTrigger,
		MySqlEvent,
		MySqlColumn,
		MySqlPkColumn,
		MySqlIndex,
		MySqlPkIndex,
		Folder,
	}
}