﻿namespace Easy2.Forms
{
	partial class AlterDatabaseForm
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
			this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.SuspendLayout();
			// 
			// m_nameText
			// 
			// 
			// 
			// 
			this.m_nameText.Border.Class = "TextBoxBorder";
			this.m_nameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_titleImgLabel
			// 
			// 
			// 
			// 
			this.m_titleImgLabel.BackgroundStyle.Class = "";
			this.m_titleImgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleImgLabel.Image = global::Easy2.Properties.Resources.CreateDatabase;
			this.m_titleImgLabel.Location = new System.Drawing.Point(4, 4);
			this.m_titleImgLabel.Name = "m_titleImgLabel";
			this.m_titleImgLabel.Size = new System.Drawing.Size(48, 48);
			this.m_titleImgLabel.TabIndex = 10;
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
				"><font color=\"#000000\"> 데이터베이스 수정하기</font></font></b>";
			// 
			// AlterDatabaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 232);
			this.Controls.Add(this.reflectionLabel1);
			this.Controls.Add(this.m_titleImgLabel);
			this.DoubleBuffered = true;
			this.Name = "AlterDatabaseForm";
			this.Text = "AlterDatabaseForm";
			this.Controls.SetChildIndex(this.m_titleImgLabel, 0);
			this.Controls.SetChildIndex(this.reflectionLabel1, 0);
			this.Controls.SetChildIndex(this.m_nameText, 0);
			this.Controls.SetChildIndex(this.m_charsetCombo, 0);
			this.Controls.SetChildIndex(this.m_collationCombo, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_titleImgLabel;
		private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
	}
}