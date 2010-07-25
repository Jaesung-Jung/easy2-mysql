
// ObjectNode.cs
//
using Easy2.Properties;
using DevComponents.AdvTree;

namespace Easy2.Components
{
	/// <summary>
	/// ObjectTree의 하나의 노드를 나타냅니다.
	/// </summary>
	public class ObjectNode : Node
	{
		/// <summary>
		/// ObjectNode 인스턴스를 초기화합니다.
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
					this.Image = Resources.TreeServerDeactivate;
					break;
					
				case ObjectNodeType.MySqlDatabase:
					this.Image = Resources.TreeDatabase;
					break;

				case ObjectNodeType.MySqlTable:
					this.Image = Resources.TreeTable;
					break;

				case ObjectNodeType.MySqlView:
					this.Image = Resources.TreeView;
					break;

				case ObjectNodeType.MySqlStoredProcs:
					this.Image = Resources.TreeStoredProc;
					break;

				case ObjectNodeType.MySqlFunction:
					this.Image = Resources.TreeFunction;
					break;

				case ObjectNodeType.MySqlTrigger:
					this.Image = Resources.TreeTrigger;
					break;

				case ObjectNodeType.MySqlEvent:
					this.Image = Resources.TreeEvent;
					break;

				case ObjectNodeType.MySqlColumn:
					this.Image = Resources.TreeColumn;
					break;

				case ObjectNodeType.MySqlPkColumn:
					this.Image = Resources.TreePrimaryKey;
					break;

				case ObjectNodeType.MySqlIndex:
					this.Image = Resources.TreeIndex;
					break;

				case ObjectNodeType.MySqlPkIndex:
					this.Image = Resources.TreePkIndex;
					break;

				case ObjectNodeType.Folder:
					this.Image = Resources.FolderClose;
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