namespace Easy2
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
			this.homePanel = new DevComponents.DotNetBar.RibbonPanel();
			this.paneBar = new DevComponents.DotNetBar.RibbonBar();
			this.paneItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.objectBrowserPane = new DevComponents.DotNetBar.CheckBoxItem();
			this.queryEditPane = new DevComponents.DotNetBar.CheckBoxItem();
			this.resultPane = new DevComponents.DotNetBar.CheckBoxItem();
			this.tabBar = new DevComponents.DotNetBar.RibbonBar();
			this.switchPreviousTab = new DevComponents.DotNetBar.ButtonItem();
			this.switchNextTab = new DevComponents.DotNetBar.ButtonItem();
			this.executeBar = new DevComponents.DotNetBar.RibbonBar();
			this.executeQuery = new DevComponents.DotNetBar.ButtonItem();
			this.executeSelectQuery = new DevComponents.DotNetBar.ButtonItem();
			this.execyteAllQuery = new DevComponents.DotNetBar.ButtonItem();
			this.editBar = new DevComponents.DotNetBar.RibbonBar();
			this.findData = new DevComponents.DotNetBar.ButtonItem();
			this.editItemContainer1 = new DevComponents.DotNetBar.ItemContainer();
			this.findNextData = new DevComponents.DotNetBar.ButtonItem();
			this.replaceData = new DevComponents.DotNetBar.ButtonItem();
			this.goToLine = new DevComponents.DotNetBar.ButtonItem();
			this.editItemContainer2 = new DevComponents.DotNetBar.ItemContainer();
			this.selectAll = new DevComponents.DotNetBar.ButtonItem();
			this.cancelSelection = new DevComponents.DotNetBar.ButtonItem();
			this.clearSelection = new DevComponents.DotNetBar.ButtonItem();
			this.editItemContainer3 = new DevComponents.DotNetBar.ItemContainer();
			this.undoAction = new DevComponents.DotNetBar.ButtonItem();
			this.redoAction = new DevComponents.DotNetBar.ButtonItem();
			this.clipboardBar = new DevComponents.DotNetBar.RibbonBar();
			this.pasteToClipboard = new DevComponents.DotNetBar.ButtonItem();
			this.clipboardItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.cutSelection = new DevComponents.DotNetBar.ButtonItem();
			this.copySelection = new DevComponents.DotNetBar.ButtonItem();
			this.refreshBar = new DevComponents.DotNetBar.RibbonBar();
			this.refreshObjectBrowser = new DevComponents.DotNetBar.ButtonItem();
			this.createPanel = new DevComponents.DotNetBar.RibbonPanel();
			this.objectBar = new DevComponents.DotNetBar.RibbonBar();
			this.dropColumn = new DevComponents.DotNetBar.ButtonItem();
			this.createIndex = new DevComponents.DotNetBar.ButtonItem();
			this.indexItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterIndex = new DevComponents.DotNetBar.ButtonItem();
			this.dropIndex = new DevComponents.DotNetBar.ButtonItem();
			this.createView = new DevComponents.DotNetBar.ButtonItem();
			this.viewItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterView = new DevComponents.DotNetBar.ButtonItem();
			this.dropView = new DevComponents.DotNetBar.ButtonItem();
			this.createStoredProc = new DevComponents.DotNetBar.ButtonItem();
			this.storedProcItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterStoredProc = new DevComponents.DotNetBar.ButtonItem();
			this.dropStoredProc = new DevComponents.DotNetBar.ButtonItem();
			this.createFunction = new DevComponents.DotNetBar.ButtonItem();
			this.functionitemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterFunction = new DevComponents.DotNetBar.ButtonItem();
			this.dropFunction = new DevComponents.DotNetBar.ButtonItem();
			this.createTrigger = new DevComponents.DotNetBar.ButtonItem();
			this.triggerItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterTrigger = new DevComponents.DotNetBar.ButtonItem();
			this.dropTrigger = new DevComponents.DotNetBar.ButtonItem();
			this.createEvent = new DevComponents.DotNetBar.ButtonItem();
			this.eventItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterEvent = new DevComponents.DotNetBar.ButtonItem();
			this.dropEvent = new DevComponents.DotNetBar.ButtonItem();
			this.tableBar = new DevComponents.DotNetBar.RibbonBar();
			this.createTable = new DevComponents.DotNetBar.ButtonItem();
			this.tableItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterTable = new DevComponents.DotNetBar.ButtonItem();
			this.truncateTable = new DevComponents.DotNetBar.ButtonItem();
			this.dropTable = new DevComponents.DotNetBar.ButtonItem();
			this.databaseBar = new DevComponents.DotNetBar.RibbonBar();
			this.createDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.databaseItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.alterDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.truncateDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.dropDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.userBar = new DevComponents.DotNetBar.RibbonBar();
			this.addUser = new DevComponents.DotNetBar.ButtonItem();
			this.alterUser = new DevComponents.DotNetBar.ButtonItem();
			this.privilegeUser = new DevComponents.DotNetBar.ButtonItem();
			this.toolPanel = new DevComponents.DotNetBar.RibbonPanel();
			this.externalBar = new DevComponents.DotNetBar.RibbonBar();
			this.importExternal = new DevComponents.DotNetBar.ButtonItem();
			this.exportExternal = new DevComponents.DotNetBar.ButtonItem();
			this.bakupBar = new DevComponents.DotNetBar.RibbonBar();
			this.backupDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.restoreDatabase = new DevComponents.DotNetBar.ButtonItem();
			this.openBar = new DevComponents.DotNetBar.RibbonBar();
			this.openObject = new DevComponents.DotNetBar.ButtonItem();
			this.startButton = new DevComponents.DotNetBar.Office2007StartButton();
			this.fileItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.fileMenuItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.leftItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.newConnection = new DevComponents.DotNetBar.ButtonItem();
			this.newConnectionUsingCurrentSettings = new DevComponents.DotNetBar.ButtonItem();
			this.newQueryEditor = new DevComponents.DotNetBar.ButtonItem();
			this.newQueryWizard = new DevComponents.DotNetBar.ButtonItem();
			this.newSchemaDesigner = new DevComponents.DotNetBar.ButtonItem();
			this.closeTab = new DevComponents.DotNetBar.ButtonItem();
			this.disconnectMySql = new DevComponents.DotNetBar.ButtonItem();
			this.disconnectAllMySql = new DevComponents.DotNetBar.ButtonItem();
			this.openFileInSameTab = new DevComponents.DotNetBar.ButtonItem();
			this.openFileInNewTab = new DevComponents.DotNetBar.ButtonItem();
			this.saveFile = new DevComponents.DotNetBar.ButtonItem();
			this.saveAs = new DevComponents.DotNetBar.ButtonItem();
			this.rightItemContainer = new DevComponents.DotNetBar.GalleryContainer();
			this.recentLabel = new DevComponents.DotNetBar.LabelItem();
			this.botomItemContainer = new DevComponents.DotNetBar.ItemContainer();
			this.quitApplication = new DevComponents.DotNetBar.ButtonItem();
			this.homeTab = new DevComponents.DotNetBar.RibbonTabItem();
			this.createTab = new DevComponents.DotNetBar.RibbonTabItem();
			this.toolTab = new DevComponents.DotNetBar.RibbonTabItem();
			this.configGroup = new DevComponents.DotNetBar.ButtonItem();
			this.appSettings = new DevComponents.DotNetBar.ButtonItem();
			this.formTheme = new DevComponents.DotNetBar.ButtonItem();
			this.aeroSilver = new DevComponents.DotNetBar.ButtonItem();
			this.AppCommandTheme = new DevComponents.DotNetBar.Command();
			this.aeroBlue = new DevComponents.DotNetBar.ButtonItem();
			this.officeBlue = new DevComponents.DotNetBar.ButtonItem();
			this.officeBlack = new DevComponents.DotNetBar.ButtonItem();
			this.officeSilver = new DevComponents.DotNetBar.ButtonItem();
			this.officeNavy = new DevComponents.DotNetBar.ButtonItem();
			this.customColor = new DevComponents.DotNetBar.ColorPickerDropDown();
			this.helpGroup = new DevComponents.DotNetBar.ButtonItem();
			this.helpDocument = new DevComponents.DotNetBar.ButtonItem();
			this.updateCheck = new DevComponents.DotNetBar.ButtonItem();
			this.showAbout = new DevComponents.DotNetBar.ButtonItem();
			this.qatButton = new DevComponents.DotNetBar.ButtonItem();
			this.qatCustomizeItem = new DevComponents.DotNetBar.QatCustomizeItem();
			this.styleManager = new DevComponents.DotNetBar.StyleManager();
			this.statusBar = new DevComponents.DotNetBar.Bar();
			this.ribbonControl.SuspendLayout();
			this.homePanel.SuspendLayout();
			this.createPanel.SuspendLayout();
			this.toolPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBar)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			// 
			// 
			// 
			this.ribbonControl.BackgroundStyle.Class = "";
			this.ribbonControl.CaptionVisible = true;
			this.ribbonControl.Controls.Add(this.homePanel);
			this.ribbonControl.Controls.Add(this.toolPanel);
			this.ribbonControl.Controls.Add(this.createPanel);
			this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.startButton,
            this.homeTab,
            this.createTab,
            this.toolTab,
            this.configGroup,
            this.helpGroup});
			this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
			this.ribbonControl.Location = new System.Drawing.Point(4, 1);
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.ribbonControl.Size = new System.Drawing.Size(1106, 180);
			this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonControl.TabGroupHeight = 14;
			this.ribbonControl.TabIndex = 0;
			this.ribbonControl.Text = "ribbonControl1";
			// 
			// homePanel
			// 
			this.homePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.homePanel.Controls.Add(this.paneBar);
			this.homePanel.Controls.Add(this.tabBar);
			this.homePanel.Controls.Add(this.executeBar);
			this.homePanel.Controls.Add(this.editBar);
			this.homePanel.Controls.Add(this.clipboardBar);
			this.homePanel.Controls.Add(this.refreshBar);
			this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.homePanel.Location = new System.Drawing.Point(0, 56);
			this.homePanel.Name = "homePanel";
			this.homePanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.homePanel.Size = new System.Drawing.Size(1106, 122);
			// 
			// 
			// 
			this.homePanel.Style.Class = "";
			// 
			// 
			// 
			this.homePanel.StyleMouseDown.Class = "";
			// 
			// 
			// 
			this.homePanel.StyleMouseOver.Class = "";
			this.homePanel.TabIndex = 1;
			// 
			// paneBar
			// 
			this.paneBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.paneBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.paneBar.BackgroundStyle.Class = "";
			this.paneBar.ContainerControlProcessDialogKey = true;
			this.paneBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.paneBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.paneItemContainer});
			this.paneBar.Location = new System.Drawing.Point(867, 0);
			this.paneBar.Name = "paneBar";
			this.paneBar.Size = new System.Drawing.Size(144, 119);
			this.paneBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.paneBar.TabIndex = 5;
			this.paneBar.Text = "창";
			// 
			// 
			// 
			this.paneBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.paneBar.TitleStyleMouseOver.Class = "";
			// 
			// paneItemContainer
			// 
			// 
			// 
			// 
			this.paneItemContainer.BackgroundStyle.Class = "";
			this.paneItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.paneItemContainer.Name = "paneItemContainer";
			this.paneItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.objectBrowserPane,
            this.queryEditPane,
            this.resultPane});
			this.paneItemContainer.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// objectBrowserPane
			// 
			this.objectBrowserPane.KeyTips = "HO";
			this.objectBrowserPane.Name = "objectBrowserPane";
			this.objectBrowserPane.Text = "오브젝트 브라우저";
			// 
			// queryEditPane
			// 
			this.queryEditPane.KeyTips = "HQ";
			this.queryEditPane.Name = "queryEditPane";
			this.queryEditPane.Text = "질의 편집기";
			// 
			// resultPane
			// 
			this.resultPane.KeyTips = "HR";
			this.resultPane.Name = "resultPane";
			this.resultPane.Text = "결과 창";
			// 
			// tabBar
			// 
			this.tabBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.tabBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.tabBar.BackgroundStyle.Class = "";
			this.tabBar.ContainerControlProcessDialogKey = true;
			this.tabBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.switchPreviousTab,
            this.switchNextTab});
			this.tabBar.Location = new System.Drawing.Point(743, 0);
			this.tabBar.Name = "tabBar";
			this.tabBar.Size = new System.Drawing.Size(124, 119);
			this.tabBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tabBar.TabIndex = 4;
			this.tabBar.Text = "탭";
			// 
			// 
			// 
			this.tabBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.tabBar.TitleStyleMouseOver.Class = "";
			// 
			// switchPreviousTab
			// 
			this.switchPreviousTab.Image = global::Easy2.Properties.Resources.SwitchPreviousTab;
			this.switchPreviousTab.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.switchPreviousTab.KeyTips = "TP";
			this.switchPreviousTab.Name = "switchPreviousTab";
			this.switchPreviousTab.SubItemsExpandWidth = 14;
			this.switchPreviousTab.Text = "이전 탭";
			// 
			// switchNextTab
			// 
			this.switchNextTab.Image = global::Easy2.Properties.Resources.SwitchNextTab;
			this.switchNextTab.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.switchNextTab.KeyTips = "TN";
			this.switchNextTab.Name = "switchNextTab";
			this.switchNextTab.SubItemsExpandWidth = 14;
			this.switchNextTab.Text = "다음 탭";
			// 
			// executeBar
			// 
			this.executeBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.executeBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.executeBar.BackgroundStyle.Class = "";
			this.executeBar.ContainerControlProcessDialogKey = true;
			this.executeBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.executeBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.executeQuery,
            this.executeSelectQuery,
            this.execyteAllQuery});
			this.executeBar.Location = new System.Drawing.Point(548, 0);
			this.executeBar.Name = "executeBar";
			this.executeBar.Size = new System.Drawing.Size(195, 119);
			this.executeBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.executeBar.TabIndex = 3;
			this.executeBar.Text = "실행";
			// 
			// 
			// 
			this.executeBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.executeBar.TitleStyleMouseOver.Class = "";
			// 
			// executeQuery
			// 
			this.executeQuery.Image = global::Easy2.Properties.Resources.ExecuteQuery;
			this.executeQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.executeQuery.KeyTips = "QE";
			this.executeQuery.Name = "executeQuery";
			this.executeQuery.SubItemsExpandWidth = 14;
			this.executeQuery.Text = "쿼리실행";
			// 
			// executeSelectQuery
			// 
			this.executeSelectQuery.Image = global::Easy2.Properties.Resources.ExecuteSelectQuery;
			this.executeSelectQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.executeSelectQuery.KeyTips = "QS";
			this.executeSelectQuery.Name = "executeSelectQuery";
			this.executeSelectQuery.SubItemsExpandWidth = 14;
			this.executeSelectQuery.Text = "<div align=\"center\">선택된<br/>쿼리실행</div>";
			// 
			// execyteAllQuery
			// 
			this.execyteAllQuery.Image = global::Easy2.Properties.Resources.ExecuteAllQuery;
			this.execyteAllQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.execyteAllQuery.KeyTips = "QA";
			this.execyteAllQuery.Name = "execyteAllQuery";
			this.execyteAllQuery.SubItemsExpandWidth = 14;
			this.execyteAllQuery.Text = "<div align=\"center\">모든<br/>쿼리실행</div>\r\n";
			// 
			// editBar
			// 
			this.editBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.editBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.editBar.BackgroundStyle.Class = "";
			this.editBar.ContainerControlProcessDialogKey = true;
			this.editBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.editBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.findData,
            this.editItemContainer1,
            this.editItemContainer2,
            this.editItemContainer3});
			this.editBar.Location = new System.Drawing.Point(233, 0);
			this.editBar.Name = "editBar";
			this.editBar.Size = new System.Drawing.Size(315, 119);
			this.editBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.editBar.TabIndex = 2;
			this.editBar.Text = "편집";
			// 
			// 
			// 
			this.editBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.editBar.TitleStyleMouseOver.Class = "";
			// 
			// findData
			// 
			this.findData.Image = global::Easy2.Properties.Resources.FindData;
			this.findData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.findData.KeyTips = "F";
			this.findData.Name = "findData";
			this.findData.SubItemsExpandWidth = 14;
			this.findData.Text = "찾기";
			// 
			// editItemContainer1
			// 
			// 
			// 
			// 
			this.editItemContainer1.BackgroundStyle.Class = "";
			this.editItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.editItemContainer1.Name = "editItemContainer1";
			this.editItemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.findNextData,
            this.replaceData,
            this.goToLine});
			this.editItemContainer1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// findNextData
			// 
			this.findNextData.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.findNextData.Image = global::Easy2.Properties.Resources.FindNextData;
			this.findNextData.KeyTips = "N";
			this.findNextData.Name = "findNextData";
			this.findNextData.Text = "다음찾기";
			// 
			// replaceData
			// 
			this.replaceData.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.replaceData.Image = global::Easy2.Properties.Resources.ReplaceData;
			this.replaceData.KeyTips = "E";
			this.replaceData.Name = "replaceData";
			this.replaceData.Text = "바꾸기";
			// 
			// goToLine
			// 
			this.goToLine.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.goToLine.Image = global::Easy2.Properties.Resources.GoToLine;
			this.goToLine.KeyTips = "G";
			this.goToLine.Name = "goToLine";
			this.goToLine.Text = "바로가기";
			// 
			// editItemContainer2
			// 
			// 
			// 
			// 
			this.editItemContainer2.BackgroundStyle.Class = "";
			this.editItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.editItemContainer2.Name = "editItemContainer2";
			this.editItemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.selectAll,
            this.cancelSelection,
            this.clearSelection});
			this.editItemContainer2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// selectAll
			// 
			this.selectAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.selectAll.Image = global::Easy2.Properties.Resources.SelectAll;
			this.selectAll.KeyTips = "A";
			this.selectAll.Name = "selectAll";
			this.selectAll.Text = "모두선택";
			// 
			// cancelSelection
			// 
			this.cancelSelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.cancelSelection.Image = global::Easy2.Properties.Resources.CancelSelection;
			this.cancelSelection.KeyTips = "X";
			this.cancelSelection.Name = "cancelSelection";
			this.cancelSelection.Text = "선택취소";
			// 
			// clearSelection
			// 
			this.clearSelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.clearSelection.Image = global::Easy2.Properties.Resources.DeleteSelection;
			this.clearSelection.KeyTips = "L";
			this.clearSelection.Name = "clearSelection";
			this.clearSelection.Text = "지우기";
			// 
			// editItemContainer3
			// 
			// 
			// 
			// 
			this.editItemContainer3.BackgroundStyle.Class = "";
			this.editItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.editItemContainer3.Name = "editItemContainer3";
			this.editItemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.undoAction,
            this.redoAction});
			this.editItemContainer3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// undoAction
			// 
			this.undoAction.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.undoAction.Image = global::Easy2.Properties.Resources.UndoAction;
			this.undoAction.KeyTips = "U";
			this.undoAction.Name = "undoAction";
			this.undoAction.Text = "실행취소";
			// 
			// redoAction
			// 
			this.redoAction.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.redoAction.Image = global::Easy2.Properties.Resources.RedoAction;
			this.redoAction.KeyTips = "O";
			this.redoAction.Name = "redoAction";
			this.redoAction.Text = "다시실행";
			// 
			// clipboardBar
			// 
			this.clipboardBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.clipboardBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.clipboardBar.BackgroundStyle.Class = "";
			this.clipboardBar.ContainerControlProcessDialogKey = true;
			this.clipboardBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.clipboardBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.pasteToClipboard,
            this.clipboardItemContainer});
			this.clipboardBar.Location = new System.Drawing.Point(76, 0);
			this.clipboardBar.Name = "clipboardBar";
			this.clipboardBar.Size = new System.Drawing.Size(157, 119);
			this.clipboardBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.clipboardBar.TabIndex = 1;
			this.clipboardBar.Text = "클립보드";
			// 
			// 
			// 
			this.clipboardBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.clipboardBar.TitleStyleMouseOver.Class = "";
			// 
			// pasteToClipboard
			// 
			this.pasteToClipboard.Image = global::Easy2.Properties.Resources.PasteToClipboard;
			this.pasteToClipboard.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.pasteToClipboard.KeyTips = "P";
			this.pasteToClipboard.Name = "pasteToClipboard";
			this.pasteToClipboard.SubItemsExpandWidth = 14;
			this.pasteToClipboard.Text = "붙여넣기";
			// 
			// clipboardItemContainer
			// 
			// 
			// 
			// 
			this.clipboardItemContainer.BackgroundStyle.Class = "";
			this.clipboardItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.clipboardItemContainer.Name = "clipboardItemContainer";
			this.clipboardItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cutSelection,
            this.copySelection});
			this.clipboardItemContainer.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// cutSelection
			// 
			this.cutSelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.cutSelection.Image = global::Easy2.Properties.Resources.CutSelection;
			this.cutSelection.KeyTips = "T";
			this.cutSelection.Name = "cutSelection";
			this.cutSelection.Text = "잘라내기";
			// 
			// copySelection
			// 
			this.copySelection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.copySelection.Image = global::Easy2.Properties.Resources.CopySelection;
			this.copySelection.KeyTips = "C";
			this.copySelection.Name = "copySelection";
			this.copySelection.Text = "복사하기";
			// 
			// refreshBar
			// 
			this.refreshBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.refreshBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.refreshBar.BackgroundStyle.Class = "";
			this.refreshBar.ContainerControlProcessDialogKey = true;
			this.refreshBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.refreshBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.refreshObjectBrowser});
			this.refreshBar.Location = new System.Drawing.Point(3, 0);
			this.refreshBar.Name = "refreshBar";
			this.refreshBar.Size = new System.Drawing.Size(73, 119);
			this.refreshBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.refreshBar.TabIndex = 0;
			this.refreshBar.Text = "새로고침";
			// 
			// 
			// 
			this.refreshBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.refreshBar.TitleStyleMouseOver.Class = "";
			// 
			// refreshObjectBrowser
			// 
			this.refreshObjectBrowser.Image = global::Easy2.Properties.Resources.RefreshObjectBrowser;
			this.refreshObjectBrowser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.refreshObjectBrowser.KeyTips = "R";
			this.refreshObjectBrowser.Name = "refreshObjectBrowser";
			this.refreshObjectBrowser.SubItemsExpandWidth = 14;
			this.refreshObjectBrowser.Text = "새로고침";
			// 
			// createPanel
			// 
			this.createPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.createPanel.Controls.Add(this.objectBar);
			this.createPanel.Controls.Add(this.tableBar);
			this.createPanel.Controls.Add(this.databaseBar);
			this.createPanel.Controls.Add(this.userBar);
			this.createPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.createPanel.Location = new System.Drawing.Point(0, 56);
			this.createPanel.Name = "createPanel";
			this.createPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.createPanel.Size = new System.Drawing.Size(1106, 122);
			// 
			// 
			// 
			this.createPanel.Style.Class = "";
			// 
			// 
			// 
			this.createPanel.StyleMouseDown.Class = "";
			// 
			// 
			// 
			this.createPanel.StyleMouseOver.Class = "";
			this.createPanel.TabIndex = 2;
			this.createPanel.Visible = false;
			// 
			// objectBar
			// 
			this.objectBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.objectBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.objectBar.BackgroundStyle.Class = "";
			this.objectBar.ContainerControlProcessDialogKey = true;
			this.objectBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.objectBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dropColumn,
            this.createIndex,
            this.createView,
            this.createStoredProc,
            this.createFunction,
            this.createTrigger,
            this.createEvent});
			this.objectBar.Location = new System.Drawing.Point(554, 0);
			this.objectBar.Name = "objectBar";
			this.objectBar.Size = new System.Drawing.Size(446, 119);
			this.objectBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.objectBar.TabIndex = 3;
			this.objectBar.Text = "오브젝트";
			// 
			// 
			// 
			this.objectBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.objectBar.TitleStyleMouseOver.Class = "";
			// 
			// dropColumn
			// 
			this.dropColumn.Image = global::Easy2.Properties.Resources.DropColumn;
			this.dropColumn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.dropColumn.KeyTips = "C";
			this.dropColumn.Name = "dropColumn";
			this.dropColumn.SubItemsExpandWidth = 14;
			this.dropColumn.Text = "<div align=\"center\">컬럼<br/>제거하기</div>";
			// 
			// createIndex
			// 
			this.createIndex.Image = global::Easy2.Properties.Resources.CreateIndex;
			this.createIndex.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createIndex.KeyTips = "I";
			this.createIndex.Name = "createIndex";
			this.createIndex.SplitButton = true;
			this.createIndex.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.indexItemContainer});
			this.createIndex.SubItemsExpandWidth = 14;
			this.createIndex.Text = "인덱스";
			// 
			// indexItemContainer
			// 
			// 
			// 
			// 
			this.indexItemContainer.BackgroundStyle.Class = "";
			this.indexItemContainer.Name = "indexItemContainer";
			this.indexItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterIndex,
            this.dropIndex});
			// 
			// alterIndex
			// 
			this.alterIndex.Image = global::Easy2.Properties.Resources.AlterIndex;
			this.alterIndex.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.alterIndex.KeyTips = "A";
			this.alterIndex.Name = "alterIndex";
			this.alterIndex.Text = "<div align=\"center\">인덱스<br/>수정하기</div>";
			// 
			// dropIndex
			// 
			this.dropIndex.Image = global::Easy2.Properties.Resources.DropIndex;
			this.dropIndex.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.dropIndex.KeyTips = "D";
			this.dropIndex.Name = "dropIndex";
			this.dropIndex.Text = "<div center=\"center\">인덱스<br/>제거하기</div>";
			// 
			// createView
			// 
			this.createView.Image = global::Easy2.Properties.Resources.CreateView;
			this.createView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createView.KeyTips = "V";
			this.createView.Name = "createView";
			this.createView.SplitButton = true;
			this.createView.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.viewItemContainer});
			this.createView.SubItemsExpandWidth = 14;
			this.createView.Text = "뷰";
			// 
			// viewItemContainer
			// 
			// 
			// 
			// 
			this.viewItemContainer.BackgroundStyle.Class = "";
			this.viewItemContainer.Name = "viewItemContainer";
			this.viewItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterView,
            this.dropView});
			// 
			// alterView
			// 
			this.alterView.Image = global::Easy2.Properties.Resources.AlterView;
			this.alterView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.alterView.KeyTips = "A";
			this.alterView.Name = "alterView";
			this.alterView.Text = "<div align=\"center\">뷰<br/>수정하기</div>";
			// 
			// dropView
			// 
			this.dropView.Image = global::Easy2.Properties.Resources.DropView;
			this.dropView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.dropView.KeyTips = "D";
			this.dropView.Name = "dropView";
			this.dropView.Text = "<div align=\"center\">뷰<br/>제거하기</div>";
			// 
			// createStoredProc
			// 
			this.createStoredProc.Image = global::Easy2.Properties.Resources.CreateStoredProcedure;
			this.createStoredProc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createStoredProc.KeyTips = "P";
			this.createStoredProc.Name = "createStoredProc";
			this.createStoredProc.SplitButton = true;
			this.createStoredProc.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.storedProcItemContainer});
			this.createStoredProc.SubItemsExpandWidth = 14;
			this.createStoredProc.Text = "저장프로시저";
			// 
			// storedProcItemContainer
			// 
			// 
			// 
			// 
			this.storedProcItemContainer.BackgroundStyle.Class = "";
			this.storedProcItemContainer.Name = "storedProcItemContainer";
			this.storedProcItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterStoredProc,
            this.dropStoredProc});
			// 
			// alterStoredProc
			// 
			this.alterStoredProc.Image = global::Easy2.Properties.Resources.AlterStoredProcedure;
			this.alterStoredProc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.alterStoredProc.KeyTips = "A";
			this.alterStoredProc.Name = "alterStoredProc";
			this.alterStoredProc.Text = "<div align=\"center\">저장프로시저<br/>수정하기</div>";
			// 
			// dropStoredProc
			// 
			this.dropStoredProc.Image = global::Easy2.Properties.Resources.DropStoredProcedure;
			this.dropStoredProc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.dropStoredProc.KeyTips = "D";
			this.dropStoredProc.Name = "dropStoredProc";
			this.dropStoredProc.Text = "<div align=\"center\">저장프로시저<br/>제거하기</div>";
			// 
			// createFunction
			// 
			this.createFunction.Image = global::Easy2.Properties.Resources.CreateFunction;
			this.createFunction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createFunction.KeyTips = "F";
			this.createFunction.Name = "createFunction";
			this.createFunction.SplitButton = true;
			this.createFunction.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.functionitemContainer});
			this.createFunction.SubItemsExpandWidth = 14;
			this.createFunction.Text = "함수";
			// 
			// functionitemContainer
			// 
			// 
			// 
			// 
			this.functionitemContainer.BackgroundStyle.Class = "";
			this.functionitemContainer.Name = "functionitemContainer";
			this.functionitemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterFunction,
            this.dropFunction});
			// 
			// alterFunction
			// 
			this.alterFunction.Image = global::Easy2.Properties.Resources.AlterFunction;
			this.alterFunction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.alterFunction.KeyTips = "A";
			this.alterFunction.Name = "alterFunction";
			this.alterFunction.Text = "<div align=\"center\">함수<br/>수정하기</div>";
			// 
			// dropFunction
			// 
			this.dropFunction.Image = global::Easy2.Properties.Resources.DropFunction;
			this.dropFunction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.dropFunction.KeyTips = "D";
			this.dropFunction.Name = "dropFunction";
			this.dropFunction.Text = "<div align=\"center\">함수<br/>제거하기</div>";
			// 
			// createTrigger
			// 
			this.createTrigger.Image = global::Easy2.Properties.Resources.CreateTrigger;
			this.createTrigger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createTrigger.KeyTips = "G";
			this.createTrigger.Name = "createTrigger";
			this.createTrigger.SplitButton = true;
			this.createTrigger.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.triggerItemContainer});
			this.createTrigger.SubItemsExpandWidth = 14;
			this.createTrigger.Text = "트리거";
			// 
			// triggerItemContainer
			// 
			// 
			// 
			// 
			this.triggerItemContainer.BackgroundStyle.Class = "";
			this.triggerItemContainer.Name = "triggerItemContainer";
			this.triggerItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterTrigger,
            this.dropTrigger});
			// 
			// alterTrigger
			// 
			this.alterTrigger.Image = global::Easy2.Properties.Resources.AlterTrigger;
			this.alterTrigger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.alterTrigger.KeyTips = "A";
			this.alterTrigger.Name = "alterTrigger";
			this.alterTrigger.Text = "<div align=\"center\">트리거<br/>수정하기</div>";
			// 
			// dropTrigger
			// 
			this.dropTrigger.Image = global::Easy2.Properties.Resources.DropTrigger;
			this.dropTrigger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.dropTrigger.KeyTips = "D";
			this.dropTrigger.Name = "dropTrigger";
			this.dropTrigger.Text = "<div align=\"center\">트리거<br/>제거하기</div>";
			// 
			// createEvent
			// 
			this.createEvent.Image = global::Easy2.Properties.Resources.CreateEvent;
			this.createEvent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createEvent.KeyTips = "E";
			this.createEvent.Name = "createEvent";
			this.createEvent.SplitButton = true;
			this.createEvent.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.eventItemContainer});
			this.createEvent.SubItemsExpandWidth = 14;
			this.createEvent.Text = "이벤트";
			// 
			// eventItemContainer
			// 
			// 
			// 
			// 
			this.eventItemContainer.BackgroundStyle.Class = "";
			this.eventItemContainer.Name = "eventItemContainer";
			this.eventItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterEvent,
            this.dropEvent});
			// 
			// alterEvent
			// 
			this.alterEvent.Image = global::Easy2.Properties.Resources.AlterEvent;
			this.alterEvent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.alterEvent.KeyTips = "A";
			this.alterEvent.Name = "alterEvent";
			this.alterEvent.Text = "<div align=\"center\">이벤트<br/>수정하기</div>";
			// 
			// dropEvent
			// 
			this.dropEvent.Image = global::Easy2.Properties.Resources.DropEvent;
			this.dropEvent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.dropEvent.KeyTips = "D";
			this.dropEvent.Name = "dropEvent";
			this.dropEvent.Text = "<div align=\"center\">이벤트<br/>제거하기</div>";
			// 
			// tableBar
			// 
			this.tableBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.tableBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.tableBar.BackgroundStyle.Class = "";
			this.tableBar.ContainerControlProcessDialogKey = true;
			this.tableBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.tableBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.createTable,
            this.tableItemContainer});
			this.tableBar.Location = new System.Drawing.Point(362, 0);
			this.tableBar.Name = "tableBar";
			this.tableBar.Size = new System.Drawing.Size(192, 119);
			this.tableBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tableBar.TabIndex = 2;
			this.tableBar.Text = "테이블";
			// 
			// 
			// 
			this.tableBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.tableBar.TitleStyleMouseOver.Class = "";
			// 
			// createTable
			// 
			this.createTable.Image = global::Easy2.Properties.Resources.CreateTable;
			this.createTable.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createTable.KeyTips = "TC";
			this.createTable.Name = "createTable";
			this.createTable.SubItemsExpandWidth = 14;
			this.createTable.Text = "<div align=\"center\">테이블<br/>만들기</div>";
			// 
			// tableItemContainer
			// 
			// 
			// 
			// 
			this.tableItemContainer.BackgroundStyle.Class = "";
			this.tableItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.tableItemContainer.Name = "tableItemContainer";
			this.tableItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterTable,
            this.truncateTable,
            this.dropTable});
			this.tableItemContainer.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// alterTable
			// 
			this.alterTable.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.alterTable.Image = global::Easy2.Properties.Resources.AlterTable;
			this.alterTable.KeyTips = "TA";
			this.alterTable.Name = "alterTable";
			this.alterTable.Text = "테이블 수정하기";
			// 
			// truncateTable
			// 
			this.truncateTable.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.truncateTable.Image = global::Easy2.Properties.Resources.TruncateTable;
			this.truncateTable.KeyTips = "TT";
			this.truncateTable.Name = "truncateTable";
			this.truncateTable.Text = "테이블 비우기";
			// 
			// dropTable
			// 
			this.dropTable.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.dropTable.Image = global::Easy2.Properties.Resources.DropTable;
			this.dropTable.KeyTips = "TD";
			this.dropTable.Name = "dropTable";
			this.dropTable.Text = "테이블 제거하기";
			// 
			// databaseBar
			// 
			this.databaseBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.databaseBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.databaseBar.BackgroundStyle.Class = "";
			this.databaseBar.ContainerControlProcessDialogKey = true;
			this.databaseBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.databaseBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.createDatabase,
            this.databaseItemContainer});
			this.databaseBar.Location = new System.Drawing.Point(192, 0);
			this.databaseBar.Name = "databaseBar";
			this.databaseBar.Size = new System.Drawing.Size(170, 119);
			this.databaseBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.databaseBar.TabIndex = 1;
			this.databaseBar.Text = "데이터베이스";
			// 
			// 
			// 
			this.databaseBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.databaseBar.TitleStyleMouseOver.Class = "";
			// 
			// createDatabase
			// 
			this.createDatabase.Image = global::Easy2.Properties.Resources.CreateDatabase;
			this.createDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.createDatabase.KeyTips = "DC";
			this.createDatabase.Name = "createDatabase";
			this.createDatabase.SubItemsExpandWidth = 14;
			this.createDatabase.Text = "<div align=\"center\">DB<br/>만들기</div>";
			// 
			// databaseItemContainer
			// 
			// 
			// 
			// 
			this.databaseItemContainer.BackgroundStyle.Class = "";
			this.databaseItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.databaseItemContainer.Name = "databaseItemContainer";
			this.databaseItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.alterDatabase,
            this.truncateDatabase,
            this.dropDatabase});
			this.databaseItemContainer.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// alterDatabase
			// 
			this.alterDatabase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.alterDatabase.Image = global::Easy2.Properties.Resources.AlterDatabase;
			this.alterDatabase.KeyTips = "DA";
			this.alterDatabase.Name = "alterDatabase";
			this.alterDatabase.Text = "DB 수정하기";
			// 
			// truncateDatabase
			// 
			this.truncateDatabase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.truncateDatabase.Image = global::Easy2.Properties.Resources.TruncateDatabase;
			this.truncateDatabase.KeyTips = "DT";
			this.truncateDatabase.Name = "truncateDatabase";
			this.truncateDatabase.Text = "DB 비우기";
			// 
			// dropDatabase
			// 
			this.dropDatabase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.dropDatabase.Image = global::Easy2.Properties.Resources.DropDatabase;
			this.dropDatabase.KeyTips = "DD";
			this.dropDatabase.Name = "dropDatabase";
			this.dropDatabase.Text = "DB 제거하기";
			// 
			// userBar
			// 
			this.userBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.userBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.userBar.BackgroundStyle.Class = "";
			this.userBar.ContainerControlProcessDialogKey = true;
			this.userBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.userBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.addUser,
            this.alterUser,
            this.privilegeUser});
			this.userBar.Location = new System.Drawing.Point(3, 0);
			this.userBar.Name = "userBar";
			this.userBar.Size = new System.Drawing.Size(189, 119);
			this.userBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.userBar.TabIndex = 0;
			this.userBar.Text = "사용자";
			// 
			// 
			// 
			this.userBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.userBar.TitleStyleMouseOver.Class = "";
			// 
			// addUser
			// 
			this.addUser.Image = global::Easy2.Properties.Resources.AddUser;
			this.addUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.addUser.KeyTips = "UA";
			this.addUser.Name = "addUser";
			this.addUser.SplitButton = true;
			this.addUser.SubItemsExpandWidth = 14;
			this.addUser.Text = "<div align=\"center\">사용자<br/>추가하기</div>";
			// 
			// alterUser
			// 
			this.alterUser.Image = global::Easy2.Properties.Resources.AlterUser;
			this.alterUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.alterUser.KeyTips = "UE";
			this.alterUser.Name = "alterUser";
			this.alterUser.SubItemsExpandWidth = 14;
			this.alterUser.Text = "<div align=\"center\">사용자<br/>수정하기</div>";
			// 
			// privilegeUser
			// 
			this.privilegeUser.Image = global::Easy2.Properties.Resources.PrivilegeUser;
			this.privilegeUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.privilegeUser.KeyTips = "UP";
			this.privilegeUser.Name = "privilegeUser";
			this.privilegeUser.SubItemsExpandWidth = 14;
			this.privilegeUser.Text = "<div align=\"center\">권한<br/>설정하기</div>";
			// 
			// toolPanel
			// 
			this.toolPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.toolPanel.Controls.Add(this.externalBar);
			this.toolPanel.Controls.Add(this.bakupBar);
			this.toolPanel.Controls.Add(this.openBar);
			this.toolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolPanel.Location = new System.Drawing.Point(0, 56);
			this.toolPanel.Name = "toolPanel";
			this.toolPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.toolPanel.Size = new System.Drawing.Size(1106, 122);
			// 
			// 
			// 
			this.toolPanel.Style.Class = "";
			// 
			// 
			// 
			this.toolPanel.StyleMouseDown.Class = "";
			// 
			// 
			// 
			this.toolPanel.StyleMouseOver.Class = "";
			this.toolPanel.TabIndex = 3;
			this.toolPanel.Visible = false;
			// 
			// externalBar
			// 
			this.externalBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.externalBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.externalBar.BackgroundStyle.Class = "";
			this.externalBar.ContainerControlProcessDialogKey = true;
			this.externalBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.externalBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.importExternal,
            this.exportExternal});
			this.externalBar.Location = new System.Drawing.Point(198, 0);
			this.externalBar.Name = "externalBar";
			this.externalBar.Size = new System.Drawing.Size(140, 119);
			this.externalBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.externalBar.TabIndex = 2;
			this.externalBar.Text = "가져오기/내보내기";
			// 
			// 
			// 
			this.externalBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.externalBar.TitleStyleMouseOver.Class = "";
			// 
			// importExternal
			// 
			this.importExternal.Image = global::Easy2.Properties.Resources.ImportDatabase;
			this.importExternal.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.importExternal.KeyTips = "I";
			this.importExternal.Name = "importExternal";
			this.importExternal.SubItemsExpandWidth = 14;
			this.importExternal.Text = "가져오기";
			// 
			// exportExternal
			// 
			this.exportExternal.Image = global::Easy2.Properties.Resources.ExportDatabase;
			this.exportExternal.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.exportExternal.KeyTips = "E";
			this.exportExternal.Name = "exportExternal";
			this.exportExternal.SubItemsExpandWidth = 14;
			this.exportExternal.Text = "내보내기";
			// 
			// bakupBar
			// 
			this.bakupBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.bakupBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.bakupBar.BackgroundStyle.Class = "";
			this.bakupBar.ContainerControlProcessDialogKey = true;
			this.bakupBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.bakupBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.backupDatabase,
            this.restoreDatabase});
			this.bakupBar.Location = new System.Drawing.Point(70, 0);
			this.bakupBar.Name = "bakupBar";
			this.bakupBar.Size = new System.Drawing.Size(128, 119);
			this.bakupBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bakupBar.TabIndex = 1;
			this.bakupBar.Text = "백업/복구";
			// 
			// 
			// 
			this.bakupBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.bakupBar.TitleStyleMouseOver.Class = "";
			// 
			// backupDatabase
			// 
			this.backupDatabase.Image = global::Easy2.Properties.Resources.CopyDatabase;
			this.backupDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.backupDatabase.KeyTips = "DB";
			this.backupDatabase.Name = "backupDatabase";
			this.backupDatabase.SubItemsExpandWidth = 14;
			this.backupDatabase.Text = "<div align=\"center\">DB<br/>백업하기</div>";
			// 
			// restoreDatabase
			// 
			this.restoreDatabase.Image = global::Easy2.Properties.Resources.RestoreDatabase;
			this.restoreDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.restoreDatabase.KeyTips = "DR";
			this.restoreDatabase.Name = "restoreDatabase";
			this.restoreDatabase.SubItemsExpandWidth = 14;
			this.restoreDatabase.Text = "<div align=\"center\">DB<br/>복원하기</div>";
			// 
			// openBar
			// 
			this.openBar.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.openBar.BackgroundMouseOverStyle.Class = "";
			// 
			// 
			// 
			this.openBar.BackgroundStyle.Class = "";
			this.openBar.ContainerControlProcessDialogKey = true;
			this.openBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.openBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.openObject});
			this.openBar.Location = new System.Drawing.Point(3, 0);
			this.openBar.Name = "openBar";
			this.openBar.Size = new System.Drawing.Size(67, 119);
			this.openBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.openBar.TabIndex = 0;
			this.openBar.Text = "열기";
			// 
			// 
			// 
			this.openBar.TitleStyle.Class = "";
			// 
			// 
			// 
			this.openBar.TitleStyleMouseOver.Class = "";
			// 
			// openObject
			// 
			this.openObject.Image = global::Easy2.Properties.Resources.OpenObject;
			this.openObject.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.openObject.KeyTips = "O";
			this.openObject.Name = "openObject";
			this.openObject.SubItemsExpandWidth = 14;
			this.openObject.Text = "<div align=\"center\">오브젝트<br/>열기</div>";
			// 
			// startButton
			// 
			this.startButton.AutoExpandOnClick = true;
			this.startButton.CanCustomize = false;
			this.startButton.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
			this.startButton.ImageFixedSize = new System.Drawing.Size(16, 16);
			this.startButton.ImagePaddingHorizontal = 0;
			this.startButton.ImagePaddingVertical = 0;
			this.startButton.Name = "startButton";
			this.startButton.ShowSubItems = false;
			this.startButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.fileItemContainer});
			this.startButton.Text = "&File";
			// 
			// fileItemContainer
			// 
			// 
			// 
			// 
			this.fileItemContainer.BackgroundStyle.Class = "RibbonFileMenuContainer";
			this.fileItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.fileItemContainer.Name = "fileItemContainer";
			this.fileItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.fileMenuItemContainer,
            this.botomItemContainer});
			// 
			// fileMenuItemContainer
			// 
			// 
			// 
			// 
			this.fileMenuItemContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
			this.fileMenuItemContainer.ItemSpacing = 0;
			this.fileMenuItemContainer.Name = "fileMenuItemContainer";
			this.fileMenuItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.leftItemContainer,
            this.rightItemContainer});
			// 
			// leftItemContainer
			// 
			// 
			// 
			// 
			this.leftItemContainer.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
			this.leftItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.leftItemContainer.MinimumSize = new System.Drawing.Size(120, 0);
			this.leftItemContainer.Name = "leftItemContainer";
			this.leftItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.newConnection,
            this.newConnectionUsingCurrentSettings,
            this.newQueryEditor,
            this.newQueryWizard,
            this.newSchemaDesigner,
            this.closeTab,
            this.disconnectMySql,
            this.disconnectAllMySql,
            this.openFileInSameTab,
            this.openFileInNewTab,
            this.saveFile,
            this.saveAs});
			// 
			// newConnection
			// 
			this.newConnection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.newConnection.Image = global::Easy2.Properties.Resources.ConnectDatabase;
			this.newConnection.Name = "newConnection";
			this.newConnection.SubItemsExpandWidth = 24;
			this.newConnection.Text = "새로운 연결(&C)...";
			// 
			// newConnectionUsingCurrentSettings
			// 
			this.newConnectionUsingCurrentSettings.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.newConnectionUsingCurrentSettings.Image = ((System.Drawing.Image)(resources.GetObject("newConnectionUsingCurrentSettings.Image")));
			this.newConnectionUsingCurrentSettings.Name = "newConnectionUsingCurrentSettings";
			this.newConnectionUsingCurrentSettings.SubItemsExpandWidth = 24;
			this.newConnectionUsingCurrentSettings.Text = "기존 설정 연결(&N)";
			// 
			// newQueryEditor
			// 
			this.newQueryEditor.BeginGroup = true;
			this.newQueryEditor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.newQueryEditor.Image = global::Easy2.Properties.Resources.QueryEditor;
			this.newQueryEditor.Name = "newQueryEditor";
			this.newQueryEditor.SubItemsExpandWidth = 24;
			this.newQueryEditor.Text = "새 쿼리 에디터(&Q)";
			// 
			// newQueryWizard
			// 
			this.newQueryWizard.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.newQueryWizard.Image = global::Easy2.Properties.Resources.QueryWizard;
			this.newQueryWizard.Name = "newQueryWizard";
			this.newQueryWizard.SubItemsExpandWidth = 24;
			this.newQueryWizard.Text = "새 쿼리 마법사(&W)";
			// 
			// newSchemaDesigner
			// 
			this.newSchemaDesigner.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.newSchemaDesigner.Image = global::Easy2.Properties.Resources.SchemaDesigner;
			this.newSchemaDesigner.Name = "newSchemaDesigner";
			this.newSchemaDesigner.SubItemsExpandWidth = 24;
			this.newSchemaDesigner.Text = "새 스키마 디자이너(&H)";
			// 
			// closeTab
			// 
			this.closeTab.BeginGroup = true;
			this.closeTab.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.closeTab.Image = global::Easy2.Properties.Resources.CloseTab;
			this.closeTab.Name = "closeTab";
			this.closeTab.SubItemsExpandWidth = 24;
			this.closeTab.Text = "댑 닫기(&T)";
			// 
			// disconnectMySql
			// 
			this.disconnectMySql.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.disconnectMySql.Image = global::Easy2.Properties.Resources.Disconnect;
			this.disconnectMySql.Name = "disconnectMySql";
			this.disconnectMySql.Text = "연결종료(&D)";
			// 
			// disconnectAllMySql
			// 
			this.disconnectAllMySql.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.disconnectAllMySql.Image = global::Easy2.Properties.Resources.DisconnectAll;
			this.disconnectAllMySql.Name = "disconnectAllMySql";
			this.disconnectAllMySql.Text = "모든 연결종료(&L)";
			// 
			// openFileInSameTab
			// 
			this.openFileInSameTab.BeginGroup = true;
			this.openFileInSameTab.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.openFileInSameTab.Image = global::Easy2.Properties.Resources.OpenFile;
			this.openFileInSameTab.Name = "openFileInSameTab";
			this.openFileInSameTab.Text = "불러오기(&O)...";
			// 
			// openFileInNewTab
			// 
			this.openFileInNewTab.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.openFileInNewTab.Image = global::Easy2.Properties.Resources.OpenFileNewTab;
			this.openFileInNewTab.Name = "openFileInNewTab";
			this.openFileInNewTab.Text = "새 탭에 불러오기(&F)...";
			// 
			// saveFile
			// 
			this.saveFile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.saveFile.Image = global::Easy2.Properties.Resources.SaveFile;
			this.saveFile.Name = "saveFile";
			this.saveFile.Text = "저장하기(&S)...";
			// 
			// saveAs
			// 
			this.saveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.saveAs.Image = global::Easy2.Properties.Resources.SaveAsFile;
			this.saveAs.Name = "saveAs";
			this.saveAs.Text = "다른 이름으로 저장하기(&A)...";
			// 
			// rightItemContainer
			// 
			// 
			// 
			// 
			this.rightItemContainer.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
			this.rightItemContainer.EnableGalleryPopup = false;
			this.rightItemContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.rightItemContainer.MinimumSize = new System.Drawing.Size(180, 240);
			this.rightItemContainer.MultiLine = false;
			this.rightItemContainer.Name = "rightItemContainer";
			this.rightItemContainer.PopupUsesStandardScrollbars = false;
			this.rightItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.recentLabel});
			// 
			// recentLabel
			// 
			this.recentLabel.Name = "recentLabel";
			this.recentLabel.Text = "최근 사용한 파일";
			// 
			// botomItemContainer
			// 
			// 
			// 
			// 
			this.botomItemContainer.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
			this.botomItemContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
			this.botomItemContainer.Name = "botomItemContainer";
			this.botomItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.quitApplication});
			// 
			// quitApplication
			// 
			this.quitApplication.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.quitApplication.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.quitApplication.Image = global::Easy2.Properties.Resources.QuitApplication;
			this.quitApplication.Name = "quitApplication";
			this.quitApplication.SubItemsExpandWidth = 24;
			this.quitApplication.Text = "종료하기(&X)";
			// 
			// homeTab
			// 
			this.homeTab.Checked = true;
			this.homeTab.KeyTips = "H";
			this.homeTab.Name = "homeTab";
			this.homeTab.Panel = this.homePanel;
			this.homeTab.Text = "홈";
			// 
			// createTab
			// 
			this.createTab.KeyTips = "C";
			this.createTab.Name = "createTab";
			this.createTab.Panel = this.createPanel;
			this.createTab.Text = "만들기";
			// 
			// toolTab
			// 
			this.toolTab.KeyTips = "T";
			this.toolTab.Name = "toolTab";
			this.toolTab.Panel = this.toolPanel;
			this.toolTab.Text = "도구";
			// 
			// configGroup
			// 
			this.configGroup.AutoExpandOnClick = true;
			this.configGroup.Image = ((System.Drawing.Image)(resources.GetObject("configGroup.Image")));
			this.configGroup.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.configGroup.Name = "configGroup";
			this.configGroup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.appSettings,
            this.formTheme});
			// 
			// appSettings
			// 
			this.appSettings.Image = global::Easy2.Properties.Resources.Settings;
			this.appSettings.Name = "appSettings";
			this.appSettings.Text = "환경설정(&U)...";
			// 
			// formTheme
			// 
			this.formTheme.AutoExpandOnClick = true;
			this.formTheme.BeginGroup = true;
			this.formTheme.Image = global::Easy2.Properties.Resources.FormStyle;
			this.formTheme.Name = "formTheme";
			this.formTheme.OptionGroup = "theme";
			this.formTheme.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.aeroSilver,
            this.aeroBlue,
            this.officeBlue,
            this.officeBlack,
            this.officeSilver,
            this.officeNavy,
            this.customColor});
			this.formTheme.Text = "테마(&T)";
			// 
			// aeroSilver
			// 
			this.aeroSilver.Checked = true;
			this.aeroSilver.Command = this.AppCommandTheme;
			this.aeroSilver.CommandParameter = "Office2010Silver";
			this.aeroSilver.Name = "aeroSilver";
			this.aeroSilver.OptionGroup = "theme";
			this.aeroSilver.Text = "Aero Silver";
			// 
			// AppCommandTheme
			// 
			this.AppCommandTheme.Executed += new System.EventHandler(this.AppCommandTheme_Executed);
			// 
			// aeroBlue
			// 
			this.aeroBlue.Command = this.AppCommandTheme;
			this.aeroBlue.CommandParameter = "Windows7Blue";
			this.aeroBlue.Name = "aeroBlue";
			this.aeroBlue.OptionGroup = "theme";
			this.aeroBlue.Text = "Aero Blue";
			// 
			// officeBlue
			// 
			this.officeBlue.Command = this.AppCommandTheme;
			this.officeBlue.CommandParameter = "Office2007Blue";
			this.officeBlue.Name = "officeBlue";
			this.officeBlue.OptionGroup = "theme";
			this.officeBlue.Text = "Office Blue";
			// 
			// officeBlack
			// 
			this.officeBlack.Command = this.AppCommandTheme;
			this.officeBlack.CommandParameter = "Office2007Black";
			this.officeBlack.Name = "officeBlack";
			this.officeBlack.OptionGroup = "theme";
			this.officeBlack.Text = "Office Black";
			// 
			// officeSilver
			// 
			this.officeSilver.Command = this.AppCommandTheme;
			this.officeSilver.CommandParameter = "Office2007Silver";
			this.officeSilver.Name = "officeSilver";
			this.officeSilver.OptionGroup = "theme";
			this.officeSilver.Text = "Office Silver";
			// 
			// officeNavy
			// 
			this.officeNavy.Command = this.AppCommandTheme;
			this.officeNavy.CommandParameter = "Office2007VistaGlass";
			this.officeNavy.Name = "officeNavy";
			this.officeNavy.OptionGroup = "theme";
			this.officeNavy.Text = "Office Navy";
			// 
			// customColor
			// 
			this.customColor.BeginGroup = true;
			this.customColor.Command = this.AppCommandTheme;
			this.customColor.Image = global::Easy2.Properties.Resources.ColorTable;
			this.customColor.Name = "customColor";
			this.customColor.Text = "Custom Color";
			this.customColor.ColorPreview += new DevComponents.DotNetBar.ColorPreviewEventHandler(this.customColor_ColorPreview);
			this.customColor.SelectedColorChanged += new System.EventHandler(this.customColor_SelectedColorChanged);
			this.customColor.ExpandChange += new System.EventHandler(this.customColor_ExpandChange);
			// 
			// helpGroup
			// 
			this.helpGroup.AutoExpandOnClick = true;
			this.helpGroup.Image = global::Easy2.Properties.Resources.Help;
			this.helpGroup.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.helpGroup.Name = "helpGroup";
			this.helpGroup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.helpDocument,
            this.updateCheck,
            this.showAbout});
			// 
			// helpDocument
			// 
			this.helpDocument.Image = global::Easy2.Properties.Resources.HelpDocument;
			this.helpDocument.Name = "helpDocument";
			this.helpDocument.Text = "도움말(&H)...";
			// 
			// updateCheck
			// 
			this.updateCheck.BeginGroup = true;
			this.updateCheck.Image = global::Easy2.Properties.Resources.UpdateCheck;
			this.updateCheck.Name = "updateCheck";
			this.updateCheck.Text = "업데이트 확인(&U)...";
			// 
			// showAbout
			// 
			this.showAbout.BeginGroup = true;
			this.showAbout.Name = "showAbout";
			this.showAbout.Text = "Easy to MySQL 정보(&A)...";
			// 
			// qatButton
			// 
			this.qatButton.Name = "qatButton";
			this.qatButton.Text = "QAT";
			// 
			// qatCustomizeItem
			// 
			this.qatCustomizeItem.Name = "qatCustomizeItem";
			// 
			// styleManager
			// 
			this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
			// 
			// statusBar
			// 
			this.statusBar.AccessibleDescription = "DotNetBar Bar (statusBar)";
			this.statusBar.AccessibleName = "DotNetBar Bar";
			this.statusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
			this.statusBar.Location = new System.Drawing.Point(4, 605);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(1106, 25);
			this.statusBar.Stretch = true;
			this.statusBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.statusBar.TabIndex = 1;
			this.statusBar.TabStop = false;
			this.statusBar.Text = "statusBar";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 632);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.ribbonControl);
			this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "Easy To MySQL";
			this.ribbonControl.ResumeLayout(false);
			this.ribbonControl.PerformLayout();
			this.homePanel.ResumeLayout(false);
			this.createPanel.ResumeLayout(false);
			this.toolPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.RibbonControl ribbonControl;
		private DevComponents.DotNetBar.RibbonPanel homePanel;
		private DevComponents.DotNetBar.RibbonBar refreshBar;
		private DevComponents.DotNetBar.RibbonPanel createPanel;
		private DevComponents.DotNetBar.RibbonTabItem homeTab;
		private DevComponents.DotNetBar.RibbonTabItem createTab;
		private DevComponents.DotNetBar.Office2007StartButton startButton;
		private DevComponents.DotNetBar.ItemContainer fileItemContainer;
		private DevComponents.DotNetBar.ItemContainer fileMenuItemContainer;
		private DevComponents.DotNetBar.ItemContainer leftItemContainer;
		private DevComponents.DotNetBar.ButtonItem newConnection;
		private DevComponents.DotNetBar.ButtonItem newConnectionUsingCurrentSettings;
		private DevComponents.DotNetBar.ButtonItem newQueryEditor;
		private DevComponents.DotNetBar.ButtonItem newQueryWizard;
		private DevComponents.DotNetBar.ButtonItem newSchemaDesigner;
		private DevComponents.DotNetBar.ButtonItem closeTab;
		private DevComponents.DotNetBar.ButtonItem disconnectMySql;
		private DevComponents.DotNetBar.GalleryContainer rightItemContainer;
		private DevComponents.DotNetBar.ItemContainer botomItemContainer;
		private DevComponents.DotNetBar.ButtonItem quitApplication;
		private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem;
		private DevComponents.DotNetBar.StyleManager styleManager;
		private DevComponents.DotNetBar.ButtonItem disconnectAllMySql;
		private DevComponents.DotNetBar.ButtonItem openFileInSameTab;
		private DevComponents.DotNetBar.ButtonItem openFileInNewTab;
		private DevComponents.DotNetBar.ButtonItem saveFile;
		private DevComponents.DotNetBar.ButtonItem saveAs;
		private DevComponents.DotNetBar.RibbonBar clipboardBar;
		private DevComponents.DotNetBar.ButtonItem pasteToClipboard;
		private DevComponents.DotNetBar.ButtonItem refreshObjectBrowser;
		private DevComponents.DotNetBar.ItemContainer clipboardItemContainer;
		private DevComponents.DotNetBar.ButtonItem cutSelection;
		private DevComponents.DotNetBar.ButtonItem copySelection;
		private DevComponents.DotNetBar.LabelItem recentLabel;
		private DevComponents.DotNetBar.RibbonBar editBar;
		private DevComponents.DotNetBar.ButtonItem findData;
		private DevComponents.DotNetBar.ItemContainer editItemContainer1;
		private DevComponents.DotNetBar.ItemContainer editItemContainer2;
		private DevComponents.DotNetBar.ButtonItem findNextData;
		private DevComponents.DotNetBar.ButtonItem replaceData;
		private DevComponents.DotNetBar.ButtonItem goToLine;
		private DevComponents.DotNetBar.ButtonItem selectAll;
		private DevComponents.DotNetBar.ButtonItem cancelSelection;
		private DevComponents.DotNetBar.ButtonItem clearSelection;
		private DevComponents.DotNetBar.ItemContainer editItemContainer3;
		private DevComponents.DotNetBar.ButtonItem undoAction;
		private DevComponents.DotNetBar.ButtonItem redoAction;
		private DevComponents.DotNetBar.RibbonBar executeBar;
		private DevComponents.DotNetBar.ButtonItem executeQuery;
		private DevComponents.DotNetBar.ButtonItem executeSelectQuery;
		private DevComponents.DotNetBar.ButtonItem execyteAllQuery;
		private DevComponents.DotNetBar.RibbonBar tabBar;
		private DevComponents.DotNetBar.ButtonItem switchPreviousTab;
		private DevComponents.DotNetBar.ButtonItem switchNextTab;
		private DevComponents.DotNetBar.RibbonBar paneBar;
		private DevComponents.DotNetBar.ItemContainer paneItemContainer;
		private DevComponents.DotNetBar.CheckBoxItem objectBrowserPane;
		private DevComponents.DotNetBar.CheckBoxItem queryEditPane;
		private DevComponents.DotNetBar.CheckBoxItem resultPane;
		private DevComponents.DotNetBar.RibbonBar userBar;
		private DevComponents.DotNetBar.ButtonItem addUser;
		private DevComponents.DotNetBar.ButtonItem alterUser;
		private DevComponents.DotNetBar.ButtonItem privilegeUser;
		private DevComponents.DotNetBar.RibbonBar databaseBar;
		private DevComponents.DotNetBar.ButtonItem createDatabase;
		private DevComponents.DotNetBar.ItemContainer databaseItemContainer;
		private DevComponents.DotNetBar.ButtonItem alterDatabase;
		private DevComponents.DotNetBar.ButtonItem truncateDatabase;
		private DevComponents.DotNetBar.ButtonItem dropDatabase;
		private DevComponents.DotNetBar.RibbonBar tableBar;
		private DevComponents.DotNetBar.ButtonItem createTable;
		private DevComponents.DotNetBar.ItemContainer tableItemContainer;
		private DevComponents.DotNetBar.ButtonItem alterTable;
		private DevComponents.DotNetBar.ButtonItem truncateTable;
		private DevComponents.DotNetBar.ButtonItem dropTable;
		private DevComponents.DotNetBar.RibbonBar objectBar;
		private DevComponents.DotNetBar.ButtonItem dropColumn;
		private DevComponents.DotNetBar.ButtonItem createIndex;
		private DevComponents.DotNetBar.ButtonItem createView;
		private DevComponents.DotNetBar.ButtonItem createStoredProc;
		private DevComponents.DotNetBar.ButtonItem createFunction;
		private DevComponents.DotNetBar.ButtonItem createTrigger;
		private DevComponents.DotNetBar.ButtonItem createEvent;
		private DevComponents.DotNetBar.ItemContainer indexItemContainer;
		private DevComponents.DotNetBar.ButtonItem dropIndex;
		private DevComponents.DotNetBar.ButtonItem alterIndex;
		private DevComponents.DotNetBar.ItemContainer viewItemContainer;
		private DevComponents.DotNetBar.ButtonItem alterView;
		private DevComponents.DotNetBar.ButtonItem dropView;
		private DevComponents.DotNetBar.ItemContainer storedProcItemContainer;
		private DevComponents.DotNetBar.ButtonItem alterStoredProc;
		private DevComponents.DotNetBar.ButtonItem dropStoredProc;
		private DevComponents.DotNetBar.ItemContainer functionitemContainer;
		private DevComponents.DotNetBar.ButtonItem alterFunction;
		private DevComponents.DotNetBar.ButtonItem dropFunction;
		private DevComponents.DotNetBar.ItemContainer triggerItemContainer;
		private DevComponents.DotNetBar.ButtonItem alterTrigger;
		private DevComponents.DotNetBar.ButtonItem dropTrigger;
		private DevComponents.DotNetBar.ItemContainer eventItemContainer;
		private DevComponents.DotNetBar.ButtonItem alterEvent;
		private DevComponents.DotNetBar.ButtonItem dropEvent;
		private DevComponents.DotNetBar.RibbonPanel toolPanel;
		private DevComponents.DotNetBar.RibbonBar openBar;
		private DevComponents.DotNetBar.RibbonTabItem toolTab;
		private DevComponents.DotNetBar.ButtonItem openObject;
		private DevComponents.DotNetBar.RibbonBar externalBar;
		private DevComponents.DotNetBar.RibbonBar bakupBar;
		private DevComponents.DotNetBar.ButtonItem backupDatabase;
		private DevComponents.DotNetBar.ButtonItem restoreDatabase;
		private DevComponents.DotNetBar.ButtonItem importExternal;
		private DevComponents.DotNetBar.ButtonItem exportExternal;
		private DevComponents.DotNetBar.Bar statusBar;
		private DevComponents.DotNetBar.ButtonItem helpGroup;
		private DevComponents.DotNetBar.ButtonItem helpDocument;
		private DevComponents.DotNetBar.ButtonItem updateCheck;
		private DevComponents.DotNetBar.ButtonItem showAbout;
		private DevComponents.DotNetBar.ButtonItem configGroup;
		private DevComponents.DotNetBar.ButtonItem appSettings;
		private DevComponents.DotNetBar.ButtonItem formTheme;
		private DevComponents.DotNetBar.ButtonItem aeroSilver;
		private DevComponents.DotNetBar.ButtonItem aeroBlue;
		private DevComponents.DotNetBar.ButtonItem officeBlue;
		private DevComponents.DotNetBar.ButtonItem officeBlack;
		private DevComponents.DotNetBar.ButtonItem officeSilver;
		private DevComponents.DotNetBar.ButtonItem officeNavy;
		private DevComponents.DotNetBar.ButtonItem qatButton;
		private DevComponents.DotNetBar.ColorPickerDropDown customColor;
		private DevComponents.DotNetBar.Command AppCommandTheme;
	}
}