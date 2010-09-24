
// DockablePane.cs
//
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2.Components
{
	/// <summary>
	/// 도킹이 가능한 팬 클래스입니다.
	/// </summary>
	public class DockablePane : Bar
	{
		/// <summary>
		/// 타이틀바에 지정된 문자열을 표시하는 DockablePane 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="s">
		/// 타이틀바에 표시할 문자열입니다.
		/// </param>
		public DockablePane(string s)
		{
			this.m_dockItem = new DockContainerItem();
			this.m_dockItem.Text = s;
			//
			// m_dockBar
			//
			this.AccessibleRole = AccessibleRole.ToolBar;
			this.Stretch = true;
			this.LayoutType = eLayoutType.DockContainer;
			this.Style = eDotNetBarStyle.StyleManagerControlled;
			this.GrabHandleStyle = eGrabHandleStyle.CaptionDotted;
			this.Items.Add(this.m_dockItem);
		}

		/// <summary>
		/// 컨트롤 객체를 나타냅니다.
		/// </summary>
		protected Control Control
		{
			get { return this.m_dockItem.Control; }
			set { this.m_dockItem.Control = value; }
		}

		private DockContainerItem m_dockItem;
	}
}
