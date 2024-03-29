﻿namespace Easy2.Forms
{
	partial class ErrorMessageForm
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
			this.m_errorMessageText = new Easy2.Components.ReadonlyTextBox();
			this.m_subjectLabel = new DevComponents.DotNetBar.LabelX();
			this.m_errorNumberLabel = new DevComponents.DotNetBar.LabelX();
			this.m_imgLabel = new DevComponents.DotNetBar.LabelX();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.m_copyButton = new DevComponents.DotNetBar.ButtonX();
			this.SuspendLayout();
			// 
			// m_errorMessageText
			// 
			this.m_errorMessageText.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.m_errorMessageText.Location = new System.Drawing.Point(12, 73);
			this.m_errorMessageText.Multiline = true;
			this.m_errorMessageText.Name = "m_errorMessageText";
			this.m_errorMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.m_errorMessageText.Size = new System.Drawing.Size(434, 117);
			this.m_errorMessageText.TabIndex = 2;
			// 
			// m_subjectLabel
			// 
			this.m_subjectLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_subjectLabel.BackgroundStyle.Class = "";
			this.m_subjectLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_subjectLabel.Location = new System.Drawing.Point(75, 29);
			this.m_subjectLabel.Name = "m_subjectLabel";
			this.m_subjectLabel.Size = new System.Drawing.Size(148, 21);
			this.m_subjectLabel.TabIndex = 3;
			this.m_subjectLabel.Text = "오류가 발생하였습니다.";
			// 
			// m_errorNumberLabel
			// 
			// 
			// 
			// 
			this.m_errorNumberLabel.BackgroundStyle.Class = "";
			this.m_errorNumberLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_errorNumberLabel.Location = new System.Drawing.Point(229, 51);
			this.m_errorNumberLabel.Name = "m_errorNumberLabel";
			this.m_errorNumberLabel.Size = new System.Drawing.Size(215, 19);
			this.m_errorNumberLabel.TabIndex = 4;
			this.m_errorNumberLabel.TextAlignment = System.Drawing.StringAlignment.Far;
			// 
			// m_imgLabel
			// 
			// 
			// 
			// 
			this.m_imgLabel.BackgroundStyle.Class = "";
			this.m_imgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_imgLabel.Image = global::Easy2.Properties.Resources.Error;
			this.m_imgLabel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
			this.m_imgLabel.Location = new System.Drawing.Point(12, 9);
			this.m_imgLabel.Name = "m_imgLabel";
			this.m_imgLabel.Size = new System.Drawing.Size(57, 55);
			this.m_imgLabel.TabIndex = 5;
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_closeButton.Location = new System.Drawing.Point(362, 196);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(84, 26);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 6;
			this.m_closeButton.Text = "닫기";
			this.m_closeButton.Click += new System.EventHandler(this.OnCloseButtonClick);
			// 
			// m_copyButton
			// 
			this.m_copyButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_copyButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_copyButton.Location = new System.Drawing.Point(272, 196);
			this.m_copyButton.Name = "m_copyButton";
			this.m_copyButton.Size = new System.Drawing.Size(84, 26);
			this.m_copyButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_copyButton.TabIndex = 7;
			this.m_copyButton.Text = "복사하기(&C)";
			this.m_copyButton.Click += new System.EventHandler(this.OnCopyButtonClick);
			// 
			// ErrorMessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_closeButton;
			this.ClientSize = new System.Drawing.Size(458, 235);
			this.Controls.Add(this.m_copyButton);
			this.Controls.Add(this.m_closeButton);
			this.Controls.Add(this.m_imgLabel);
			this.Controls.Add(this.m_errorMessageText);
			this.Controls.Add(this.m_subjectLabel);
			this.Controls.Add(this.m_errorNumberLabel);
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.Name = "ErrorMessageForm";
			this.Text = "Easy To MySQL 오류";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Easy2.Components.ReadonlyTextBox m_errorMessageText;
		private DevComponents.DotNetBar.LabelX m_subjectLabel;
		private DevComponents.DotNetBar.LabelX m_errorNumberLabel;
		private DevComponents.DotNetBar.LabelX m_imgLabel;
		private DevComponents.DotNetBar.ButtonX m_closeButton;
		private DevComponents.DotNetBar.ButtonX m_copyButton;
	}
}