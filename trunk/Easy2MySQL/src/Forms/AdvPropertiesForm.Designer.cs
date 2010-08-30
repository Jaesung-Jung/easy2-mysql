namespace Easy2.Forms
{
	partial class AdvPropertiesForm
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
			this.m_engineLabel = new DevComponents.DotNetBar.LabelX();
			this.m_engineCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_checksumLabel = new DevComponents.DotNetBar.LabelX();
			this.m_checksumCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_charsetLabel = new DevComponents.DotNetBar.LabelX();
			this.m_charsetCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_collationLabel = new DevComponents.DotNetBar.LabelX();
			this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_commentLabel = new DevComponents.DotNetBar.LabelX();
			this.m_commentText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_groupBox = new System.Windows.Forms.GroupBox();
			this.m_autoincrLabel = new DevComponents.DotNetBar.LabelX();
			this.m_autoincrText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_avgrowLabel = new DevComponents.DotNetBar.LabelX();
			this.m_avgrowText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_minimumLabel = new DevComponents.DotNetBar.LabelX();
			this.m_minimumText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_maximumLabel = new DevComponents.DotNetBar.LabelX();
			this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_engineLabel
			// 
			// 
			// 
			// 
			this.m_engineLabel.BackgroundStyle.Class = "";
			this.m_engineLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_engineLabel.Location = new System.Drawing.Point(12, 12);
			this.m_engineLabel.Name = "m_engineLabel";
			this.m_engineLabel.Size = new System.Drawing.Size(95, 21);
			this.m_engineLabel.TabIndex = 0;
			this.m_engineLabel.Text = "테이블 엔진(&E)";
			// 
			// m_engineCombo
			// 
			this.m_engineCombo.DisplayMember = "Text";
			this.m_engineCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_engineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_engineCombo.FormattingEnabled = true;
			this.m_engineCombo.ItemHeight = 19;
			this.m_engineCombo.Location = new System.Drawing.Point(113, 11);
			this.m_engineCombo.Name = "m_engineCombo";
			this.m_engineCombo.Size = new System.Drawing.Size(145, 25);
			this.m_engineCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_engineCombo.TabIndex = 1;
			// 
			// m_checksumLabel
			// 
			// 
			// 
			// 
			this.m_checksumLabel.BackgroundStyle.Class = "";
			this.m_checksumLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_checksumLabel.Location = new System.Drawing.Point(286, 12);
			this.m_checksumLabel.Name = "m_checksumLabel";
			this.m_checksumLabel.Size = new System.Drawing.Size(64, 21);
			this.m_checksumLabel.TabIndex = 2;
			this.m_checksumLabel.Text = "체크섬(&K)";
			// 
			// m_checksumCombo
			// 
			this.m_checksumCombo.DisplayMember = "Text";
			this.m_checksumCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_checksumCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_checksumCombo.FormattingEnabled = true;
			this.m_checksumCombo.ItemHeight = 19;
			this.m_checksumCombo.Location = new System.Drawing.Point(356, 11);
			this.m_checksumCombo.Name = "m_checksumCombo";
			this.m_checksumCombo.Size = new System.Drawing.Size(84, 25);
			this.m_checksumCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_checksumCombo.TabIndex = 3;
			// 
			// m_charsetLabel
			// 
			this.m_charsetLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_charsetLabel.BackgroundStyle.Class = "";
			this.m_charsetLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_charsetLabel.Location = new System.Drawing.Point(12, 44);
			this.m_charsetLabel.Name = "m_charsetLabel";
			this.m_charsetLabel.Size = new System.Drawing.Size(75, 21);
			this.m_charsetLabel.TabIndex = 4;
			this.m_charsetLabel.Text = "문자셋(&C)";
			// 
			// m_charsetCombo
			// 
			this.m_charsetCombo.DisplayMember = "Text";
			this.m_charsetCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_charsetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_charsetCombo.FormattingEnabled = true;
			this.m_charsetCombo.ItemHeight = 19;
			this.m_charsetCombo.Location = new System.Drawing.Point(82, 42);
			this.m_charsetCombo.Name = "m_charsetCombo";
			this.m_charsetCombo.Size = new System.Drawing.Size(121, 25);
			this.m_charsetCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_charsetCombo.TabIndex = 5;
			// 
			// m_collationLabel
			// 
			this.m_collationLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_collationLabel.BackgroundStyle.Class = "";
			this.m_collationLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_collationLabel.Location = new System.Drawing.Point(214, 44);
			this.m_collationLabel.Name = "m_collationLabel";
			this.m_collationLabel.Size = new System.Drawing.Size(90, 21);
			this.m_collationLabel.TabIndex = 6;
			this.m_collationLabel.Text = "콜레이션(&N)";
			// 
			// comboBoxEx1
			// 
			this.comboBoxEx1.DisplayMember = "Text";
			this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBoxEx1.FormattingEnabled = true;
			this.comboBoxEx1.ItemHeight = 19;
			this.comboBoxEx1.Location = new System.Drawing.Point(299, 42);
			this.comboBoxEx1.Name = "comboBoxEx1";
			this.comboBoxEx1.Size = new System.Drawing.Size(141, 25);
			this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.comboBoxEx1.TabIndex = 7;
			// 
			// m_commentLabel
			// 
			this.m_commentLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_commentLabel.BackgroundStyle.Class = "";
			this.m_commentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_commentLabel.Location = new System.Drawing.Point(12, 75);
			this.m_commentLabel.Name = "m_commentLabel";
			this.m_commentLabel.Size = new System.Drawing.Size(78, 21);
			this.m_commentLabel.TabIndex = 8;
			this.m_commentLabel.Text = "코멘트(&M)";
			// 
			// m_commentText
			// 
			// 
			// 
			// 
			this.m_commentText.Border.Class = "TextBoxBorder";
			this.m_commentText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_commentText.Location = new System.Drawing.Point(82, 73);
			this.m_commentText.Name = "m_commentText";
			this.m_commentText.Size = new System.Drawing.Size(358, 25);
			this.m_commentText.TabIndex = 9;
			// 
			// m_groupBox
			// 
			this.m_groupBox.Controls.Add(this.textBoxX1);
			this.m_groupBox.Controls.Add(this.m_maximumLabel);
			this.m_groupBox.Controls.Add(this.m_minimumText);
			this.m_groupBox.Controls.Add(this.m_minimumLabel);
			this.m_groupBox.Controls.Add(this.m_avgrowText);
			this.m_groupBox.Controls.Add(this.m_avgrowLabel);
			this.m_groupBox.Controls.Add(this.m_autoincrText);
			this.m_groupBox.Controls.Add(this.m_autoincrLabel);
			this.m_groupBox.Location = new System.Drawing.Point(12, 98);
			this.m_groupBox.Name = "m_groupBox";
			this.m_groupBox.Size = new System.Drawing.Size(428, 233);
			this.m_groupBox.TabIndex = 10;
			this.m_groupBox.TabStop = false;
			// 
			// m_autoincrLabel
			// 
			this.m_autoincrLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_autoincrLabel.BackgroundStyle.Class = "";
			this.m_autoincrLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_autoincrLabel.Location = new System.Drawing.Point(15, 24);
			this.m_autoincrLabel.Name = "m_autoincrLabel";
			this.m_autoincrLabel.Size = new System.Drawing.Size(102, 21);
			this.m_autoincrLabel.TabIndex = 0;
			this.m_autoincrLabel.Text = "&Auto Increment";
			// 
			// m_autoincrText
			// 
			// 
			// 
			// 
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_autoincrText.Location = new System.Drawing.Point(123, 22);
			this.m_autoincrText.Name = "m_autoincrText";
			this.m_autoincrText.Size = new System.Drawing.Size(78, 25);
			this.m_autoincrText.TabIndex = 1;
			// 
			// m_avgrowLabel
			// 
			this.m_avgrowLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_avgrowLabel.BackgroundStyle.Class = "";
			this.m_avgrowLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_avgrowLabel.Location = new System.Drawing.Point(226, 24);
			this.m_avgrowLabel.Name = "m_avgrowLabel";
			this.m_avgrowLabel.Size = new System.Drawing.Size(107, 21);
			this.m_avgrowLabel.TabIndex = 2;
			this.m_avgrowLabel.Text = "Avg &Row Length";
			// 
			// m_avgrowText
			// 
			// 
			// 
			// 
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_avgrowText.Location = new System.Drawing.Point(339, 22);
			this.m_avgrowText.Name = "m_avgrowText";
			this.m_avgrowText.Size = new System.Drawing.Size(78, 25);
			this.m_avgrowText.TabIndex = 3;
			// 
			// m_minimumLabel
			// 
			this.m_minimumLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_minimumLabel.BackgroundStyle.Class = "";
			this.m_minimumLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_minimumLabel.Location = new System.Drawing.Point(15, 55);
			this.m_minimumLabel.Name = "m_minimumLabel";
			this.m_minimumLabel.Size = new System.Drawing.Size(101, 21);
			this.m_minimumLabel.TabIndex = 4;
			this.m_minimumLabel.Text = "Min&imum Rows";
			// 
			// m_minimumText
			// 
			// 
			// 
			// 
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_minimumText.Location = new System.Drawing.Point(122, 53);
			this.m_minimumText.Name = "m_minimumText";
			this.m_minimumText.Size = new System.Drawing.Size(79, 25);
			this.m_minimumText.TabIndex = 5;
			// 
			// m_maximumLabel
			// 
			this.m_maximumLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_maximumLabel.BackgroundStyle.Class = "";
			this.m_maximumLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_maximumLabel.Location = new System.Drawing.Point(226, 55);
			this.m_maximumLabel.Name = "m_maximumLabel";
			this.m_maximumLabel.Size = new System.Drawing.Size(103, 21);
			this.m_maximumLabel.TabIndex = 6;
			this.m_maximumLabel.Text = "Ma&ximum Rows";
			// 
			// textBoxX1
			// 
			// 
			// 
			// 
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.textBoxX1.Location = new System.Drawing.Point(339, 53);
			this.textBoxX1.Name = "textBoxX1";
			this.textBoxX1.Size = new System.Drawing.Size(79, 25);
			this.textBoxX1.TabIndex = 7;
			// 
			// AdvPropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 455);
			this.Controls.Add(this.m_groupBox);
			this.Controls.Add(this.m_commentText);
			this.Controls.Add(this.m_commentLabel);
			this.Controls.Add(this.comboBoxEx1);
			this.Controls.Add(this.m_collationLabel);
			this.Controls.Add(this.m_charsetCombo);
			this.Controls.Add(this.m_charsetLabel);
			this.Controls.Add(this.m_checksumCombo);
			this.Controls.Add(this.m_checksumLabel);
			this.Controls.Add(this.m_engineCombo);
			this.Controls.Add(this.m_engineLabel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdvPropertiesForm";
			this.Text = "고급 설정";
			this.m_groupBox.ResumeLayout(false);
			this.m_groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_engineLabel;
		private DevComponents.DotNetBar.Controls.ComboBoxEx m_engineCombo;
		private DevComponents.DotNetBar.LabelX m_checksumLabel;
		private DevComponents.DotNetBar.Controls.ComboBoxEx m_checksumCombo;
		private DevComponents.DotNetBar.LabelX m_charsetLabel;
		private DevComponents.DotNetBar.Controls.ComboBoxEx m_charsetCombo;
		private DevComponents.DotNetBar.LabelX m_collationLabel;
		private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
		private DevComponents.DotNetBar.LabelX m_commentLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_commentText;
		private System.Windows.Forms.GroupBox m_groupBox;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
		private DevComponents.DotNetBar.LabelX m_maximumLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_minimumText;
		private DevComponents.DotNetBar.LabelX m_minimumLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_avgrowText;
		private DevComponents.DotNetBar.LabelX m_avgrowLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_autoincrText;
		private DevComponents.DotNetBar.LabelX m_autoincrLabel;
	}
}