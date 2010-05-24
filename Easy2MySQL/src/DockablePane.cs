
// DockablePane.cs
//
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 도킹 브라우저 클래스입니다.
	/// </summary>
	class DockablePane : Bar
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public DockablePane()
		{
			this.m_dockItem = new DockContainerItem();
			//
			// m_dockBar
			//
			this.CanHide = true;
			this.Stretch = true;
			this.LayoutType = eLayoutType.DockContainer;
			this.Style = eDotNetBarStyle.StyleManagerControlled;
			this.GrabHandleStyle = eGrabHandleStyle.CaptionDotted;
			this.Items.Add(this.m_dockItem);
		}

		/// <summary>
		/// Text 속성이 변경될 때 수행합니다.
		/// </summary>
		/// <param name="e">이벤트 객체입니다.</param>
		protected override void OnTextChanged(System.EventArgs e)
		{
			base.OnTextChanged(e);
			this.m_dockItem.Text = this.Text;
		}

		protected Control Control
		{
			get { return this.m_dockItem.Control; }
			set { this.m_dockItem.Control = value; }
		}

		private DockContainerItem m_dockItem;
	}
}
