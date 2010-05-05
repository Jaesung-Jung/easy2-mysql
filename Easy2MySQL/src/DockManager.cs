
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
	class DockManager : DotNetBarManager
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="parentForm">도킹 매니저가 관리할 폼입니다.</param>
		public DockManager(Form parentForm)
		{
			this.m_components = new Container();
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

		/// <summary>
		/// 윈도우를 도킹시킵니다.
		/// </summary>
		/// <param name="bar">도킹할 컨트롤입니다.</param>
		/// <param name="dockSide">도킹 위치입니다.</param>
		public void Dock(Bar bar, eDockSide dockSide)
		{
			this.Bars.Add(bar);
			
			switch(dockSide)
			{
				case eDockSide.Top:
					this.m_topDockSite.GetDocumentUIManager().Dock(bar);
					break;
				case  eDockSide.Bottom:
					this.m_bottomDockSite.GetDocumentUIManager().Dock(bar);
					break;
				case eDockSide.Left:
					this.m_leftDockSite.GetDocumentUIManager().Dock(bar);
					break;
				case  eDockSide.Right:
					this.m_rightDockSite.GetDocumentUIManager().Dock(bar);
					break;
			}
		}

		/// <summary>
		/// 윈도우를 도킹시킵니다.
		/// </summary>
		/// <param name="target">도킹의 기준이 될 컨트롤입니다.</param>
		/// <param name="bar">도킹할 컨트롤입니다.</param>
		/// <param name="dockSide">도킹 위치입니다.</param>
		public void Dock(Bar target, Bar bar, eDockSide dockSide)
		{
			this.Bars.Add(bar);

			switch(target.DockSide)
			{
				case eDockSide.Top:
					this.m_topDockSite.GetDocumentUIManager().Dock(target, bar, dockSide);
					break;
				case eDockSide.Bottom:
					this.m_bottomDockSite.GetDocumentUIManager().Dock(target, bar, dockSide);
					break;
				case eDockSide.Left:
					this.m_leftDockSite.GetDocumentUIManager().Dock(target, bar, dockSide);
					break;
				case eDockSide.Right:
					this.m_rightDockSite.GetDocumentUIManager().Dock(target, bar, dockSide);
					break;
			}
		}

		private IContainer m_components;
		private DockSite m_topDockSite;
		private DockSite m_bottomDockSite;
		private DockSite m_leftDockSite;
		private DockSite m_rightDockSite;
	}
}
