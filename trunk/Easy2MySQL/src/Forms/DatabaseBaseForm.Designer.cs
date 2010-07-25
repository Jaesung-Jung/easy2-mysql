namespace Easy2.Forms
{
	partial class DatabaseBaseForm
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
			this.m_nameLabel = new DevComponents.DotNetBar.LabelX();
			this.m_nameText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.labelX1 = new DevComponents.DotNetBar.LabelX();
			this.m_charsetCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.labelX2 = new DevComponents.DotNetBar.LabelX();
			this.m_collationCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_commitButton = new DevComponents.DotNetBar.ButtonX();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.m_descriptionLabel = new DevComponents.DotNetBar.LabelX();
			this.SuspendLayout();
			// 
			// m_nameLabel
			// 
			// 
			// 
			// 
			this.m_nameLabel.BackgroundStyle.Class = "";
			this.m_nameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_nameLabel.Location = new System.Drawing.Point(12, 62);
			this.m_nameLabel.Name = "m_nameLabel";
			this.m_nameLabel.Size = new System.Drawing.Size(151, 20);
			this.m_nameLabel.TabIndex = 0;
			this.m_nameLabel.Text = "데이터베이스 이름(&N)";
			// 
			// m_nameText
			// 
			// 
			// 
			// 
			this.m_nameText.Border.Class = "TextBoxBorder";
			this.m_nameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_nameText.Location = new System.Drawing.Point(167, 59);
			this.m_nameText.Name = "m_nameText";
			this.m_nameText.Size = new System.Drawing.Size(188, 25);
			this.m_nameText.TabIndex = 1;
			this.m_nameText.TextChanged += new System.EventHandler(this.OnTextChanged);
			// 
			// labelX1
			// 
			// 
			// 
			// 
			this.labelX1.BackgroundStyle.Class = "";
			this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Location = new System.Drawing.Point(12, 93);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new System.Drawing.Size(151, 20);
			this.labelX1.TabIndex = 2;
			this.labelX1.Text = "데이터베이스 문자셋(&S)";
			// 
			// m_charsetCombo
			// 
			this.m_charsetCombo.DisplayMember = "Text";
			this.m_charsetCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_charsetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_charsetCombo.FormattingEnabled = true;
			this.m_charsetCombo.ItemHeight = 19;
			this.m_charsetCombo.Location = new System.Drawing.Point(167, 91);
			this.m_charsetCombo.Name = "m_charsetCombo";
			this.m_charsetCombo.Size = new System.Drawing.Size(188, 25);
			this.m_charsetCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_charsetCombo.TabIndex = 3;
			this.m_charsetCombo.SelectedIndexChanged += new System.EventHandler(this.OnCharsetComboSelectedIndexChanged);
			// 
			// labelX2
			// 
			// 
			// 
			// 
			this.labelX2.BackgroundStyle.Class = "";
			this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX2.Location = new System.Drawing.Point(12, 125);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new System.Drawing.Size(151, 21);
			this.labelX2.TabIndex = 4;
			this.labelX2.Text = "문자셋 콜레이션(&O)";
			// 
			// m_collationCombo
			// 
			this.m_collationCombo.DisplayMember = "Text";
			this.m_collationCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_collationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_collationCombo.FormattingEnabled = true;
			this.m_collationCombo.ItemHeight = 19;
			this.m_collationCombo.Location = new System.Drawing.Point(167, 123);
			this.m_collationCombo.Name = "m_collationCombo";
			this.m_collationCombo.Size = new System.Drawing.Size(188, 25);
			this.m_collationCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_collationCombo.TabIndex = 5;
			// 
			// m_commitButton
			// 
			this.m_commitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_commitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_commitButton.Enabled = false;
			this.m_commitButton.Location = new System.Drawing.Point(117, 189);
			this.m_commitButton.Name = "m_commitButton";
			this.m_commitButton.Size = new System.Drawing.Size(116, 25);
			this.m_commitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_commitButton.TabIndex = 7;
			this.m_commitButton.Text = "확인(&C)";
			this.m_commitButton.Click += new System.EventHandler(this.OnCommitButtonClick);
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_closeButton.Location = new System.Drawing.Point(239, 189);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(116, 25);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 8;
			this.m_closeButton.Text = "닫기(&L)";
			this.m_closeButton.Click += new System.EventHandler(this.OnCloseButtonClick);
			// 
			// m_descriptionLabel
			// 
			// 
			// 
			// 
			this.m_descriptionLabel.BackgroundStyle.Class = "";
			this.m_descriptionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_descriptionLabel.Location = new System.Drawing.Point(12, 157);
			this.m_descriptionLabel.Name = "m_descriptionLabel";
			this.m_descriptionLabel.Size = new System.Drawing.Size(343, 23);
			this.m_descriptionLabel.TabIndex = 9;
			this.m_descriptionLabel.TextAlignment = System.Drawing.StringAlignment.Far;
			// 
			// DatabaseBaseForm
			// 
			this.AcceptButton = this.m_commitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_closeButton;
			this.ClientSize = new System.Drawing.Size(371, 232);
			this.Controls.Add(this.m_descriptionLabel);
			this.Controls.Add(this.m_closeButton);
			this.Controls.Add(this.m_commitButton);
			this.Controls.Add(this.m_collationCombo);
			this.Controls.Add(this.labelX2);
			this.Controls.Add(this.m_charsetCombo);
			this.Controls.Add(this.labelX1);
			this.Controls.Add(this.m_nameText);
			this.Controls.Add(this.m_nameLabel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DatabaseBaseForm";
			this.Text = "DatabaseBaseForm";
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_nameLabel;
		private DevComponents.DotNetBar.LabelX labelX1;
		private DevComponents.DotNetBar.LabelX labelX2;
		private DevComponents.DotNetBar.ButtonX m_commitButton;
		private DevComponents.DotNetBar.ButtonX m_closeButton;
		private DevComponents.DotNetBar.LabelX m_descriptionLabel;
		protected DevComponents.DotNetBar.Controls.TextBoxX m_nameText;
		protected DevComponents.DotNetBar.Controls.ComboBoxEx m_charsetCombo;
		protected DevComponents.DotNetBar.Controls.ComboBoxEx m_collationCombo;
	}
}