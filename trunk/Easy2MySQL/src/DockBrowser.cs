
// DockBrowser.cs
//
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 도킹 브라우저 클래스입니다.
	/// </summary>
	class DockBrowser : Bar
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="captionText">캡션 문자열입니다.</param>
		public DockBrowser(string captionText) : base(captionText)
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
			//
			// m_dockItem
			//
			this.m_dockItem.Text = captionText;
		}

		protected DockContainerItem m_dockItem;
	}
}
