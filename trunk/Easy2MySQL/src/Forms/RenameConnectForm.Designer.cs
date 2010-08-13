namespace Easy2.Forms
{
	partial class RenameConnectForm
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
			this.SuspendLayout();
			// 
			// m_connectNameText
			// 
			// 
			// 
			// 
			this.m_connectNameText.Border.Class = "TextBoxBorder";
			this.m_connectNameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_connectNameText.Text = "";
			// 
			// m_imgLabel
			// 
			// 
			// 
			// 
			this.m_imgLabel.BackgroundStyle.Class = "";
			this.m_imgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_imgLabel.Image = global::Easy2.Properties.Resources.RenameL;
			// 
			// RenameConnectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 106);
			this.DoubleBuffered = true;
			this.Name = "RenameConnectForm";
			this.Text = "연결이름 바꾸기";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
	}
}