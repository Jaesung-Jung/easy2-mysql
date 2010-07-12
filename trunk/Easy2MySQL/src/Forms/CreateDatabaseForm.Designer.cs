namespace Easy2
{
	partial class CreateDatabaseForm
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
			this.labelX3 = new DevComponents.DotNetBar.LabelX();
			this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.SuspendLayout();
			// 
			// labelX3
			// 
			// 
			// 
			// 
			this.labelX3.BackgroundStyle.Class = "";
			this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX3.Image = global::Easy2.Properties.Resources.CreateDatabase;
			this.labelX3.Location = new System.Drawing.Point(4, 4);
			this.labelX3.Name = "labelX3";
			this.labelX3.Size = new System.Drawing.Size(48, 48);
			this.labelX3.TabIndex = 10;
			// 
			// reflectionLabel1
			// 
			// 
			// 
			// 
			this.reflectionLabel1.BackgroundStyle.Class = "";
			this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.reflectionLabel1.Location = new System.Drawing.Point(63, 4);
			this.reflectionLabel1.Name = "reflectionLabel1";
			this.reflectionLabel1.Size = new System.Drawing.Size(296, 50);
			this.reflectionLabel1.TabIndex = 11;
			this.reflectionLabel1.Text = "<b><font size=\"+6\"><font color=\"#015A84\">My</font><font color=\"#E97B00\">SQL</font" +
				"><font color=\"#000000\"> 데이터베이스 만들기</font></font></b>";
			// 
			// CreateDatabaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 232);
			this.Controls.Add(this.labelX3);
			this.Controls.Add(this.reflectionLabel1);
			this.DoubleBuffered = true;
			this.Name = "CreateDatabaseForm";
			this.Text = "CreateDatabaseForm";
			this.Controls.SetChildIndex(this.reflectionLabel1, 0);
			this.Controls.SetChildIndex(this.labelX3, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.LabelX labelX3;
		private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
	}
}