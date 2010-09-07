namespace Easy2.Forms
{
	partial class TableBaseForm
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
			this.m_titleImgLabel = new DevComponents.DotNetBar.LabelX();
			this.m_titleLabel = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.m_layoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_innerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.m_deleteRowButton = new DevComponents.DotNetBar.ButtonX();
			this.m_advanceButton = new DevComponents.DotNetBar.ButtonX();
			this.m_commitButton = new DevComponents.DotNetBar.ButtonX();
			this.m_layoutPanel.SuspendLayout();
			this.m_innerLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_titleImgLabel
			// 
			// 
			// 
			// 
			this.m_titleImgLabel.BackgroundStyle.Class = "";
			this.m_titleImgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleImgLabel.Image = global::Easy2.Properties.Resources.CreateTable;
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
			this.m_titleLabel.Size = new System.Drawing.Size(393, 50);
			this.m_titleLabel.TabIndex = 1;
			// 
			// m_layoutPanel
			// 
			this.m_layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_layoutPanel.ColumnCount = 1;
			this.m_layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_layoutPanel.Controls.Add(this.m_innerLayoutPanel, 0, 1);
			this.m_layoutPanel.Location = new System.Drawing.Point(12, 60);
			this.m_layoutPanel.Name = "m_layoutPanel";
			this.m_layoutPanel.RowCount = 2;
			this.m_layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.m_layoutPanel.Size = new System.Drawing.Size(917, 446);
			this.m_layoutPanel.TabIndex = 2;
			// 
			// m_innerLayoutPanel
			// 
			this.m_innerLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_innerLayoutPanel.ColumnCount = 5;
			this.m_innerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_innerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_innerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_innerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_innerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_innerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.m_innerLayoutPanel.Controls.Add(this.m_closeButton, 3, 0);
			this.m_innerLayoutPanel.Controls.Add(this.m_deleteRowButton, 2, 0);
			this.m_innerLayoutPanel.Controls.Add(this.m_advanceButton, 1, 0);
			this.m_innerLayoutPanel.Controls.Add(this.m_commitButton, 0, 0);
			this.m_innerLayoutPanel.Location = new System.Drawing.Point(3, 409);
			this.m_innerLayoutPanel.Name = "m_innerLayoutPanel";
			this.m_innerLayoutPanel.RowCount = 1;
			this.m_innerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_innerLayoutPanel.Size = new System.Drawing.Size(911, 34);
			this.m_innerLayoutPanel.TabIndex = 2;
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.Location = new System.Drawing.Point(393, 3);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(116, 25);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 3;
			this.m_closeButton.Text = "닫기(&L)";
			this.m_closeButton.Click += new System.EventHandler(this.OnCloseButtonClick);
			// 
			// m_deleteRowButton
			// 
			this.m_deleteRowButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_deleteRowButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_deleteRowButton.Location = new System.Drawing.Point(263, 3);
			this.m_deleteRowButton.Name = "m_deleteRowButton";
			this.m_deleteRowButton.Size = new System.Drawing.Size(116, 25);
			this.m_deleteRowButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_deleteRowButton.TabIndex = 2;
			this.m_deleteRowButton.Text = "행 지우기(&D)...";
			this.m_deleteRowButton.Click += new System.EventHandler(this.OnDeleteRowButtonClick);
			// 
			// m_advanceButton
			// 
			this.m_advanceButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_advanceButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_advanceButton.Location = new System.Drawing.Point(133, 3);
			this.m_advanceButton.Name = "m_advanceButton";
			this.m_advanceButton.Size = new System.Drawing.Size(116, 25);
			this.m_advanceButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_advanceButton.TabIndex = 1;
			this.m_advanceButton.Text = "고급 설정(&A)...";
			this.m_advanceButton.Click += new System.EventHandler(this.OnAdvanceButtonClick);
			// 
			// m_commitButton
			// 
			this.m_commitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_commitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_commitButton.Location = new System.Drawing.Point(3, 3);
			this.m_commitButton.Name = "m_commitButton";
			this.m_commitButton.Size = new System.Drawing.Size(116, 25);
			this.m_commitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_commitButton.TabIndex = 0;
			this.m_commitButton.Text = "확인(&C)";
			this.m_commitButton.Click += new System.EventHandler(this.OnCommitButtonClick);
			// 
			// TableBaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 518);
			this.Controls.Add(this.m_layoutPanel);
			this.Controls.Add(this.m_titleLabel);
			this.Controls.Add(this.m_titleImgLabel);
			this.Name = "TableBaseForm";
			this.Text = "TableBaseForm";
			this.m_layoutPanel.ResumeLayout(false);
			this.m_innerLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_titleImgLabel;
		private System.Windows.Forms.TableLayoutPanel m_layoutPanel;
		private System.Windows.Forms.TableLayoutPanel m_innerLayoutPanel;
		private DevComponents.DotNetBar.ButtonX m_commitButton;
		private DevComponents.DotNetBar.ButtonX m_closeButton;
		private DevComponents.DotNetBar.ButtonX m_deleteRowButton;
		private DevComponents.DotNetBar.ButtonX m_advanceButton;
		protected DevComponents.DotNetBar.Controls.ReflectionLabel m_titleLabel;
	}
}