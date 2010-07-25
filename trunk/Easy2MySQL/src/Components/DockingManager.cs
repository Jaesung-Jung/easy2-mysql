
// DockManager.cs
//
using DevComponents.DotNetBar;
using System.ComponentModel;
using System.Windows.Forms;

namespace Easy2.Components
{
	/// <summary>
	/// 도킹 매니저 클래스입니다.
	/// </summary>
	public class DockingManager : DotNetBarManager
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
			this.m_fillDockSite = new DockSite();
			//
			// m_fillDockSite
			//
			this.m_fillDockSite.AccessibleRole = AccessibleRole.Window;
			this.m_fillDockSite.Dock = DockStyle.Fill;
			this.m_fillDockSite.DocumentDockContainer = new DocumentDockContainer();
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
			// parentForm
			//
			parentForm.Controls.Add(this.m_fillDockSite);
			parentForm.Controls.Add(this.m_topDockSite);
			parentForm.Controls.Add(this.m_bottomDockSite);
			parentForm.Controls.Add(this.m_leftDockSite);
			parentForm.Controls.Add(this.m_rightDockSite);
			//
			// DockManager
			//
			this.FillDockSite = this.m_fillDockSite;
			this.TopDockSite = this.m_topDockSite;
			this.BottomDockSite = this.m_bottomDockSite;
			this.LeftDockSite = this.m_leftDockSite;
			this.RightDockSite = this.m_rightDockSite;
			this.ParentForm = parentForm;
			this.Style = eDotNetBarStyle.StyleManagerControlled;
			this.DockTabChange += new DockTabChangeEventHandler(OnDockTabChanged);
		}

		/// <summary>
		/// 도킹된 탭이 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDockTabChanged(object sender, DockTabChangeEventArgs e)
		{
			DockablePane dockablePane = sender as DockablePane;
			if(dockablePane == null || e.NewTab == null)
				return;
			dockablePane.Text = e.NewTab.Text;
		}

		/// <summary>
		/// 채우기 도킹 사이트입니다.
		/// </summary>
		public DockSite FillDock
		{
			get	{ return this.m_fillDockSite; }
			set { this.m_fillDockSite = value; }
		}

		/// <summary>
		/// 윗쪽 도킹 사이트입니다.
		/// </summary>
		public DockSite TopDock
		{
			get { return this.m_topDockSite; }
			set { this.m_topDockSite = value; }
		}

		/// <summary>
		/// 아랫쪽 도킹 사이트입니다.
		/// </summary>
		public DockSite BottomDock
		{
			get { return this.m_bottomDockSite; }
			set { this.m_bottomDockSite = value; }
		}

		/// <summary>
		/// 왼쪽 도킹 사이트입니다.
		/// </summary>
		public DockSite LeftDock
		{
			get { return this.m_bottomDockSite; }
			set { this.m_bottomDockSite = value; }
		}

		/// <summary>
		/// 오른쪽 도킹 사이트입니다.
		/// </summary>
		public DockSite RightDock
		{
			get { return this.m_rightDockSite; }
			set { this.m_rightDockSite = value; }
		}

		private DockSite m_fillDockSite;
		private DockSite m_topDockSite;
		private DockSite m_bottomDockSite;
		private DockSite m_leftDockSite;
		private DockSite m_rightDockSite;
	}
}
