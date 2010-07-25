
// ObjectBrowser.cs
//
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;

namespace Easy2.Components
{
	/// <summary>
	/// 오브젝트 브라우저 클래스입니다.
	/// </summary>
	/// <remarks>
	/// 오브젝트 브라우저는 MySQL 개체들을 사용자에게 보여줍니다.
	/// </remarks>
	public class ObjectBrowser : DockablePane
	{
		/// <summary>
		/// 타이틀바에 지정된 문자열을 표시하는 ObjectBrowser 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="s">
		/// 타이틀바에서 표시할 문자열입니다.
		/// </param>
		public ObjectBrowser(string s) : base(s)
		{
			this.m_objectTree = new ObjectTree();
			this.m_nodeStyle = new ElementStyle();
			((ISupportInitialize)(this.m_objectTree)).BeginInit();
			this.m_objectTree.SuspendLayout();
			//
			// m_objectTree
			//
			this.m_objectTree.AccessibleRole = AccessibleRole.Outline;
			this.m_objectTree.AllowDrop = true;
			this.m_objectTree.BackColor = SystemColors.Window;
			this.m_objectTree.Dock = DockStyle.Fill;
			this.m_objectTree.NodeStyle = this.m_nodeStyle;
			this.m_objectTree.Styles.Add(this.m_nodeStyle);
			//
			// m_nodeStyle
			//
			this.m_nodeStyle.TextColor = SystemColors.ControlText;

			this.m_objectTree.ResumeLayout();
			((ISupportInitialize)(this.m_objectTree)).EndInit();
			this.Control = this.m_objectTree;
			this.Text = s;
		}

		/// <summary>
		/// 트리컨트롤을 나타냅니다.
		/// </summary>
		public ObjectTree Tree
		{
			get { return this.m_objectTree; }
		}

		private ObjectTree m_objectTree;
		private ElementStyle m_nodeStyle;
	}
}
