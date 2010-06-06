
// ObjectBrowser.cs
//
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 오브젝트 브라우저 클래스입니다.
	/// </summary>
	public class ObjectBrowser : DockablePane
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public ObjectBrowser(string s) : base(s)
		{
			this.m_objectTreeView = new ObjectTreeView();
			this.m_nodeStyle = new ElementStyle();
			((ISupportInitialize)(this.m_objectTreeView)).BeginInit();
			this.m_objectTreeView.SuspendLayout();
			//
			// m_objectTreeView
			//
			this.m_objectTreeView.AccessibleRole = AccessibleRole.Outline;
			this.m_objectTreeView.AllowDrop = true;
			this.m_objectTreeView.BackColor = SystemColors.Window;
			this.m_objectTreeView.Dock = DockStyle.Fill;
			this.m_objectTreeView.NodeStyle = this.m_nodeStyle;
			this.m_objectTreeView.Styles.Add(this.m_nodeStyle);
			//
			// m_nodeStyle
			//
			this.m_nodeStyle.TextColor = SystemColors.ControlText;

			this.m_objectTreeView.ResumeLayout();
			((ISupportInitialize)(this.m_objectTreeView)).EndInit();
			this.Control = this.m_objectTreeView;
			this.Text = s;
		}

		private ObjectTreeView m_objectTreeView;
		private ElementStyle m_nodeStyle;
	}
}
