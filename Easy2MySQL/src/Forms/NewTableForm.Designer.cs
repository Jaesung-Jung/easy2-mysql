namespace Easy2.Forms
{
	partial class NewTableForm
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
			this.m_tableNameLabel = new DevComponents.DotNetBar.LabelX();
			this.m_tableNameText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.m_commitButton = new DevComponents.DotNetBar.ButtonX();
			this.m_imgLabel = new DevComponents.DotNetBar.LabelX();
			this.SuspendLayout();
			// 
			// m_tableNameLabel
			// 
			this.m_tableNameLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_tableNameLabel.BackgroundStyle.Class = "";
			this.m_tableNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_tableNameLabel.Location = new System.Drawing.Point(57, 6);
			this.m_tableNameLabel.Name = "m_tableNameLabel";
			this.m_tableNameLabel.Size = new System.Drawing.Size(108, 21);
			this.m_tableNameLabel.TabIndex = 0;
			this.m_tableNameLabel.Text = "테이블 이름(&N)";
			// 
			// m_tableNameText
			// 
			// 
			// 
			// 
			this.m_tableNameText.Border.Class = "TextBoxBorder";
			this.m_tableNameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_tableNameText.Location = new System.Drawing.Point(57, 33);
			this.m_tableNameText.Name = "m_tableNameText";
			this.m_tableNameText.Size = new System.Drawing.Size(234, 25);
			this.m_tableNameText.TabIndex = 1;
			this.m_tableNameText.Text = "NewTable";
			this.m_tableNameText.TextChanged += new System.EventHandler(this.OnTableNameTextChanged);
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_closeButton.Location = new System.Drawing.Point(199, 66);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(92, 23);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 6;
			this.m_closeButton.Text = "닫기(&L)";
			// 
			// m_commitButton
			// 
			this.m_commitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_commitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_commitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_commitButton.Location = new System.Drawing.Point(101, 66);
			this.m_commitButton.Name = "m_commitButton";
			this.m_commitButton.Size = new System.Drawing.Size(92, 23);
			this.m_commitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_commitButton.TabIndex = 5;
			this.m_commitButton.Text = "확인(&O)";
			// 
			// m_imgLabel
			// 
			// 
			// 
			// 
			this.m_imgLabel.BackgroundStyle.Class = "";
			this.m_imgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_imgLabel.Image = global::Easy2.Properties.Resources.CreateTable;
			this.m_imgLabel.Location = new System.Drawing.Point(3, 8);
			this.m_imgLabel.Name = "m_imgLabel";
			this.m_imgLabel.Size = new System.Drawing.Size(48, 48);
			this.m_imgLabel.TabIndex = 7;
			// 
			// NewTableForm
			// 
			this.AcceptButton = this.m_commitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_closeButton;
			this.ClientSize = new System.Drawing.Size(296, 97);
			this.Controls.Add(this.m_imgLabel);
			this.Controls.Add(this.m_closeButton);
			this.Controls.Add(this.m_commitButton);
			this.Controls.Add(this.m_tableNameText);
			this.Controls.Add(this.m_tableNameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewTableForm";
			this.ShowIcon = false;
			this.Text = "새로운 테이블";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_tableNameLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_tableNameText;
		private DevComponents.DotNetBar.ButtonX m_closeButton;
		private DevComponents.DotNetBar.ButtonX m_commitButton;
		private DevComponents.DotNetBar.LabelX m_imgLabel;
	}
}