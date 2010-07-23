﻿
// DockablePane.cs
//
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 도킹이 가능한 팬 클래스입니다.
	/// </summary>
	public class DockablePane : Bar
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public DockablePane(string s)
		{
			this.m_dockItem = new DockContainerItem();
			this.m_dockItem.Text = s;
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