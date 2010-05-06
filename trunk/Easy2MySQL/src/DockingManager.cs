
// DockManager.cs
//
using DevComponents.DotNetBar;
using System.ComponentModel;
using System.Windows.Forms;

namespace Easy2
{
	/// <summary>
	/// 도킹 매니저 클래스입니다.
	/// </summary>
	class DockingManager : DotNetBarManager
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="parentForm">도킹 매니저가 관리할 폼입니다.</param>
		public DockingManager(Form parentForm)
		{
			this.m_topDockSite = new DockSite();
			this.m_bottomDockSite = new DockSite();
			this.m_leftDockSite = new DockSite();
			this.m_rightDockSite = new DockSite();
			//
			// m_topDockSite
			//
			this.m_topDockSite.AccessibleRole = AccessibleRole.Window;
			this.m_topDockSite.Dock = DockStyle.Top;
			this.m_topDockSite.DocumentDockContainer = new DocumentDockContainer();
			//
			// m_bottomDockSite
			//
			this.m_bottomDockSite.AccessibleRole = AccessibleRole.Window;
			this.m_bottomDockSite.Dock = DockStyle.Bottom;
			this.m_bottomDockSite.DocumentDockContainer = new DocumentDockContainer();
			//
			// m_leftDockSite
			//
			this.m_leftDockSite.AccessibleRole = AccessibleRole.Window;
			this.m_leftDockSite.Dock = DockStyle.Left;
			this.m_leftDockSite.DocumentDockContainer = new DocumentDockContainer();
			//
			// m_rightDockSite
			//
			this.m_rightDockSite.AccessibleRole = AccessibleRole.Window;
			this.m_rightDockSite.Dock = DockStyle.Right;
			this.m_rightDockSite.DocumentDockContainer = new DocumentDockContainer();
			//
			// DockManager
			//
			this.ParentForm = parentForm;
			this.TopDockSite = this.m_topDockSite;
			this.BottomDockSite = this.m_bottomDockSite;
			this.LeftDockSite = this.m_leftDockSite;
			this.RightDockSite = this.m_rightDockSite;
			this.Style = eDotNetBarStyle.StyleManagerControlled;
			//
			// parentForm
			//
			parentForm.Controls.Add(this.m_topDockSite);
			parentForm.Controls.Add(this.m_bottomDockSite);
			parentForm.Controls.Add(this.m_leftDockSite);
			parentForm.Controls.Add(this.m_rightDockSite);
		}

		private DockSite m_topDockSite;
		private DockSite m_bottomDockSite;
		private DockSite m_leftDockSite;
		private DockSite m_rightDockSite;
	}
}
