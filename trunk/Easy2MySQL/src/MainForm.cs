
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
			InitializeComponent();
			InitializeDockManager();
			CreateObjectBrowser();
		}

		/// <summary>
		/// OnLoad 이벤트 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트 객체입니다.</param>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			// 구문강조 코드를 기술함
		}

		#region 도킹매니저

		private DotNetBarManager m_dotNetBarManager;		// 도킹매니저

		/// <summary>
		/// 도킹매니저를 초기화합니다.
		/// </summary>
		private void InitializeDockManager()
		{
			this.m_dotNetBarManager = new DotNetBarManager(this.components);
			this.m_leftDockSite.SuspendLayout();
			//
			// m_dotNetBarManager
			//
			this.m_dotNetBarManager.ParentForm = this;
			this.m_dotNetBarManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_dotNetBarManager.FillDockSite = this.m_fillDockSite;
			this.m_dotNetBarManager.TopDockSite = this.m_topDockSite;
			this.m_dotNetBarManager.LeftDockSite = this.m_leftDockSite;
			this.m_dotNetBarManager.BottomDockSite = this.m_bottomDockSite;
			this.m_dotNetBarManager.RightDockSite = this.m_rightDockSite;
			// 
			// m_fillDockSite
			// 
			this.m_fillDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.m_fillDockSite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_fillDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.m_fillDockSite.Location = new System.Drawing.Point(279, 181);
			this.m_fillDockSite.Name = "m_fillDockSite";
			this.m_fillDockSite.Size = new System.Drawing.Size(831, 227);
			this.m_fillDockSite.TabStop = false;
			// 
			// m_topDockSite
			// 
			this.m_topDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.m_topDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_topDockSite.Location = new System.Drawing.Point(4, 181);
			this.m_topDockSite.Name = "m_topDockSite";
			this.m_topDockSite.Size = new System.Drawing.Size(1106, 0);
			this.m_topDockSite.TabStop = false;
			// 
			// m_leftDockSite
			// 
			this.m_leftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.m_leftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_leftDockSite.Location = new System.Drawing.Point(4, 181);
			this.m_leftDockSite.Name = "m_leftDockSite";
			this.m_leftDockSite.Size = new System.Drawing.Size(275, 424);
			this.m_leftDockSite.TabStop = false;
			// 
			// m_rightDockSite
			// 
			this.m_rightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.m_rightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_rightDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.m_rightDockSite.Location = new System.Drawing.Point(1110, 181);
			this.m_rightDockSite.Name = "m_rightDockSite";
			this.m_rightDockSite.Size = new System.Drawing.Size(0, 227);
			this.m_rightDockSite.TabStop = false;
			// 
			// m_bottomDockSite
			// 
			this.m_bottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.m_bottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_bottomDockSite.Location = new System.Drawing.Point(279, 408);
			this.m_bottomDockSite.Name = "m_bottomDockSite";
			this.m_bottomDockSite.Size = new System.Drawing.Size(831, 197);
			this.m_bottomDockSite.TabIndex = 5;
			this.m_bottomDockSite.TabStop = false;

			this.m_leftDockSite.ResumeLayout(false);
		}

		private Bar m_objectBrowserDockBar = new Bar();
		private PanelDockContainer m_objectBrowserContainer = new PanelDockContainer();
		private DockContainerItem m_objectBrowserContainerItem = new DockContainerItem();

		/// <summary>
		/// 
		/// </summary>
		void CreateObjectBrowser()
		{
			((System.ComponentModel.ISupportInitialize)(this.m_objectBrowserDockBar)).BeginInit();
			this.m_objectBrowserDockBar.SuspendLayout();
			// 
			// m_objectBrowserDockBar
			// 
			this.m_objectBrowserDockBar.AutoSyncBarCaption = true;
			this.m_objectBrowserDockBar.CloseSingleTab = true;
			this.m_objectBrowserDockBar.Controls.Add(this.m_objectBrowserContainer);
			this.m_objectBrowserDockBar.DockOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_objectBrowserDockBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.CaptionDotted;
			this.m_objectBrowserDockBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
				this.m_objectBrowserContainerItem});
			this.m_objectBrowserDockBar.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
			this.m_objectBrowserDockBar.Location = new System.Drawing.Point(0, 0);
			this.m_objectBrowserDockBar.Name = "m_objectBrowserDockBar";
			this.m_objectBrowserDockBar.Size = new System.Drawing.Size(272, 424);
			this.m_objectBrowserDockBar.Stretch = true;
			this.m_objectBrowserDockBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_objectBrowserDockBar.TabStop = false;
			this.m_objectBrowserDockBar.Text = "오브젝트 브라우저";
			// 
			// m_objectBrowserDockContainer
			// 
			this.m_objectBrowserContainer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_objectBrowserContainer.Location = new System.Drawing.Point(3, 26);
			this.m_objectBrowserContainer.Name = "m_objectBrowserDockContainer";
			this.m_objectBrowserContainer.Size = new System.Drawing.Size(266, 395);
			this.m_objectBrowserContainer.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.m_objectBrowserContainer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.m_objectBrowserContainer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.m_objectBrowserContainer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.m_objectBrowserContainer.Style.GradientAngle = 90;
			//
			// m_objectBrowserDockContainerItem
			//
			this.m_objectBrowserContainerItem.Control = this.m_objectBrowserContainer;
			this.m_objectBrowserContainerItem.Name = "m_objectBrowserDockContainerItem";
			this.m_objectBrowserContainerItem.Text = "오브젝트 브라우저";

			this.m_leftDockSite.Controls.Add(this.m_objectBrowserDockBar);
			this.m_leftDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
				((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.m_objectBrowserDockBar, 272, 424)))}, DevComponents.DotNetBar.eOrientation.Horizontal);

			((System.ComponentModel.ISupportInitialize)(this.m_objectBrowserDockBar)).EndInit();
			this.m_objectBrowserDockBar.ResumeLayout(false);
		}

		#endregion

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
	}
}
