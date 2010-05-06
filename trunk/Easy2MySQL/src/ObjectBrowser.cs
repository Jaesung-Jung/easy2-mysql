
// ObjectBrowser.cs
//
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 오브젝트 브라우저 클래스입니다.
	/// </summary>
	class ObjectBrowser : DockablePane
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public ObjectBrowser()
		{
			this.m_objectTree = new TreeView();
			base.m_dockItem.Control = this.m_objectTree;

//			TreeNode node = this.m_objectTree.Nodes.Add("테스트");
//			node.Nodes.Add("차일드1");
//			node.Nodes.Add("차일드2");
//			node.Nodes.Add("차일드3");
//			this.m_objectTree.Nodes[0].Expand();
		}

		private TreeView m_objectTree;
	}
}
