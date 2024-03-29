﻿namespace Easy2.Forms
{
	partial class ManagePrivilegesUserForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.m_titleImgLabel = new DevComponents.DotNetBar.LabelX();
			this.m_titleLabel = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.m_userListLabel = new DevComponents.DotNetBar.LabelX();
			this.m_userListCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_tabControl = new System.Windows.Forms.TabControl();
			this.m_tablePage = new System.Windows.Forms.TabPage();
			this.m_tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.m_tablePrivGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.m_columnPrivGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.m_routinePage = new System.Windows.Forms.TabPage();
			this.m_tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.m_routinePrivGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.m_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.m_applyButton = new DevComponents.DotNetBar.ButtonX();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.m_databasePrivGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.Db = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Table_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Routine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Routine_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_tabControl.SuspendLayout();
			this.m_tablePage.SuspendLayout();
			this.m_tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_tablePrivGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_columnPrivGrid)).BeginInit();
			this.m_routinePage.SuspendLayout();
			this.m_tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_routinePrivGrid)).BeginInit();
			this.m_tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_databasePrivGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// m_titleImgLabel
			// 
			// 
			// 
			// 
			this.m_titleImgLabel.BackgroundStyle.Class = "";
			this.m_titleImgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleImgLabel.Image = global::Easy2.Properties.Resources.PrivilegeUser;
			this.m_titleImgLabel.Location = new System.Drawing.Point(4, 4);
			this.m_titleImgLabel.Name = "m_titleImgLabel";
			this.m_titleImgLabel.Size = new System.Drawing.Size(48, 48);
			this.m_titleImgLabel.TabIndex = 0;
			// 
			// m_titleLabel
			// 
			// 
			// 
			// 
			this.m_titleLabel.BackgroundStyle.Class = "";
			this.m_titleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleLabel.Location = new System.Drawing.Point(63, 4);
			this.m_titleLabel.Name = "m_titleLabel";
			this.m_titleLabel.Size = new System.Drawing.Size(297, 50);
			this.m_titleLabel.TabIndex = 1;
			this.m_titleLabel.Text = "<b><font size=\"+6\"><font color=\"#015A84\">My</font><font color=\"#E97B00\">SQL</font" +
				"><font color=\"#000000\"> 사용자 권한 설정하기</font></font></b>";
			// 
			// m_userListLabel
			// 
			// 
			// 
			// 
			this.m_userListLabel.BackgroundStyle.Class = "";
			this.m_userListLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_userListLabel.Location = new System.Drawing.Point(4, 60);
			this.m_userListLabel.Name = "m_userListLabel";
			this.m_userListLabel.Size = new System.Drawing.Size(75, 23);
			this.m_userListLabel.TabIndex = 2;
			this.m_userListLabel.Text = "사용자";
			// 
			// m_userListCombo
			// 
			this.m_userListCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_userListCombo.DisplayMember = "Text";
			this.m_userListCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_userListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_userListCombo.FormattingEnabled = true;
			this.m_userListCombo.ItemHeight = 19;
			this.m_userListCombo.Location = new System.Drawing.Point(56, 58);
			this.m_userListCombo.Name = "m_userListCombo";
			this.m_userListCombo.Size = new System.Drawing.Size(304, 25);
			this.m_userListCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_userListCombo.TabIndex = 3;
			this.m_userListCombo.SelectedIndexChanged += new System.EventHandler(this.OnUserListComboSelectedIndexChanged);
			// 
			// m_tabControl
			// 
			this.m_tabControl.Controls.Add(this.m_tablePage);
			this.m_tabControl.Controls.Add(this.m_routinePage);
			this.m_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tabControl.Location = new System.Drawing.Point(3, 107);
			this.m_tabControl.Name = "m_tabControl";
			this.m_tabControl.SelectedIndex = 0;
			this.m_tabControl.Size = new System.Drawing.Size(434, 232);
			this.m_tabControl.TabIndex = 10;
			// 
			// m_tablePage
			// 
			this.m_tablePage.Controls.Add(this.m_tableLayoutPanel2);
			this.m_tablePage.Location = new System.Drawing.Point(4, 26);
			this.m_tablePage.Name = "m_tablePage";
			this.m_tablePage.Padding = new System.Windows.Forms.Padding(3);
			this.m_tablePage.Size = new System.Drawing.Size(426, 202);
			this.m_tablePage.TabIndex = 0;
			this.m_tablePage.Text = "테이블/뷰";
			this.m_tablePage.UseVisualStyleBackColor = true;
			// 
			// m_tableLayoutPanel2
			// 
			this.m_tableLayoutPanel2.ColumnCount = 1;
			this.m_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.m_tableLayoutPanel2.Controls.Add(this.m_tablePrivGrid, 0, 0);
			this.m_tableLayoutPanel2.Controls.Add(this.m_columnPrivGrid, 0, 1);
			this.m_tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.m_tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.m_tableLayoutPanel2.Name = "m_tableLayoutPanel2";
			this.m_tableLayoutPanel2.RowCount = 2;
			this.m_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.m_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.m_tableLayoutPanel2.Size = new System.Drawing.Size(420, 196);
			this.m_tableLayoutPanel2.TabIndex = 0;
			// 
			// m_tablePrivGrid
			// 
			this.m_tablePrivGrid.AllowUserToAddRows = false;
			this.m_tablePrivGrid.AllowUserToDeleteRows = false;
			this.m_tablePrivGrid.AllowUserToResizeColumns = false;
			this.m_tablePrivGrid.AllowUserToResizeRows = false;
			this.m_tablePrivGrid.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_tablePrivGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.m_tablePrivGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_tablePrivGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_name});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.m_tablePrivGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.m_tablePrivGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tablePrivGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.m_tablePrivGrid.Location = new System.Drawing.Point(3, 3);
			this.m_tablePrivGrid.MultiSelect = false;
			this.m_tablePrivGrid.Name = "m_tablePrivGrid";
			this.m_tablePrivGrid.RowHeadersVisible = false;
			this.m_tablePrivGrid.RowTemplate.Height = 23;
			this.m_tablePrivGrid.Size = new System.Drawing.Size(414, 92);
			this.m_tablePrivGrid.TabIndex = 0;
			this.m_tablePrivGrid.SelectionChanged += new System.EventHandler(this.OnTablePrivGridSelectionChanged);
			// 
			// m_columnPrivGrid
			// 
			this.m_columnPrivGrid.AllowUserToAddRows = false;
			this.m_columnPrivGrid.AllowUserToDeleteRows = false;
			this.m_columnPrivGrid.AllowUserToResizeColumns = false;
			this.m_columnPrivGrid.AllowUserToResizeRows = false;
			this.m_columnPrivGrid.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_columnPrivGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.m_columnPrivGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_columnPrivGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.m_columnPrivGrid.DefaultCellStyle = dataGridViewCellStyle4;
			this.m_columnPrivGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_columnPrivGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.m_columnPrivGrid.Location = new System.Drawing.Point(3, 101);
			this.m_columnPrivGrid.MultiSelect = false;
			this.m_columnPrivGrid.Name = "m_columnPrivGrid";
			this.m_columnPrivGrid.RowHeadersVisible = false;
			this.m_columnPrivGrid.RowTemplate.Height = 23;
			this.m_columnPrivGrid.Size = new System.Drawing.Size(414, 92);
			this.m_columnPrivGrid.TabIndex = 1;
			// 
			// m_routinePage
			// 
			this.m_routinePage.Controls.Add(this.m_tableLayoutPanel3);
			this.m_routinePage.Location = new System.Drawing.Point(4, 26);
			this.m_routinePage.Name = "m_routinePage";
			this.m_routinePage.Padding = new System.Windows.Forms.Padding(3);
			this.m_routinePage.Size = new System.Drawing.Size(426, 202);
			this.m_routinePage.TabIndex = 1;
			this.m_routinePage.Text = "프로시저/함수";
			this.m_routinePage.UseVisualStyleBackColor = true;
			// 
			// m_tableLayoutPanel3
			// 
			this.m_tableLayoutPanel3.ColumnCount = 1;
			this.m_tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.m_tableLayoutPanel3.Controls.Add(this.m_routinePrivGrid, 0, 0);
			this.m_tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.m_tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.m_tableLayoutPanel3.Name = "m_tableLayoutPanel3";
			this.m_tableLayoutPanel3.RowCount = 1;
			this.m_tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.m_tableLayoutPanel3.Size = new System.Drawing.Size(420, 196);
			this.m_tableLayoutPanel3.TabIndex = 0;
			// 
			// m_routinePrivGrid
			// 
			this.m_routinePrivGrid.AllowUserToAddRows = false;
			this.m_routinePrivGrid.AllowUserToDeleteRows = false;
			this.m_routinePrivGrid.AllowUserToResizeColumns = false;
			this.m_routinePrivGrid.AllowUserToResizeRows = false;
			this.m_routinePrivGrid.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_routinePrivGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.m_routinePrivGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_routinePrivGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Routine_name,
            this.Routine_type});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.m_routinePrivGrid.DefaultCellStyle = dataGridViewCellStyle6;
			this.m_routinePrivGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_routinePrivGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.m_routinePrivGrid.Location = new System.Drawing.Point(3, 3);
			this.m_routinePrivGrid.MultiSelect = false;
			this.m_routinePrivGrid.Name = "m_routinePrivGrid";
			this.m_routinePrivGrid.RowHeadersVisible = false;
			this.m_routinePrivGrid.RowTemplate.Height = 23;
			this.m_routinePrivGrid.Size = new System.Drawing.Size(414, 190);
			this.m_routinePrivGrid.TabIndex = 8;
			// 
			// m_tableLayoutPanel1
			// 
			this.m_tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_tableLayoutPanel1.ColumnCount = 1;
			this.m_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tableLayoutPanel1.Controls.Add(this.tableLayoutPanel1, 0, 2);
			this.m_tableLayoutPanel1.Controls.Add(this.m_databasePrivGrid, 0, 0);
			this.m_tableLayoutPanel1.Controls.Add(this.m_tabControl, 0, 1);
			this.m_tableLayoutPanel1.Location = new System.Drawing.Point(4, 89);
			this.m_tableLayoutPanel1.Name = "m_tableLayoutPanel1";
			this.m_tableLayoutPanel1.RowCount = 3;
			this.m_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.33F));
			this.m_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.67F));
			this.m_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.m_tableLayoutPanel1.Size = new System.Drawing.Size(440, 383);
			this.m_tableLayoutPanel1.TabIndex = 7;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
			this.tableLayoutPanel1.Controls.Add(this.m_applyButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.m_closeButton, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 345);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 35);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// m_applyButton
			// 
			this.m_applyButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.m_applyButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_applyButton.Location = new System.Drawing.Point(177, 7);
			this.m_applyButton.Name = "m_applyButton";
			this.m_applyButton.Size = new System.Drawing.Size(116, 25);
			this.m_applyButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_applyButton.TabIndex = 8;
			this.m_applyButton.Text = "적용(&A)";
			this.m_applyButton.Click += new System.EventHandler(this.OnApplyButtonClick);
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.Location = new System.Drawing.Point(315, 7);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(116, 25);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 9;
			this.m_closeButton.Text = "닫기(&C)";
			this.m_closeButton.Click += new System.EventHandler(this.OnCloseButtonClick);
			// 
			// m_databasePrivGrid
			// 
			this.m_databasePrivGrid.AllowUserToAddRows = false;
			this.m_databasePrivGrid.AllowUserToDeleteRows = false;
			this.m_databasePrivGrid.AllowUserToResizeColumns = false;
			this.m_databasePrivGrid.AllowUserToResizeRows = false;
			this.m_databasePrivGrid.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_databasePrivGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.m_databasePrivGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_databasePrivGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Db});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.m_databasePrivGrid.DefaultCellStyle = dataGridViewCellStyle8;
			this.m_databasePrivGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_databasePrivGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.m_databasePrivGrid.Location = new System.Drawing.Point(3, 3);
			this.m_databasePrivGrid.MultiSelect = false;
			this.m_databasePrivGrid.Name = "m_databasePrivGrid";
			this.m_databasePrivGrid.RowHeadersVisible = false;
			this.m_databasePrivGrid.RowTemplate.Height = 23;
			this.m_databasePrivGrid.Size = new System.Drawing.Size(434, 98);
			this.m_databasePrivGrid.TabIndex = 12;
			this.m_databasePrivGrid.SelectionChanged += new System.EventHandler(this.OnDatabasePrivGridSelectionChanged);
			// 
			// Db
			// 
			this.Db.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Db.HeaderText = "Database";
			this.Db.Name = "Db";
			this.Db.ReadOnly = true;
			this.Db.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Db.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Db.Width = 69;
			// 
			// Table_name
			// 
			this.Table_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Table_name.HeaderText = "Table";
			this.Table_name.Name = "Table_name";
			this.Table_name.ReadOnly = true;
			this.Table_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Table_name.Width = 46;
			// 
			// Column_name
			// 
			this.Column_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_name.HeaderText = "Column";
			this.Column_name.Name = "Column_name";
			this.Column_name.ReadOnly = true;
			this.Column_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column_name.Width = 60;
			// 
			// Routine_name
			// 
			this.Routine_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Routine_name.HeaderText = "Routine";
			this.Routine_name.Name = "Routine_name";
			this.Routine_name.ReadOnly = true;
			this.Routine_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Routine_name.Width = 60;
			// 
			// Routine_type
			// 
			this.Routine_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Routine_type.HeaderText = "Routine Type";
			this.Routine_type.Name = "Routine_type";
			this.Routine_type.ReadOnly = true;
			this.Routine_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Routine_type.Width = 93;
			// 
			// ManagePrivilegesUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 476);
			this.Controls.Add(this.m_tableLayoutPanel1);
			this.Controls.Add(this.m_userListCombo);
			this.Controls.Add(this.m_userListLabel);
			this.Controls.Add(this.m_titleLabel);
			this.Controls.Add(this.m_titleImgLabel);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(464, 514);
			this.Name = "ManagePrivilegesUserForm";
			this.ShowInTaskbar = false;
			this.Text = "사용자 권한 설정하기";
			this.m_tabControl.ResumeLayout(false);
			this.m_tablePage.ResumeLayout(false);
			this.m_tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_tablePrivGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_columnPrivGrid)).EndInit();
			this.m_routinePage.ResumeLayout(false);
			this.m_tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_routinePrivGrid)).EndInit();
			this.m_tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_databasePrivGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_titleImgLabel;
		private DevComponents.DotNetBar.Controls.ReflectionLabel m_titleLabel;
		private DevComponents.DotNetBar.LabelX m_userListLabel;
		private DevComponents.DotNetBar.Controls.ComboBoxEx m_userListCombo;
		private System.Windows.Forms.TabControl m_tabControl;
		private System.Windows.Forms.TabPage m_tablePage;
		private System.Windows.Forms.TableLayoutPanel m_tableLayoutPanel2;
		private DevComponents.DotNetBar.Controls.DataGridViewX m_tablePrivGrid;
		private DevComponents.DotNetBar.Controls.DataGridViewX m_columnPrivGrid;
		private System.Windows.Forms.TabPage m_routinePage;
		private System.Windows.Forms.TableLayoutPanel m_tableLayoutPanel1;
		private DevComponents.DotNetBar.Controls.DataGridViewX m_databasePrivGrid;
		private System.Windows.Forms.TableLayoutPanel m_tableLayoutPanel3;
		private DevComponents.DotNetBar.Controls.DataGridViewX m_routinePrivGrid;
		private DevComponents.DotNetBar.ButtonX m_applyButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private DevComponents.DotNetBar.ButtonX m_closeButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Table_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Routine_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Routine_type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Db;
	}
}