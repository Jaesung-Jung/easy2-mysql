namespace Easy2
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.m_ribbonControl = new DevComponents.DotNetBar.RibbonControl();
			this.m_homePanel = new DevComponents.DotNetBar.RibbonPanel();
			this.m_tabBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_switchPreviousTab = new DevComponents.DotNetBar.ButtonItem();
			this.m_switchNextTab = new DevComponents.DotNetBar.ButtonItem();
			this.m_executeBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_executeQuery = new DevComponents.DotNetBar.ButtonItem();
			this.m_executeSelectQuery = new DevComponents.DotNetBar.ButtonItem();
			this.m_execyteAllQuery = new DevComponents.DotNetBar.ButtonItem();
			this.m_editBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_findData = new DevComponents.DotNetBar.ButtonItem();
			this.m_editItemContainer1 = new DevComponents.DotNetBar.ItemContainer();
			this.m_findNextData = new DevComponents.DotNetBar.ButtonItem();
			this.m_replaceData = new DevComponents.DotNetBar.ButtonItem();
			this.m_goToLine = new DevComponents.DotNetBar.ButtonItem();
			this.m_editItemContainer2 = new DevComponents.DotNetBar.ItemContainer();
			this.m_selectAll = new DevComponents.DotNetBar.ButtonItem();
			this.m_cancelSelection = new DevComponents.DotNetBar.ButtonItem();
			this.m_clearSelection = new DevComponents.DotNetBar.ButtonItem();
			this.m_editItemContainer3 = new DevComponents.DotNetBar.ItemContainer();
			this.m_undoAction = new DevComponents.DotNetBar.ButtonItem();
			this.m_redoAction = new DevComponents.DotNetBar.ButtonItem();
			this.m_clipboardBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_pasteToClipboard = new DevComponents.DotNetBar.ButtonItem();
			this.m_clipboardItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_cutSelection = new DevComponents.DotNetBar.ButtonItem();
			this.m_copySelection = new DevComponents.DotNetBar.ButtonItem();
			this.m_refreshBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_refreshObjectBrowser = new DevComponents.DotNetBar.ButtonItem();
			this.m_toolPanel = new DevComponents.DotNetBar.RibbonPanel();
			this.m_externalBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_importExternal = new DevComponents.DotNetBar.ButtonItem();
			this.m_exportExternal = new DevComponents.DotNetBar.ButtonItem();
			this.m_bakupBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_backupDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.m_restoreDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.m_openBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_openObject = new DevComponents.DotNetBar.ButtonItem();
			this.m_createPanel = new DevComponents.DotNetBar.RibbonPanel();
			this.m_objectBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_dropColumn = new DevComponents.DotNetBar.ButtonItem();
			this.m_createIndex = new DevComponents.DotNetBar.ButtonItem();
			this.m_indexItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterIndex = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropIndex = new DevComponents.DotNetBar.ButtonItem();
			this.m_createView = new DevComponents.DotNetBar.ButtonItem();
			this.m_viewItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterView = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropView = new DevComponents.DotNetBar.ButtonItem();
			this.m_createStoredProc = new DevComponents.DotNetBar.ButtonItem();
			this.m_storedProcItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterStoredProc = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropStoredProc = new DevComponents.DotNetBar.ButtonItem();
			this.m_createFunction = new DevComponents.DotNetBar.ButtonItem();
			this.m_functionitemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterFunction = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropFunction = new DevComponents.DotNetBar.ButtonItem();
			this.m_createTrigger = new DevComponents.DotNetBar.ButtonItem();
			this.m_triggerItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterTrigger = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropTrigger = new DevComponents.DotNetBar.ButtonItem();
			this.m_createEvent = new DevComponents.DotNetBar.ButtonItem();
			this.m_eventItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterEvent = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropEvent = new DevComponents.DotNetBar.ButtonItem();
			this.m_tableBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_createTable = new DevComponents.DotNetBar.ButtonItem();
			this.m_tableItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterTable = new DevComponents.DotNetBar.ButtonItem();
			this.m_truncateTable = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropTable = new DevComponents.DotNetBar.ButtonItem();
			this.m_databaseBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_createDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.m_databaseItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_alterDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.m_truncateDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.m_dropDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.m_userBar = new DevComponents.DotNetBar.RibbonBar();
			this.m_addUser = new DevComponents.DotNetBar.ButtonItem();
			this.m_alterUser = new DevComponents.DotNetBar.ButtonItem();
			this.m_privilegeUser = new DevComponents.DotNetBar.ButtonItem();
			this.m_homeTab = new DevComponents.DotNetBar.RibbonTabItem();
			this.m_createTab = new DevComponents.DotNetBar.RibbonTabItem();
			this.m_toolTab = new DevComponents.DotNetBar.RibbonTabItem();
			this.m_configGroup = new DevComponents.DotNetBar.ButtonItem();
			this.m_appSettings = new DevComponents.DotNetBar.ButtonItem();
			this.m_formTheme = new DevComponents.DotNetBar.ButtonItem();
			this.m_aeroSilverTheme = new DevComponents.DotNetBar.ButtonItem();
			this.m_themeCommand = new DevComponents.DotNetBar.Command();
			this.m_aeroBlueTheme = new DevComponents.DotNetBar.ButtonItem();
			this.m_officeBlueTheme = new DevComponents.DotNetBar.ButtonItem();
			this.m_officeBlackTheme = new DevComponents.DotNetBar.ButtonItem();
			this.m_officeSilverTheme = new DevComponents.DotNetBar.ButtonItem();
			this.m_officeNavyTheme = new DevComponents.DotNetBar.ButtonItem();
			this.m_helpGroup = new DevComponents.DotNetBar.ButtonItem();
			this.m_helpDocument = new DevComponents.DotNetBar.ButtonItem();
			this.m_updateCheck = new DevComponents.DotNetBar.ButtonItem();
			this.m_showAbout = new DevComponents.DotNetBar.ButtonItem();
			this.m_startButton = new DevComponents.DotNetBar.Office2007StartButton();
			this.m_fileItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_fileMenuItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_leftItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_newConnection = new DevComponents.DotNetBar.ButtonItem();
			this.m_newConnectionUsingCurrentSettings = new DevComponents.DotNetBar.ButtonItem();
			this.m_newQueryEditor = new DevComponents.DotNetBar.ButtonItem();
			this.m_newQueryWizard = new DevComponents.DotNetBar.ButtonItem();
			this.m_newSchemaDesigner = new DevComponents.DotNetBar.ButtonItem();
			this.m_closeTab = new DevComponents.DotNetBar.ButtonItem();
			this.m_disconnectMySql = new DevComponents.DotNetBar.ButtonItem();
			this.m_disconnectAllMySql = new DevComponents.DotNetBar.ButtonItem();
			this.m_openFileInSameTab = new DevComponents.DotNetBar.ButtonItem();
			this.m_openFileInNewTab = new DevComponents.DotNetBar.ButtonItem();
			this.m_saveFile = new DevComponents.DotNetBar.ButtonItem();
			this.m_saveAs = new DevComponents.DotNetBar.ButtonItem();
			this.m_rightItemContainer = new DevComponents.DotNetBar.GalleryContainer();
			this.m_recentLabel = new DevComponents.DotNetBar.LabelItem();
			this.m_botomItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.m_quitApplication = new DevComponents.DotNetBar.ButtonItem();
			this.m_styleManager = new DevComponents.DotNetBar.StyleManager();
			this.m_statusBar = new DevComponents.DotNetBar.Bar();
			this.m_ribbonControl.SuspendLayout();
			this.m_homePanel.SuspendLayout();
			this.m_toolPanel.SuspendLayout();
			this.m_createPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_statusBar)).BeginInit();
			this.SuspendLayout();
			// 
			// m_ribbonControl
			// 
			// 
			// 
			// 
			this.m_ribbonControl.BackgroundStyle.Class = "";
			this.m_ribbonControl.CaptionVisible = true;
			this.m_ribbonControl.Controls.Add(this.m_homePanel);
			this.m_ribbonControl.Controls.Add(this.m_toolPanel);
			this.m_ribbonControl.Controls.Add(this.m_createPanel);
			this.m_ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_startButton,
            this.m_homeTab,
            this.m_createTab,
            this.m_toolTab,
            this.m_configGroup,
            this.m_helpGroup});
			this.m_ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
			this.m_ribbonControl.Location = new System.Drawing.Point(4, 1);
			this.m_ribbonControl.Name = "m_ribbonControl";
			this.m_ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.m_ribbonControl.Size = new System.Drawing.Size(1106, 180);
			this.m_ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_ribbonControl.TabGroupHeight = 14;
			this.m_ribbonControl.TabIndex = 0;
			this.m_ribbonControl.Text = "ribbonControl1";
			// 
			// m_homePanel
			// 
			this.m_homePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_homePanel.Controls.Add(this.m_tabBar);
			this.m_homePanel.Controls.Add(this.m_executeBar);
			this.m_homePanel.Controls.Add(this.m_editBar);
			this.m_homePanel.Controls.Add(this.m_clipboardBar);
			this.m_homePanel.Controls.Add(this.m_refreshBar);
			this.m_homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_homePanel.Location = new System.Drawing.Point(0, 56);
			this.m_homePanel.Name = "m_homePanel";
			this.m_homePanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.m_homePanel.Size = new System.Drawing.Size(1106, 122);
			// 
			// 
			// 
			this.m_homePanel.Style.Class = "";
			// 
			// 
			// 
			this.m_homePanel.StyleMouseDown.Class = "";
			// 
			// 
			// 
			this.m_homePanel.StyleMouseOver.Class = "";
			this.m_homePanel.TabIndex = 1;
			// 
			// m_tabBar
			// 
			this.m_tabBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_tabBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_tabBar.BackgroundStyle.Class = "";
			this.m_tabBar.ContainerControlProcessDialogKey = true;
			this.m_tabBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_tabBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_switchPreviousTab,
            this.m_switchNextTab});
			this.m_tabBar.Location = new System.Drawing.Point(743, 0);
			this.m_tabBar.Name = "m_tabBar";
			this.m_tabBar.Size = new System.Drawing.Size(124, 119);
			this.m_tabBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_tabBar.TabIndex = 4;
			this.m_tabBar.Text = "탭";
			// 
			// 
			// 
			this.m_tabBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_tabBar.TitleStyleMouseOver.Class = "";
			// 
			// m_switchPreviousTab
			// 
			this.m_switchPreviousTab.Image = global::Easy2.Properties.Resources.SwitchPreviousTab;
			this.m_switchPreviousTab.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_switchPreviousTab.KeyTips = "TP";
			this.m_switchPreviousTab.Name = "m_switchPreviousTab";
			this.m_switchPreviousTab.SubItemsExpandWidth = 14;
			this.m_switchPreviousTab.Text = "이전 탭";
			// 
			// m_switchNextTab
			// 
			this.m_switchNextTab.Image = global::Easy2.Properties.Resources.SwitchNextTab;
			this.m_switchNextTab.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_switchNextTab.KeyTips = "TN";
			this.m_switchNextTab.Name = "m_switchNextTab";
			this.m_switchNextTab.SubItemsExpandWidth = 14;
			this.m_switchNextTab.Text = "다음 탭";
			// 
			// m_executeBar
			// 
			this.m_executeBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_executeBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_executeBar.BackgroundStyle.Class = "";
			this.m_executeBar.ContainerControlProcessDialogKey = true;
			this.m_executeBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_executeBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_executeQuery,
            this.m_executeSelectQuery,
            this.m_execyteAllQuery});
			this.m_executeBar.Location = new System.Drawing.Point(548, 0);
			this.m_executeBar.Name = "m_executeBar";
			this.m_executeBar.Size = new System.Drawing.Size(195, 119);
			this.m_executeBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_executeBar.TabIndex = 3;
			this.m_executeBar.Text = "실행";
			// 
			// 
			// 
			this.m_executeBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_executeBar.TitleStyleMouseOver.Class = "";
			// 
			// m_executeQuery
			// 
			this.m_executeQuery.Image = global::Easy2.Properties.Resources.ExecuteQuery;
			this.m_executeQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_executeQuery.KeyTips = "QE";
			this.m_executeQuery.Name = "m_executeQuery";
			this.m_executeQuery.SubItemsExpandWidth = 14;
			this.m_executeQuery.Text = "쿼리실행";
			// 
			// m_executeSelectQuery
			// 
			this.m_executeSelectQuery.Image = global::Easy2.Properties.Resources.ExecuteSelectQuery;
			this.m_executeSelectQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_executeSelectQuery.KeyTips = "QS";
			this.m_executeSelectQuery.Name = "m_executeSelectQuery";
			this.m_executeSelectQuery.SubItemsExpandWidth = 14;
			this.m_executeSelectQuery.Text = "<div align=\"center\">선택된<br/>쿼리실행</div>";
			// 
			// m_execyteAllQuery
			// 
			this.m_execyteAllQuery.Image = global::Easy2.Properties.Resources.ExecuteAllQuery;
			this.m_execyteAllQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_execyteAllQuery.KeyTips = "QA";
			this.m_execyteAllQuery.Name = "m_execyteAllQuery";
			this.m_execyteAllQuery.SubItemsExpandWidth = 14;
			this.m_execyteAllQuery.Text = "<div align=\"center\">모든<br/>쿼리실행</div>\r\n";
			// 
			// m_editBar
			// 
			this.m_editBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_editBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_editBar.BackgroundStyle.Class = "";
			this.m_editBar.ContainerControlProcessDialogKey = true;
			this.m_editBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_editBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_findData,
            this.m_editItemContainer1,
            this.m_editItemContainer2,
            this.m_editItemContainer3});
			this.m_editBar.Location = new System.Drawing.Point(233, 0);
			this.m_editBar.Name = "m_editBar";
			this.m_editBar.Size = new System.Drawing.Size(315, 119);
			this.m_editBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_editBar.TabIndex = 2;
			this.m_editBar.Text = "편집";
			// 
			// 
			// 
			this.m_editBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_editBar.TitleStyleMouseOver.Class = "";
			// 
			// m_findData
			// 
			this.m_findData.Image = global::Easy2.Properties.Resources.FindData;
			this.m_findData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_findData.KeyTips = "F";
			this.m_findData.Name = "m_findData";
			this.m_findData.SubItemsExpandWidth = 14;
			this.m_findData.Text = "찾기";
			// 
			// m_editItemContainer1
			// 
			// 
			// 
			// 
			this.m_editItemContainer1.BackgroundStyle.Class = "";
			this.m_editItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_editItemContainer1.Name = "m_editItemContainer1";
			this.m_editItemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_findNextData,
            this.m_replaceData,
            this.m_goToLine});
			this.m_editItemContainer1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// m_findNextData
			// 
			this.m_findNextData.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_findNextData.Image = global::Easy2.Properties.Resources.FindNextData;
			this.m_findNextData.KeyTips = "N";
			this.m_findNextData.Name = "m_findNextData";
			this.m_findNextData.Text = "다음찾기";
			// 
			// m_replaceData
			// 
			this.m_replaceData.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_replaceData.Image = global::Easy2.Properties.Resources.ReplaceData;
			this.m_replaceData.KeyTips = "E";
			this.m_replaceData.Name = "m_replaceData";
			this.m_replaceData.Text = "바꾸기";
			// 
			// m_goToLine
			// 
			this.m_goToLine.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_goToLine.Image = global::Easy2.Properties.Resources.GoToLine;
			this.m_goToLine.KeyTips = "G";
			this.m_goToLine.Name = "m_goToLine";
			this.m_goToLine.Text = "바로가기";
			// 
			// m_editItemContainer2
			// 
			// 
			// 
			// 
			this.m_editItemContainer2.BackgroundStyle.Class = "";
			this.m_editItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_editItemContainer2.Name = "m_editItemContainer2";
			this.m_editItemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_selectAll,
            this.m_cancelSelection,
            this.m_clearSelection});
			this.m_editItemContainer2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// m_selectAll
			// 
			this.m_selectAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_selectAll.Image = global::Easy2.Properties.Resources.SelectAll;
			this.m_selectAll.KeyTips = "A";
			this.m_selectAll.Name = "m_selectAll";
			this.m_selectAll.Text = "모두선택";
			// 
			// m_cancelSelection
			// 
			this.m_cancelSelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_cancelSelection.Image = global::Easy2.Properties.Resources.CancelSelection;
			this.m_cancelSelection.KeyTips = "X";
			this.m_cancelSelection.Name = "m_cancelSelection";
			this.m_cancelSelection.Text = "선택취소";
			// 
			// m_clearSelection
			// 
			this.m_clearSelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_clearSelection.Image = global::Easy2.Properties.Resources.DeleteSelection;
			this.m_clearSelection.KeyTips = "L";
			this.m_clearSelection.Name = "m_clearSelection";
			this.m_clearSelection.Text = "지우기";
			// 
			// m_editItemContainer3
			// 
			// 
			// 
			// 
			this.m_editItemContainer3.BackgroundStyle.Class = "";
			this.m_editItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_editItemContainer3.Name = "m_editItemContainer3";
			this.m_editItemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_undoAction,
            this.m_redoAction});
			this.m_editItemContainer3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// m_undoAction
			// 
			this.m_undoAction.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_undoAction.Image = global::Easy2.Properties.Resources.UndoAction;
			this.m_undoAction.KeyTips = "U";
			this.m_undoAction.Name = "m_undoAction";
			this.m_undoAction.Text = "실행취소";
			// 
			// m_redoAction
			// 
			this.m_redoAction.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_redoAction.Image = global::Easy2.Properties.Resources.RedoAction;
			this.m_redoAction.KeyTips = "O";
			this.m_redoAction.Name = "m_redoAction";
			this.m_redoAction.Text = "다시실행";
			// 
			// m_clipboardBar
			// 
			this.m_clipboardBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_clipboardBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_clipboardBar.BackgroundStyle.Class = "";
			this.m_clipboardBar.ContainerControlProcessDialogKey = true;
			this.m_clipboardBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_clipboardBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_pasteToClipboard,
            this.m_clipboardItemContainer});
			this.m_clipboardBar.Location = new System.Drawing.Point(76, 0);
			this.m_clipboardBar.Name = "m_clipboardBar";
			this.m_clipboardBar.Size = new System.Drawing.Size(157, 119);
			this.m_clipboardBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_clipboardBar.TabIndex = 1;
			this.m_clipboardBar.Text = "클립보드";
			// 
			// 
			// 
			this.m_clipboardBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_clipboardBar.TitleStyleMouseOver.Class = "";
			// 
			// m_pasteToClipboard
			// 
			this.m_pasteToClipboard.Image = global::Easy2.Properties.Resources.PasteToClipboard;
			this.m_pasteToClipboard.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_pasteToClipboard.KeyTips = "P";
			this.m_pasteToClipboard.Name = "m_pasteToClipboard";
			this.m_pasteToClipboard.SubItemsExpandWidth = 14;
			this.m_pasteToClipboard.Text = "붙여넣기";
			// 
			// m_clipboardItemContainer
			// 
			// 
			// 
			// 
			this.m_clipboardItemContainer.BackgroundStyle.Class = "";
			this.m_clipboardItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_clipboardItemContainer.Name = "m_clipboardItemContainer";
			this.m_clipboardItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_cutSelection,
            this.m_copySelection});
			this.m_clipboardItemContainer.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// m_cutSelection
			// 
			this.m_cutSelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_cutSelection.Image = global::Easy2.Properties.Resources.CutSelection;
			this.m_cutSelection.KeyTips = "T";
			this.m_cutSelection.Name = "m_cutSelection";
			this.m_cutSelection.Text = "잘라내기";
			// 
			// m_copySelection
			// 
			this.m_copySelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_copySelection.Image = global::Easy2.Properties.Resources.CopySelection;
			this.m_copySelection.KeyTips = "C";
			this.m_copySelection.Name = "m_copySelection";
			this.m_copySelection.Text = "복사하기";
			// 
			// m_refreshBar
			// 
			this.m_refreshBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_refreshBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_refreshBar.BackgroundStyle.Class = "";
			this.m_refreshBar.ContainerControlProcessDialogKey = true;
			this.m_refreshBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_refreshBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_refreshObjectBrowser});
			this.m_refreshBar.Location = new System.Drawing.Point(3, 0);
			this.m_refreshBar.Name = "m_refreshBar";
			this.m_refreshBar.Size = new System.Drawing.Size(73, 119);
			this.m_refreshBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_refreshBar.TabIndex = 0;
			this.m_refreshBar.Text = "새로고침";
			// 
			// 
			// 
			this.m_refreshBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_refreshBar.TitleStyleMouseOver.Class = "";
			// 
			// m_refreshObjectBrowser
			// 
			this.m_refreshObjectBrowser.Image = global::Easy2.Properties.Resources.RefreshObjectBrowser;
			this.m_refreshObjectBrowser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_refreshObjectBrowser.KeyTips = "R";
			this.m_refreshObjectBrowser.Name = "m_refreshObjectBrowser";
			this.m_refreshObjectBrowser.SubItemsExpandWidth = 14;
			this.m_refreshObjectBrowser.Text = "새로고침";
			// 
			// m_toolPanel
			// 
			this.m_toolPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_toolPanel.Controls.Add(this.m_externalBar);
			this.m_toolPanel.Controls.Add(this.m_bakupBar);
			this.m_toolPanel.Controls.Add(this.m_openBar);
			this.m_toolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_toolPanel.Location = new System.Drawing.Point(0, 56);
			this.m_toolPanel.Name = "m_toolPanel";
			this.m_toolPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.m_toolPanel.Size = new System.Drawing.Size(1106, 122);
			// 
			// 
			// 
			this.m_toolPanel.Style.Class = "";
			// 
			// 
			// 
			this.m_toolPanel.StyleMouseDown.Class = "";
			// 
			// 
			// 
			this.m_toolPanel.StyleMouseOver.Class = "";
			this.m_toolPanel.TabIndex = 3;
			this.m_toolPanel.Visible = false;
			// 
			// m_externalBar
			// 
			this.m_externalBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_externalBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_externalBar.BackgroundStyle.Class = "";
			this.m_externalBar.ContainerControlProcessDialogKey = true;
			this.m_externalBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_externalBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_importExternal,
            this.m_exportExternal});
			this.m_externalBar.Location = new System.Drawing.Point(198, 0);
			this.m_externalBar.Name = "m_externalBar";
			this.m_externalBar.Size = new System.Drawing.Size(140, 119);
			this.m_externalBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_externalBar.TabIndex = 2;
			this.m_externalBar.Text = "가져오기/내보내기";
			// 
			// 
			// 
			this.m_externalBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_externalBar.TitleStyleMouseOver.Class = "";
			// 
			// m_importExternal
			// 
			this.m_importExternal.Image = global::Easy2.Properties.Resources.ImportDatabase;
			this.m_importExternal.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_importExternal.KeyTips = "I";
			this.m_importExternal.Name = "m_importExternal";
			this.m_importExternal.SubItemsExpandWidth = 14;
			this.m_importExternal.Text = "가져오기";
			// 
			// m_exportExternal
			// 
			this.m_exportExternal.Image = global::Easy2.Properties.Resources.ExportDatabase;
			this.m_exportExternal.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_exportExternal.KeyTips = "E";
			this.m_exportExternal.Name = "m_exportExternal";
			this.m_exportExternal.SubItemsExpandWidth = 14;
			this.m_exportExternal.Text = "내보내기";
			// 
			// m_bakupBar
			// 
			this.m_bakupBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_bakupBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_bakupBar.BackgroundStyle.Class = "";
			this.m_bakupBar.ContainerControlProcessDialogKey = true;
			this.m_bakupBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_bakupBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_backupDatabase,
            this.m_restoreDatabase});
			this.m_bakupBar.Location = new System.Drawing.Point(70, 0);
			this.m_bakupBar.Name = "m_bakupBar";
			this.m_bakupBar.Size = new System.Drawing.Size(128, 119);
			this.m_bakupBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_bakupBar.TabIndex = 1;
			this.m_bakupBar.Text = "백업/복구";
			// 
			// 
			// 
			this.m_bakupBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_bakupBar.TitleStyleMouseOver.Class = "";
			// 
			// m_backupDatabase
			// 
			this.m_backupDatabase.Image = global::Easy2.Properties.Resources.CopyDatabase;
			this.m_backupDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_backupDatabase.KeyTips = "DB";
			this.m_backupDatabase.Name = "m_backupDatabase";
			this.m_backupDatabase.SubItemsExpandWidth = 14;
			this.m_backupDatabase.Text = "<div align=\"center\">DB<br/>백업하기</div>";
			// 
			// m_restoreDatabase
			// 
			this.m_restoreDatabase.Image = global::Easy2.Properties.Resources.RestoreDatabase;
			this.m_restoreDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_restoreDatabase.KeyTips = "DR";
			this.m_restoreDatabase.Name = "m_restoreDatabase";
			this.m_restoreDatabase.SubItemsExpandWidth = 14;
			this.m_restoreDatabase.Text = "<div align=\"center\">DB<br/>복원하기</div>";
			// 
			// m_openBar
			// 
			this.m_openBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_openBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_openBar.BackgroundStyle.Class = "";
			this.m_openBar.ContainerControlProcessDialogKey = true;
			this.m_openBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_openBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_openObject});
			this.m_openBar.Location = new System.Drawing.Point(3, 0);
			this.m_openBar.Name = "m_openBar";
			this.m_openBar.Size = new System.Drawing.Size(67, 119);
			this.m_openBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_openBar.TabIndex = 0;
			this.m_openBar.Text = "열기";
			// 
			// 
			// 
			this.m_openBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_openBar.TitleStyleMouseOver.Class = "";
			// 
			// m_openObject
			// 
			this.m_openObject.Image = global::Easy2.Properties.Resources.OpenObject;
			this.m_openObject.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_openObject.KeyTips = "O";
			this.m_openObject.Name = "m_openObject";
			this.m_openObject.SubItemsExpandWidth = 14;
			this.m_openObject.Text = "<div align=\"center\">오브젝트<br/>열기</div>";
			// 
			// m_createPanel
			// 
			this.m_createPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_createPanel.Controls.Add(this.m_objectBar);
			this.m_createPanel.Controls.Add(this.m_tableBar);
			this.m_createPanel.Controls.Add(this.m_databaseBar);
			this.m_createPanel.Controls.Add(this.m_userBar);
			this.m_createPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_createPanel.Location = new System.Drawing.Point(0, 56);
			this.m_createPanel.Name = "m_createPanel";
			this.m_createPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.m_createPanel.Size = new System.Drawing.Size(1106, 122);
			// 
			// 
			// 
			this.m_createPanel.Style.Class = "";
			// 
			// 
			// 
			this.m_createPanel.StyleMouseDown.Class = "";
			// 
			// 
			// 
			this.m_createPanel.StyleMouseOver.Class = "";
			this.m_createPanel.TabIndex = 2;
			this.m_createPanel.Visible = false;
			// 
			// m_objectBar
			// 
			this.m_objectBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_objectBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_objectBar.BackgroundStyle.Class = "";
			this.m_objectBar.ContainerControlProcessDialogKey = true;
			this.m_objectBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_objectBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_dropColumn,
            this.m_createIndex,
            this.m_createView,
            this.m_createStoredProc,
            this.m_createFunction,
            this.m_createTrigger,
            this.m_createEvent});
			this.m_objectBar.Location = new System.Drawing.Point(554, 0);
			this.m_objectBar.Name = "m_objectBar";
			this.m_objectBar.Size = new System.Drawing.Size(446, 119);
			this.m_objectBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_objectBar.TabIndex = 3;
			this.m_objectBar.Text = "오브젝트";
			// 
			// 
			// 
			this.m_objectBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_objectBar.TitleStyleMouseOver.Class = "";
			// 
			// m_dropColumn
			// 
			this.m_dropColumn.Image = global::Easy2.Properties.Resources.DropColumn;
			this.m_dropColumn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_dropColumn.KeyTips = "C";
			this.m_dropColumn.Name = "m_dropColumn";
			this.m_dropColumn.SubItemsExpandWidth = 14;
			this.m_dropColumn.Text = "<div align=\"center\">컬럼<br/>제거하기</div>";
			// 
			// m_createIndex
			// 
			this.m_createIndex.Image = global::Easy2.Properties.Resources.CreateIndex;
			this.m_createIndex.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createIndex.KeyTips = "I";
			this.m_createIndex.Name = "m_createIndex";
			this.m_createIndex.SplitButton = true;
			this.m_createIndex.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_indexItemContainer});
			this.m_createIndex.SubItemsExpandWidth = 14;
			this.m_createIndex.Text = "인덱스";
			// 
			// m_indexItemContainer
			// 
			// 
			// 
			// 
			this.m_indexItemContainer.BackgroundStyle.Class = "";
			this.m_indexItemContainer.Name = "m_indexItemContainer";
			this.m_indexItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterIndex,
            this.m_dropIndex});
			// 
			// m_alterIndex
			// 
			this.m_alterIndex.Image = global::Easy2.Properties.Resources.AlterIndex;
			this.m_alterIndex.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_alterIndex.KeyTips = "A";
			this.m_alterIndex.Name = "m_alterIndex";
			this.m_alterIndex.Text = "<div align=\"center\">인덱스<br/>수정하기</div>";
			// 
			// m_dropIndex
			// 
			this.m_dropIndex.Image = global::Easy2.Properties.Resources.DropIndex;
			this.m_dropIndex.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_dropIndex.KeyTips = "D";
			this.m_dropIndex.Name = "m_dropIndex";
			this.m_dropIndex.Text = "<div center=\"center\">인덱스<br/>제거하기</div>";
			// 
			// m_createView
			// 
			this.m_createView.Image = global::Easy2.Properties.Resources.CreateView;
			this.m_createView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createView.KeyTips = "V";
			this.m_createView.Name = "m_createView";
			this.m_createView.SplitButton = true;
			this.m_createView.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_viewItemContainer});
			this.m_createView.SubItemsExpandWidth = 14;
			this.m_createView.Text = "뷰";
			// 
			// m_viewItemContainer
			// 
			// 
			// 
			// 
			this.m_viewItemContainer.BackgroundStyle.Class = "";
			this.m_viewItemContainer.Name = "m_viewItemContainer";
			this.m_viewItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterView,
            this.m_dropView});
			// 
			// m_alterView
			// 
			this.m_alterView.Image = global::Easy2.Properties.Resources.AlterView;
			this.m_alterView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_alterView.KeyTips = "A";
			this.m_alterView.Name = "m_alterView";
			this.m_alterView.Text = "<div align=\"center\">뷰<br/>수정하기</div>";
			// 
			// m_dropView
			// 
			this.m_dropView.Image = global::Easy2.Properties.Resources.DropView;
			this.m_dropView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_dropView.KeyTips = "D";
			this.m_dropView.Name = "m_dropView";
			this.m_dropView.Text = "<div align=\"center\">뷰<br/>제거하기</div>";
			// 
			// m_createStoredProc
			// 
			this.m_createStoredProc.Image = global::Easy2.Properties.Resources.CreateStoredProcedure;
			this.m_createStoredProc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createStoredProc.KeyTips = "P";
			this.m_createStoredProc.Name = "m_createStoredProc";
			this.m_createStoredProc.SplitButton = true;
			this.m_createStoredProc.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_storedProcItemContainer});
			this.m_createStoredProc.SubItemsExpandWidth = 14;
			this.m_createStoredProc.Text = "저장프로시저";
			// 
			// m_storedProcItemContainer
			// 
			// 
			// 
			// 
			this.m_storedProcItemContainer.BackgroundStyle.Class = "";
			this.m_storedProcItemContainer.Name = "m_storedProcItemContainer";
			this.m_storedProcItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterStoredProc,
            this.m_dropStoredProc});
			// 
			// m_alterStoredProc
			// 
			this.m_alterStoredProc.Image = global::Easy2.Properties.Resources.AlterStoredProcedure;
			this.m_alterStoredProc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_alterStoredProc.KeyTips = "A";
			this.m_alterStoredProc.Name = "m_alterStoredProc";
			this.m_alterStoredProc.Text = "<div align=\"center\">저장프로시저<br/>수정하기</div>";
			// 
			// m_dropStoredProc
			// 
			this.m_dropStoredProc.Image = global::Easy2.Properties.Resources.DropStoredProcedure;
			this.m_dropStoredProc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_dropStoredProc.KeyTips = "D";
			this.m_dropStoredProc.Name = "m_dropStoredProc";
			this.m_dropStoredProc.Text = "<div align=\"center\">저장프로시저<br/>제거하기</div>";
			// 
			// m_createFunction
			// 
			this.m_createFunction.Image = global::Easy2.Properties.Resources.CreateFunction;
			this.m_createFunction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createFunction.KeyTips = "F";
			this.m_createFunction.Name = "m_createFunction";
			this.m_createFunction.SplitButton = true;
			this.m_createFunction.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_functionitemContainer});
			this.m_createFunction.SubItemsExpandWidth = 14;
			this.m_createFunction.Text = "함수";
			// 
			// m_functionitemContainer
			// 
			// 
			// 
			// 
			this.m_functionitemContainer.BackgroundStyle.Class = "";
			this.m_functionitemContainer.Name = "m_functionitemContainer";
			this.m_functionitemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterFunction,
            this.m_dropFunction});
			// 
			// m_alterFunction
			// 
			this.m_alterFunction.Image = global::Easy2.Properties.Resources.AlterFunction;
			this.m_alterFunction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_alterFunction.KeyTips = "A";
			this.m_alterFunction.Name = "m_alterFunction";
			this.m_alterFunction.Text = "<div align=\"center\">함수<br/>수정하기</div>";
			// 
			// m_dropFunction
			// 
			this.m_dropFunction.Image = global::Easy2.Properties.Resources.DropFunction;
			this.m_dropFunction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_dropFunction.KeyTips = "D";
			this.m_dropFunction.Name = "m_dropFunction";
			this.m_dropFunction.Text = "<div align=\"center\">함수<br/>제거하기</div>";
			// 
			// m_createTrigger
			// 
			this.m_createTrigger.Image = global::Easy2.Properties.Resources.CreateTrigger;
			this.m_createTrigger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createTrigger.KeyTips = "G";
			this.m_createTrigger.Name = "m_createTrigger";
			this.m_createTrigger.SplitButton = true;
			this.m_createTrigger.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_triggerItemContainer});
			this.m_createTrigger.SubItemsExpandWidth = 14;
			this.m_createTrigger.Text = "트리거";
			// 
			// m_triggerItemContainer
			// 
			// 
			// 
			// 
			this.m_triggerItemContainer.BackgroundStyle.Class = "";
			this.m_triggerItemContainer.Name = "m_triggerItemContainer";
			this.m_triggerItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterTrigger,
            this.m_dropTrigger});
			// 
			// m_alterTrigger
			// 
			this.m_alterTrigger.Image = global::Easy2.Properties.Resources.AlterTrigger;
			this.m_alterTrigger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_alterTrigger.KeyTips = "A";
			this.m_alterTrigger.Name = "m_alterTrigger";
			this.m_alterTrigger.Text = "<div align=\"center\">트리거<br/>수정하기</div>";
			// 
			// m_dropTrigger
			// 
			this.m_dropTrigger.Image = global::Easy2.Properties.Resources.DropTrigger;
			this.m_dropTrigger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_dropTrigger.KeyTips = "D";
			this.m_dropTrigger.Name = "m_dropTrigger";
			this.m_dropTrigger.Text = "<div align=\"center\">트리거<br/>제거하기</div>";
			// 
			// m_createEvent
			// 
			this.m_createEvent.Image = global::Easy2.Properties.Resources.CreateEvent;
			this.m_createEvent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createEvent.KeyTips = "E";
			this.m_createEvent.Name = "m_createEvent";
			this.m_createEvent.SplitButton = true;
			this.m_createEvent.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_eventItemContainer});
			this.m_createEvent.SubItemsExpandWidth = 14;
			this.m_createEvent.Text = "이벤트";
			// 
			// m_eventItemContainer
			// 
			// 
			// 
			// 
			this.m_eventItemContainer.BackgroundStyle.Class = "";
			this.m_eventItemContainer.Name = "m_eventItemContainer";
			this.m_eventItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterEvent,
            this.m_dropEvent});
			// 
			// m_alterEvent
			// 
			this.m_alterEvent.Image = global::Easy2.Properties.Resources.AlterEvent;
			this.m_alterEvent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_alterEvent.KeyTips = "A";
			this.m_alterEvent.Name = "m_alterEvent";
			this.m_alterEvent.Text = "<div align=\"center\">이벤트<br/>수정하기</div>";
			// 
			// m_dropEvent
			// 
			this.m_dropEvent.Image = global::Easy2.Properties.Resources.DropEvent;
			this.m_dropEvent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_dropEvent.KeyTips = "D";
			this.m_dropEvent.Name = "m_dropEvent";
			this.m_dropEvent.Text = "<div align=\"center\">이벤트<br/>제거하기</div>";
			// 
			// m_tableBar
			// 
			this.m_tableBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_tableBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_tableBar.BackgroundStyle.Class = "";
			this.m_tableBar.ContainerControlProcessDialogKey = true;
			this.m_tableBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_tableBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_createTable,
            this.m_tableItemContainer});
			this.m_tableBar.Location = new System.Drawing.Point(362, 0);
			this.m_tableBar.Name = "m_tableBar";
			this.m_tableBar.Size = new System.Drawing.Size(192, 119);
			this.m_tableBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_tableBar.TabIndex = 2;
			this.m_tableBar.Text = "테이블";
			// 
			// 
			// 
			this.m_tableBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_tableBar.TitleStyleMouseOver.Class = "";
			// 
			// m_createTable
			// 
			this.m_createTable.Image = global::Easy2.Properties.Resources.CreateTable;
			this.m_createTable.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createTable.KeyTips = "TC";
			this.m_createTable.Name = "m_createTable";
			this.m_createTable.SubItemsExpandWidth = 14;
			this.m_createTable.Text = "<div align=\"center\">테이블<br/>만들기</div>";
			// 
			// m_tableItemContainer
			// 
			// 
			// 
			// 
			this.m_tableItemContainer.BackgroundStyle.Class = "";
			this.m_tableItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_tableItemContainer.Name = "m_tableItemContainer";
			this.m_tableItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterTable,
            this.m_truncateTable,
            this.m_dropTable});
			this.m_tableItemContainer.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// m_alterTable
			// 
			this.m_alterTable.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_alterTable.Image = global::Easy2.Properties.Resources.AlterTable;
			this.m_alterTable.KeyTips = "TA";
			this.m_alterTable.Name = "m_alterTable";
			this.m_alterTable.Text = "테이블 수정하기";
			// 
			// m_truncateTable
			// 
			this.m_truncateTable.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_truncateTable.Image = global::Easy2.Properties.Resources.TruncateTable;
			this.m_truncateTable.KeyTips = "TT";
			this.m_truncateTable.Name = "m_truncateTable";
			this.m_truncateTable.Text = "테이블 비우기";
			// 
			// m_dropTable
			// 
			this.m_dropTable.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_dropTable.Image = global::Easy2.Properties.Resources.DropTable;
			this.m_dropTable.KeyTips = "TD";
			this.m_dropTable.Name = "m_dropTable";
			this.m_dropTable.Text = "테이블 제거하기";
			// 
			// m_databaseBar
			// 
			this.m_databaseBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_databaseBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_databaseBar.BackgroundStyle.Class = "";
			this.m_databaseBar.ContainerControlProcessDialogKey = true;
			this.m_databaseBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_databaseBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_createDatabase,
            this.m_databaseItemContainer});
			this.m_databaseBar.Location = new System.Drawing.Point(192, 0);
			this.m_databaseBar.Name = "m_databaseBar";
			this.m_databaseBar.Size = new System.Drawing.Size(170, 119);
			this.m_databaseBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_databaseBar.TabIndex = 1;
			this.m_databaseBar.Text = "데이터베이스";
			// 
			// 
			// 
			this.m_databaseBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_databaseBar.TitleStyleMouseOver.Class = "";
			// 
			// m_createDatabase
			// 
			this.m_createDatabase.Image = global::Easy2.Properties.Resources.CreateDatabase;
			this.m_createDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_createDatabase.KeyTips = "DC";
			this.m_createDatabase.Name = "m_createDatabase";
			this.m_createDatabase.SubItemsExpandWidth = 14;
			this.m_createDatabase.Text = "<div align=\"center\">DB<br/>만들기</div>";
			// 
			// m_databaseItemContainer
			// 
			// 
			// 
			// 
			this.m_databaseItemContainer.BackgroundStyle.Class = "";
			this.m_databaseItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_databaseItemContainer.Name = "m_databaseItemContainer";
			this.m_databaseItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_alterDatabase,
            this.m_truncateDatabase,
            this.m_dropDatabase});
			this.m_databaseItemContainer.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// m_alterDatabase
			// 
			this.m_alterDatabase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_alterDatabase.Image = global::Easy2.Properties.Resources.AlterDatabase;
			this.m_alterDatabase.KeyTips = "DA";
			this.m_alterDatabase.Name = "m_alterDatabase";
			this.m_alterDatabase.Text = "DB 수정하기";
			// 
			// m_truncateDatabase
			// 
			this.m_truncateDatabase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_truncateDatabase.Image = global::Easy2.Properties.Resources.TruncateDatabase;
			this.m_truncateDatabase.KeyTips = "DT";
			this.m_truncateDatabase.Name = "m_truncateDatabase";
			this.m_truncateDatabase.Text = "DB 비우기";
			// 
			// m_dropDatabase
			// 
			this.m_dropDatabase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_dropDatabase.Image = global::Easy2.Properties.Resources.DropDatabase;
			this.m_dropDatabase.KeyTips = "DD";
			this.m_dropDatabase.Name = "m_dropDatabase";
			this.m_dropDatabase.Text = "DB 제거하기";
			// 
			// m_userBar
			// 
			this.m_userBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.m_userBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.m_userBar.BackgroundStyle.Class = "";
			this.m_userBar.ContainerControlProcessDialogKey = true;
			this.m_userBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_userBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_addUser,
            this.m_alterUser,
            this.m_privilegeUser});
			this.m_userBar.Location = new System.Drawing.Point(3, 0);
			this.m_userBar.Name = "m_userBar";
			this.m_userBar.Size = new System.Drawing.Size(189, 119);
			this.m_userBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_userBar.TabIndex = 0;
			this.m_userBar.Text = "사용자";
			// 
			// 
			// 
			this.m_userBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.m_userBar.TitleStyleMouseOver.Class = "";
			// 
			// m_addUser
			// 
			this.m_addUser.Image = global::Easy2.Properties.Resources.AddUser;
			this.m_addUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_addUser.KeyTips = "UA";
			this.m_addUser.Name = "m_addUser";
			this.m_addUser.SplitButton = true;
			this.m_addUser.SubItemsExpandWidth = 14;
			this.m_addUser.Text = "<div align=\"center\">사용자<br/>추가하기</div>";
			// 
			// m_alterUser
			// 
			this.m_alterUser.Image = global::Easy2.Properties.Resources.AlterUser;
			this.m_alterUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_alterUser.KeyTips = "UE";
			this.m_alterUser.Name = "m_alterUser";
			this.m_alterUser.SubItemsExpandWidth = 14;
			this.m_alterUser.Text = "<div align=\"center\">사용자<br/>수정하기</div>";
			// 
			// m_privilegeUser
			// 
			this.m_privilegeUser.Image = global::Easy2.Properties.Resources.PrivilegeUser;
			this.m_privilegeUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.m_privilegeUser.KeyTips = "UP";
			this.m_privilegeUser.Name = "m_privilegeUser";
			this.m_privilegeUser.SubItemsExpandWidth = 14;
			this.m_privilegeUser.Text = "<div align=\"center\">권한<br/>설정하기</div>";
			// 
			// m_homeTab
			// 
			this.m_homeTab.Checked = true;
			this.m_homeTab.KeyTips = "H";
			this.m_homeTab.Name = "m_homeTab";
			this.m_homeTab.Panel = this.m_homePanel;
			this.m_homeTab.Text = "홈";
			// 
			// m_createTab
			// 
			this.m_createTab.KeyTips = "C";
			this.m_createTab.Name = "m_createTab";
			this.m_createTab.Panel = this.m_createPanel;
			this.m_createTab.Text = "만들기";
			// 
			// m_toolTab
			// 
			this.m_toolTab.KeyTips = "T";
			this.m_toolTab.Name = "m_toolTab";
			this.m_toolTab.Panel = this.m_toolPanel;
			this.m_toolTab.Text = "도구";
			// 
			// m_configGroup
			// 
			this.m_configGroup.AutoExpandOnClick = true;
			this.m_configGroup.Image = ((System.Drawing.Image)(resources.GetObject("m_configGroup.Image")));
			this.m_configGroup.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.m_configGroup.Name = "m_configGroup";
			this.m_configGroup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_appSettings,
            this.m_formTheme});
			// 
			// m_appSettings
			// 
			this.m_appSettings.Image = global::Easy2.Properties.Resources.Settings;
			this.m_appSettings.Name = "m_appSettings";
			this.m_appSettings.Text = "환경설정(&U)...";
			// 
			// m_formTheme
			// 
			this.m_formTheme.AutoExpandOnClick = true;
			this.m_formTheme.BeginGroup = true;
			this.m_formTheme.Image = global::Easy2.Properties.Resources.FormStyle;
			this.m_formTheme.Name = "m_formTheme";
			this.m_formTheme.OptionGroup = "theme";
			this.m_formTheme.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_aeroSilverTheme,
            this.m_aeroBlueTheme,
            this.m_officeBlueTheme,
            this.m_officeBlackTheme,
            this.m_officeSilverTheme,
            this.m_officeNavyTheme});
			this.m_formTheme.Text = "테마(&T)";
			// 
			// m_aeroSilverTheme
			// 
			this.m_aeroSilverTheme.Checked = true;
			this.m_aeroSilverTheme.Command = this.m_themeCommand;
			this.m_aeroSilverTheme.CommandParameter = "Office2010Silver";
			this.m_aeroSilverTheme.Name = "m_aeroSilverTheme";
			this.m_aeroSilverTheme.OptionGroup = "theme";
			this.m_aeroSilverTheme.Text = "Aero Silver";
			// 
			// m_themeCommand
			// 
			this.m_themeCommand.Executed += new System.EventHandler(this.OnExecutedThemeCommand);
			// 
			// m_aeroBlueTheme
			// 
			this.m_aeroBlueTheme.Command = this.m_themeCommand;
			this.m_aeroBlueTheme.CommandParameter = "Windows7Blue";
			this.m_aeroBlueTheme.Name = "m_aeroBlueTheme";
			this.m_aeroBlueTheme.OptionGroup = "theme";
			this.m_aeroBlueTheme.Text = "Aero Blue";
			// 
			// m_officeBlueTheme
			// 
			this.m_officeBlueTheme.Command = this.m_themeCommand;
			this.m_officeBlueTheme.CommandParameter = "Office2007Blue";
			this.m_officeBlueTheme.Name = "m_officeBlueTheme";
			this.m_officeBlueTheme.OptionGroup = "theme";
			this.m_officeBlueTheme.Text = "Office Blue";
			// 
			// m_officeBlackTheme
			// 
			this.m_officeBlackTheme.Command = this.m_themeCommand;
			this.m_officeBlackTheme.CommandParameter = "Office2007Black";
			this.m_officeBlackTheme.Name = "m_officeBlackTheme";
			this.m_officeBlackTheme.OptionGroup = "theme";
			this.m_officeBlackTheme.Text = "Office Black";
			// 
			// m_officeSilverTheme
			// 
			this.m_officeSilverTheme.Command = this.m_themeCommand;
			this.m_officeSilverTheme.CommandParameter = "Office2007Silver";
			this.m_officeSilverTheme.Name = "m_officeSilverTheme";
			this.m_officeSilverTheme.OptionGroup = "theme";
			this.m_officeSilverTheme.Text = "Office Silver";
			// 
			// m_officeNavyTheme
			// 
			this.m_officeNavyTheme.Command = this.m_themeCommand;
			this.m_officeNavyTheme.CommandParameter = "Office2007VistaGlass";
			this.m_officeNavyTheme.Name = "m_officeNavyTheme";
			this.m_officeNavyTheme.OptionGroup = "theme";
			this.m_officeNavyTheme.Text = "Office Navy";
			// 
			// m_helpGroup
			// 
			this.m_helpGroup.AutoExpandOnClick = true;
			this.m_helpGroup.Image = global::Easy2.Properties.Resources.Help;
			this.m_helpGroup.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.m_helpGroup.Name = "m_helpGroup";
			this.m_helpGroup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_helpDocument,
            this.m_updateCheck,
            this.m_showAbout});
			// 
			// m_helpDocument
			// 
			this.m_helpDocument.Image = global::Easy2.Properties.Resources.HelpDocument;
			this.m_helpDocument.Name = "m_helpDocument";
			this.m_helpDocument.Text = "도움말(&H)...";
			// 
			// m_updateCheck
			// 
			this.m_updateCheck.BeginGroup = true;
			this.m_updateCheck.Image = global::Easy2.Properties.Resources.UpdateCheck;
			this.m_updateCheck.Name = "m_updateCheck";
			this.m_updateCheck.Text = "업데이트 확인(&U)...";
			// 
			// m_showAbout
			// 
			this.m_showAbout.BeginGroup = true;
			this.m_showAbout.Name = "m_showAbout";
			this.m_showAbout.Text = "Easy to MySQL 정보(&A)...";
			// 
			// m_startButton
			// 
			this.m_startButton.AutoExpandOnClick = true;
			this.m_startButton.CanCustomize = false;
			this.m_startButton.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
			this.m_startButton.ImageFixedSize = new System.Drawing.Size(16, 16);
			this.m_startButton.ImagePaddingHorizontal = 0;
			this.m_startButton.ImagePaddingVertical = 0;
			this.m_startButton.Name = "m_startButton";
			this.m_startButton.ShowSubItems = false;
			this.m_startButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_fileItemContainer});
			this.m_startButton.Text = "&File";
			// 
			// m_fileItemContainer
			// 
			// 
			// 
			// 
			this.m_fileItemContainer.BackgroundStyle.Class = "RibbonFileMenuContainer";
			this.m_fileItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_fileItemContainer.Name = "m_fileItemContainer";
			this.m_fileItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_fileMenuItemContainer,
            this.m_botomItemContainer});
			// 
			// m_fileMenuItemContainer
			// 
			// 
			// 
			// 
			this.m_fileMenuItemContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
			this.m_fileMenuItemContainer.ItemSpacing = 0;
			this.m_fileMenuItemContainer.Name = "m_fileMenuItemContainer";
			this.m_fileMenuItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_leftItemContainer,
            this.m_rightItemContainer});
			// 
			// m_leftItemContainer
			// 
			// 
			// 
			// 
			this.m_leftItemContainer.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
			this.m_leftItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_leftItemContainer.MinimumSize = new System.Drawing.Size(120, 0);
			this.m_leftItemContainer.Name = "m_leftItemContainer";
			this.m_leftItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_newConnection,
            this.m_newConnectionUsingCurrentSettings,
            this.m_newQueryEditor,
            this.m_newQueryWizard,
            this.m_newSchemaDesigner,
            this.m_closeTab,
            this.m_disconnectMySql,
            this.m_disconnectAllMySql,
            this.m_openFileInSameTab,
            this.m_openFileInNewTab,
            this.m_saveFile,
            this.m_saveAs});
			// 
			// m_newConnection
			// 
			this.m_newConnection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_newConnection.Image = global::Easy2.Properties.Resources.ConnectDatabase;
			this.m_newConnection.Name = "m_newConnection";
			this.m_newConnection.SubItemsExpandWidth = 24;
			this.m_newConnection.Text = "새로운 연결(&C)...";
			this.m_newConnection.Click += new System.EventHandler(this.m_newConnection_Click);
			// 
			// m_newConnectionUsingCurrentSettings
			// 
			this.m_newConnectionUsingCurrentSettings.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_newConnectionUsingCurrentSettings.Image = ((System.Drawing.Image)(resources.GetObject("m_newConnectionUsingCurrentSettings.Image")));
			this.m_newConnectionUsingCurrentSettings.Name = "m_newConnectionUsingCurrentSettings";
			this.m_newConnectionUsingCurrentSettings.SubItemsExpandWidth = 24;
			this.m_newConnectionUsingCurrentSettings.Text = "기존 설정 연결(&N)";
			// 
			// m_newQueryEditor
			// 
			this.m_newQueryEditor.BeginGroup = true;
			this.m_newQueryEditor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_newQueryEditor.Image = global::Easy2.Properties.Resources.QueryEditor;
			this.m_newQueryEditor.Name = "m_newQueryEditor";
			this.m_newQueryEditor.SubItemsExpandWidth = 24;
			this.m_newQueryEditor.Text = "새 쿼리 에디터(&Q)";
			this.m_newQueryEditor.Click += new System.EventHandler(this.m_newQueryEditor_Click);
			// 
			// m_newQueryWizard
			// 
			this.m_newQueryWizard.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_newQueryWizard.Image = global::Easy2.Properties.Resources.QueryWizard;
			this.m_newQueryWizard.Name = "m_newQueryWizard";
			this.m_newQueryWizard.SubItemsExpandWidth = 24;
			this.m_newQueryWizard.Text = "새 쿼리 마법사(&W)";
			// 
			// m_newSchemaDesigner
			// 
			this.m_newSchemaDesigner.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_newSchemaDesigner.Image = global::Easy2.Properties.Resources.SchemaDesigner;
			this.m_newSchemaDesigner.Name = "m_newSchemaDesigner";
			this.m_newSchemaDesigner.SubItemsExpandWidth = 24;
			this.m_newSchemaDesigner.Text = "새 스키마 디자이너(&H)";
			// 
			// m_closeTab
			// 
			this.m_closeTab.BeginGroup = true;
			this.m_closeTab.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_closeTab.Image = global::Easy2.Properties.Resources.CloseTab;
			this.m_closeTab.Name = "m_closeTab";
			this.m_closeTab.SubItemsExpandWidth = 24;
			this.m_closeTab.Text = "댑 닫기(&T)";
			// 
			// m_disconnectMySql
			// 
			this.m_disconnectMySql.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_disconnectMySql.Image = global::Easy2.Properties.Resources.Disconnect;
			this.m_disconnectMySql.Name = "m_disconnectMySql";
			this.m_disconnectMySql.Text = "연결종료(&D)";
			// 
			// m_disconnectAllMySql
			// 
			this.m_disconnectAllMySql.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_disconnectAllMySql.Image = global::Easy2.Properties.Resources.DisconnectAll;
			this.m_disconnectAllMySql.Name = "m_disconnectAllMySql";
			this.m_disconnectAllMySql.Text = "모든 연결종료(&L)";
			// 
			// m_openFileInSameTab
			// 
			this.m_openFileInSameTab.BeginGroup = true;
			this.m_openFileInSameTab.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_openFileInSameTab.Image = global::Easy2.Properties.Resources.OpenFile;
			this.m_openFileInSameTab.Name = "m_openFileInSameTab";
			this.m_openFileInSameTab.Text = "불러오기(&O)...";
			// 
			// m_openFileInNewTab
			// 
			this.m_openFileInNewTab.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_openFileInNewTab.Image = global::Easy2.Properties.Resources.OpenFileNewTab;
			this.m_openFileInNewTab.Name = "m_openFileInNewTab";
			this.m_openFileInNewTab.Text = "새 탭에 불러오기(&F)...";
			// 
			// m_saveFile
			// 
			this.m_saveFile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_saveFile.Image = global::Easy2.Properties.Resources.SaveFile;
			this.m_saveFile.Name = "m_saveFile";
			this.m_saveFile.Text = "저장하기(&S)...";
			// 
			// m_saveAs
			// 
			this.m_saveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_saveAs.Image = global::Easy2.Properties.Resources.SaveAsFile;
			this.m_saveAs.Name = "m_saveAs";
			this.m_saveAs.Text = "다른 이름으로 저장하기(&A)...";
			// 
			// m_rightItemContainer
			// 
			// 
			// 
			// 
			this.m_rightItemContainer.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
			this.m_rightItemContainer.EnableGalleryPopup = false;
			this.m_rightItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.m_rightItemContainer.MinimumSize = new System.Drawing.Size(180, 240);
			this.m_rightItemContainer.MultiLine = false;
			this.m_rightItemContainer.Name = "m_rightItemContainer";
			this.m_rightItemContainer.PopupUsesStandardScrollbars = false;
			this.m_rightItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_recentLabel});
			// 
			// m_recentLabel
			// 
			this.m_recentLabel.Name = "m_recentLabel";
			this.m_recentLabel.Text = "최근 사용한 파일";
			// 
			// m_botomItemContainer
			// 
			// 
			// 
			// 
			this.m_botomItemContainer.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
			this.m_botomItemContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
			this.m_botomItemContainer.Name = "m_botomItemContainer";
			this.m_botomItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_quitApplication});
			// 
			// m_quitApplication
			// 
			this.m_quitApplication.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.m_quitApplication.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_quitApplication.Image = global::Easy2.Properties.Resources.QuitApplication;
			this.m_quitApplication.Name = "m_quitApplication";
			this.m_quitApplication.SubItemsExpandWidth = 24;
			this.m_quitApplication.Text = "종료하기(&X)";
			// 
			// m_styleManager
			// 
			this.m_styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
			// 
			// m_statusBar
			// 
			this.m_statusBar.AccessibleDescription = "DotNetBar Bar (m_statusBar)";
			this.m_statusBar.AccessibleName = "DotNetBar Bar";
			this.m_statusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.m_statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_statusBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
			this.m_statusBar.Location = new System.Drawing.Point(4, 605);
			this.m_statusBar.Name = "m_statusBar";
			this.m_statusBar.Size = new System.Drawing.Size(1106, 25);
			this.m_statusBar.Stretch = true;
			this.m_statusBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_statusBar.TabIndex = 1;
			this.m_statusBar.TabStop = false;
			this.m_statusBar.Text = "statusBar";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 632);
			this.Controls.Add(this.m_statusBar);
			this.Controls.Add(this.m_ribbonControl);
			this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "Easy To MySQL";
			this.m_ribbonControl.ResumeLayout(false);
			this.m_ribbonControl.PerformLayout();
			this.m_homePanel.ResumeLayout(false);
			this.m_toolPanel.ResumeLayout(false);
			this.m_createPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_statusBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.RibbonControl m_ribbonControl;
		private DevComponents.DotNetBar.RibbonPanel m_homePanel;
		private DevComponents.DotNetBar.RibbonBar m_refreshBar;
		private DevComponents.DotNetBar.RibbonPanel m_createPanel;
		private DevComponents.DotNetBar.RibbonTabItem m_homeTab;
		private DevComponents.DotNetBar.RibbonTabItem m_createTab;
		private DevComponents.DotNetBar.Office2007StartButton m_startButton;
		private DevComponents.DotNetBar.ItemContainer m_fileItemContainer;
		private DevComponents.DotNetBar.ItemContainer m_fileMenuItemContainer;
		private DevComponents.DotNetBar.ItemContainer m_leftItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_newConnection;
		private DevComponents.DotNetBar.ButtonItem m_newConnectionUsingCurrentSettings;
		private DevComponents.DotNetBar.ButtonItem m_newQueryEditor;
		private DevComponents.DotNetBar.ButtonItem m_newQueryWizard;
		private DevComponents.DotNetBar.ButtonItem m_newSchemaDesigner;
		private DevComponents.DotNetBar.ButtonItem m_closeTab;
		private DevComponents.DotNetBar.ButtonItem m_disconnectMySql;
		private DevComponents.DotNetBar.GalleryContainer m_rightItemContainer;
		private DevComponents.DotNetBar.ItemContainer m_botomItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_quitApplication;
		private DevComponents.DotNetBar.StyleManager m_styleManager;
		private DevComponents.DotNetBar.ButtonItem m_disconnectAllMySql;
		private DevComponents.DotNetBar.ButtonItem m_openFileInSameTab;
		private DevComponents.DotNetBar.ButtonItem m_openFileInNewTab;
		private DevComponents.DotNetBar.ButtonItem m_saveFile;
		private DevComponents.DotNetBar.ButtonItem m_saveAs;
		private DevComponents.DotNetBar.RibbonBar m_clipboardBar;
		private DevComponents.DotNetBar.ButtonItem m_pasteToClipboard;
		private DevComponents.DotNetBar.ButtonItem m_refreshObjectBrowser;
		private DevComponents.DotNetBar.ItemContainer m_clipboardItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_cutSelection;
		private DevComponents.DotNetBar.ButtonItem m_copySelection;
		private DevComponents.DotNetBar.LabelItem m_recentLabel;
		private DevComponents.DotNetBar.RibbonBar m_editBar;
		private DevComponents.DotNetBar.ButtonItem m_findData;
		private DevComponents.DotNetBar.ItemContainer m_editItemContainer1;
		private DevComponents.DotNetBar.ItemContainer m_editItemContainer2;
		private DevComponents.DotNetBar.ButtonItem m_findNextData;
		private DevComponents.DotNetBar.ButtonItem m_replaceData;
		private DevComponents.DotNetBar.ButtonItem m_goToLine;
		private DevComponents.DotNetBar.ButtonItem m_selectAll;
		private DevComponents.DotNetBar.ButtonItem m_cancelSelection;
		private DevComponents.DotNetBar.ButtonItem m_clearSelection;
		private DevComponents.DotNetBar.ItemContainer m_editItemContainer3;
		private DevComponents.DotNetBar.ButtonItem m_undoAction;
		private DevComponents.DotNetBar.ButtonItem m_redoAction;
		private DevComponents.DotNetBar.RibbonBar m_executeBar;
		private DevComponents.DotNetBar.ButtonItem m_executeQuery;
		private DevComponents.DotNetBar.ButtonItem m_executeSelectQuery;
		private DevComponents.DotNetBar.ButtonItem m_execyteAllQuery;
		private DevComponents.DotNetBar.RibbonBar m_tabBar;
		private DevComponents.DotNetBar.ButtonItem m_switchPreviousTab;
		private DevComponents.DotNetBar.ButtonItem m_switchNextTab;
		private DevComponents.DotNetBar.RibbonBar m_userBar;
		private DevComponents.DotNetBar.ButtonItem m_addUser;
		private DevComponents.DotNetBar.ButtonItem m_alterUser;
		private DevComponents.DotNetBar.ButtonItem m_privilegeUser;
		private DevComponents.DotNetBar.RibbonBar m_databaseBar;
		private DevComponents.DotNetBar.ButtonItem m_createDatabase;
		private DevComponents.DotNetBar.ItemContainer m_databaseItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_alterDatabase;
		private DevComponents.DotNetBar.ButtonItem m_truncateDatabase;
		private DevComponents.DotNetBar.ButtonItem m_dropDatabase;
		private DevComponents.DotNetBar.RibbonBar m_tableBar;
		private DevComponents.DotNetBar.ButtonItem m_createTable;
		private DevComponents.DotNetBar.ItemContainer m_tableItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_alterTable;
		private DevComponents.DotNetBar.ButtonItem m_truncateTable;
		private DevComponents.DotNetBar.ButtonItem m_dropTable;
		private DevComponents.DotNetBar.RibbonBar m_objectBar;
		private DevComponents.DotNetBar.ButtonItem m_dropColumn;
		private DevComponents.DotNetBar.ButtonItem m_createIndex;
		private DevComponents.DotNetBar.ButtonItem m_createView;
		private DevComponents.DotNetBar.ButtonItem m_createStoredProc;
		private DevComponents.DotNetBar.ButtonItem m_createFunction;
		private DevComponents.DotNetBar.ButtonItem m_createTrigger;
		private DevComponents.DotNetBar.ButtonItem m_createEvent;
		private DevComponents.DotNetBar.ItemContainer m_indexItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_dropIndex;
		private DevComponents.DotNetBar.ButtonItem m_alterIndex;
		private DevComponents.DotNetBar.ItemContainer m_viewItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_alterView;
		private DevComponents.DotNetBar.ButtonItem m_dropView;
		private DevComponents.DotNetBar.ItemContainer m_storedProcItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_alterStoredProc;
		private DevComponents.DotNetBar.ButtonItem m_dropStoredProc;
		private DevComponents.DotNetBar.ItemContainer m_functionitemContainer;
		private DevComponents.DotNetBar.ButtonItem m_alterFunction;
		private DevComponents.DotNetBar.ButtonItem m_dropFunction;
		private DevComponents.DotNetBar.ItemContainer m_triggerItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_alterTrigger;
		private DevComponents.DotNetBar.ButtonItem m_dropTrigger;
		private DevComponents.DotNetBar.ItemContainer m_eventItemContainer;
		private DevComponents.DotNetBar.ButtonItem m_alterEvent;
		private DevComponents.DotNetBar.ButtonItem m_dropEvent;
		private DevComponents.DotNetBar.RibbonPanel m_toolPanel;
		private DevComponents.DotNetBar.RibbonBar m_openBar;
		private DevComponents.DotNetBar.RibbonTabItem m_toolTab;
		private DevComponents.DotNetBar.ButtonItem m_openObject;
		private DevComponents.DotNetBar.RibbonBar m_externalBar;
		private DevComponents.DotNetBar.RibbonBar m_bakupBar;
		private DevComponents.DotNetBar.ButtonItem m_backupDatabase;
		private DevComponents.DotNetBar.ButtonItem m_restoreDatabase;
		private DevComponents.DotNetBar.ButtonItem m_importExternal;
		private DevComponents.DotNetBar.ButtonItem m_exportExternal;
		private DevComponents.DotNetBar.Bar m_statusBar;
		private DevComponents.DotNetBar.ButtonItem m_helpGroup;
		private DevComponents.DotNetBar.ButtonItem m_helpDocument;
		private DevComponents.DotNetBar.ButtonItem m_updateCheck;
		private DevComponents.DotNetBar.ButtonItem m_showAbout;
		private DevComponents.DotNetBar.ButtonItem m_configGroup;
		private DevComponents.DotNetBar.ButtonItem m_appSettings;
		private DevComponents.DotNetBar.ButtonItem m_formTheme;
		private DevComponents.DotNetBar.ButtonItem m_aeroSilverTheme;
		private DevComponents.DotNetBar.ButtonItem m_aeroBlueTheme;
		private DevComponents.DotNetBar.ButtonItem m_officeBlueTheme;
		private DevComponents.DotNetBar.ButtonItem m_officeBlackTheme;
		private DevComponents.DotNetBar.ButtonItem m_officeSilverTheme;
		private DevComponents.DotNetBar.ButtonItem m_officeNavyTheme;
		private DevComponents.DotNetBar.Command m_themeCommand;
	}
}