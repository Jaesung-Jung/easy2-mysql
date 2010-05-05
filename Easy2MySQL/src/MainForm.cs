
// MainForm.cs
//
using System;
using System.Drawing;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 메인폼 클래스입니다.
	/// </summary>
	public partial class MainForm : Office2007RibbonForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public MainForm()
		{
			this.m_dockManager = new DockManager(this);
			InitializeComponent();
		}

		/// <summary>
		/// OnLoad 이벤트 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트 객체입니다.</param>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			ObjectBrowser item1 = new ObjectBrowser();
			ObjectBrowser item2 = new ObjectBrowser("메롱1");
			ObjectBrowser item3 = new ObjectBrowser("사랑해");

			this.m_dockManager.Dock(item1, eDockSide.Left);
			this.m_dockManager.Dock(item1, item2, eDockSide.Bottom);
			this.m_dockManager.Dock(item3, eDockSide.Top);
		}

		/// <summary>
		/// 테마커맨드 이벤트입니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트정보 객체입니다.</param>
		protected void OnExecutedThemeCommand(object sender, System.EventArgs e)
		{
			ICommandSource source = sender as ICommandSource;
			if(source.CommandParameter is string)
			{
				eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
				// Using StyleManager change the style and color tinting
				StyleManager.ChangeStyle(style, Color.Empty);
			}
		}

		private DockManager m_dockManager;
	}
}
