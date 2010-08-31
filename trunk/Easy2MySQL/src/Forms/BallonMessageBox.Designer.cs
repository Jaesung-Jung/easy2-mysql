namespace Easy2.Forms
{
	partial class BallonMessageBox
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
			this.m_iconLabel = new DevComponents.DotNetBar.LabelX();
			this.m_msgLabel = new DevComponents.DotNetBar.LabelX();
			this.SuspendLayout();
			// 
			// m_iconLabel
			// 
			// 
			// 
			// 
			this.m_iconLabel.BackgroundStyle.Class = "";
			this.m_iconLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_iconLabel.Location = new System.Drawing.Point(4, 26);
			this.m_iconLabel.Name = "m_iconLabel";
			this.m_iconLabel.Size = new System.Drawing.Size(35, 35);
			this.m_iconLabel.TabIndex = 0;
			// 
			// m_msgLabel
			// 
			this.m_msgLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_msgLabel.BackgroundStyle.Class = "";
			this.m_msgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_msgLabel.Location = new System.Drawing.Point(45, 32);
			this.m_msgLabel.Name = "m_msgLabel";
			this.m_msgLabel.Size = new System.Drawing.Size(0, 0);
			this.m_msgLabel.TabIndex = 1;
			this.m_msgLabel.SizeChanged += new System.EventHandler(this.OnMessageSizeChanged);
			// 
			// BallonMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(60, 70);
			this.Controls.Add(this.m_msgLabel);
			this.Controls.Add(this.m_iconLabel);
			this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BallonMessageBox";
			this.ShowCloseButton = false;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_iconLabel;
		private DevComponents.DotNetBar.LabelX m_msgLabel;
	}
}