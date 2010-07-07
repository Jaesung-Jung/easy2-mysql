namespace Easy2
{
	partial class NewConnectForm
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
			this.m_imgLabel = new DevComponents.DotNetBar.LabelX();
			this.m_connectNameLabel = new DevComponents.DotNetBar.LabelX();
			this.m_connectNameText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_commitButton = new DevComponents.DotNetBar.ButtonX();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.SuspendLayout();
			// 
			// m_imgLabel
			// 
			// 
			// 
			// 
			this.m_imgLabel.BackgroundStyle.Class = "";
			this.m_imgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_imgLabel.Image = global::Easy2.Properties.Resources.ConnectDatabaseL;
			this.m_imgLabel.Location = new System.Drawing.Point(2, 16);
			this.m_imgLabel.Name = "m_imgLabel";
			this.m_imgLabel.Size = new System.Drawing.Size(64, 64);
			this.m_imgLabel.TabIndex = 0;
			// 
			// m_connectNameLabel
			// 
			this.m_connectNameLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_connectNameLabel.BackgroundStyle.Class = "";
			this.m_connectNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_connectNameLabel.Location = new System.Drawing.Point(72, 12);
			this.m_connectNameLabel.Name = "m_connectNameLabel";
			this.m_connectNameLabel.Size = new System.Drawing.Size(90, 21);
			this.m_connectNameLabel.TabIndex = 1;
			this.m_connectNameLabel.Text = "연결이름(&N)";
			// 
			// m_connectNameText
			// 
			// 
			// 
			// 
			this.m_connectNameText.Border.Class = "TextBoxBorder";
			this.m_connectNameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_connectNameText.Location = new System.Drawing.Point(72, 39);
			this.m_connectNameText.MaxLength = 20;
			this.m_connectNameText.Name = "m_connectNameText";
			this.m_connectNameText.Size = new System.Drawing.Size(188, 25);
			this.m_connectNameText.TabIndex = 2;
			this.m_connectNameText.Text = "New Connection";
			this.m_connectNameText.TextChanged += new System.EventHandler(this.OnConnectNameTextChanged);
			// 
			// m_commitButton
			// 
			this.m_commitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_commitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_commitButton.Location = new System.Drawing.Point(72, 70);
			this.m_commitButton.Name = "m_commitButton";
			this.m_commitButton.Size = new System.Drawing.Size(92, 23);
			this.m_commitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_commitButton.TabIndex = 3;
			this.m_commitButton.Text = "확인(&O)";
			this.m_commitButton.Click += new System.EventHandler(this.OnCommitButtonClick);
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.Location = new System.Drawing.Point(168, 70);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(92, 23);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 4;
			this.m_closeButton.Text = "닫기(&L)";
			this.m_closeButton.Click += new System.EventHandler(this.OnCloseButtonClick);
			// 
			// NewConnectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 106);
			this.Controls.Add(this.m_closeButton);
			this.Controls.Add(this.m_commitButton);
			this.Controls.Add(this.m_connectNameText);
			this.Controls.Add(this.m_connectNameLabel);
			this.Controls.Add(this.m_imgLabel);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewConnectForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "새 연결";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_connectNameLabel;
		private DevComponents.DotNetBar.ButtonX m_commitButton;
		private DevComponents.DotNetBar.ButtonX m_closeButton;
		protected DevComponents.DotNetBar.Controls.TextBoxX m_connectNameText;
		protected DevComponents.DotNetBar.LabelX m_imgLabel;
	}
}