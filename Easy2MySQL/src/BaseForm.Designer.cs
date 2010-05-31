namespace Easy2
{
	partial class BaseForm
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
			this.m_ribbonControl = new DevComponents.DotNetBar.RibbonControl();
			this.SuspendLayout();
			// 
			// m_ribbonControl
			// 
			// 
			// 
			// 
			this.m_ribbonControl.BackgroundStyle.Class = "";
			this.m_ribbonControl.CaptionVisible = true;
			this.m_ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
			this.m_ribbonControl.Location = new System.Drawing.Point(4, 1);
			this.m_ribbonControl.Name = "m_ribbonControl";
			this.m_ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.m_ribbonControl.Size = new System.Drawing.Size(476, 27);
			this.m_ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_ribbonControl.TabGroupHeight = 14;
			this.m_ribbonControl.TabIndex = 0;
			this.m_ribbonControl.Text = "ribbonControl";
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 359);
			this.Controls.Add(this.m_ribbonControl);
			this.Name = "BaseForm";
			this.Text = "BaseForm";
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.RibbonControl m_ribbonControl;
	}
}