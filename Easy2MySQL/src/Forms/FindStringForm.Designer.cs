namespace Easy2.Forms
{
	partial class FindStringForm
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
			this.m_contentLabel = new DevComponents.DotNetBar.LabelX();
			this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_findOptionGroup = new System.Windows.Forms.GroupBox();
			this.m_regularExpression = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_findUp = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_matchCase = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_findNextButton = new DevComponents.DotNetBar.ButtonX();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.m_findOptionGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_contentLabel
			// 
			this.m_contentLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_contentLabel.BackgroundStyle.Class = "";
			this.m_contentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_contentLabel.Location = new System.Drawing.Point(7, 5);
			this.m_contentLabel.Name = "m_contentLabel";
			this.m_contentLabel.Size = new System.Drawing.Size(94, 21);
			this.m_contentLabel.TabIndex = 0;
			this.m_contentLabel.Text = "찾을 내용(&N)";
			// 
			// textBoxX1
			// 
			// 
			// 
			// 
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.textBoxX1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBoxX1.Location = new System.Drawing.Point(7, 32);
			this.textBoxX1.Name = "textBoxX1";
			this.textBoxX1.Size = new System.Drawing.Size(460, 23);
			this.textBoxX1.TabIndex = 1;
			// 
			// m_findOptionGroup
			// 
			this.m_findOptionGroup.Controls.Add(this.m_regularExpression);
			this.m_findOptionGroup.Controls.Add(this.m_findUp);
			this.m_findOptionGroup.Controls.Add(this.m_matchCase);
			this.m_findOptionGroup.Location = new System.Drawing.Point(7, 63);
			this.m_findOptionGroup.Name = "m_findOptionGroup";
			this.m_findOptionGroup.Size = new System.Drawing.Size(460, 109);
			this.m_findOptionGroup.TabIndex = 2;
			this.m_findOptionGroup.TabStop = false;
			this.m_findOptionGroup.Text = "찾기 옵션";
			// 
			// m_regularExpression
			// 
			this.m_regularExpression.AutoSize = true;
			// 
			// 
			// 
			this.m_regularExpression.BackgroundStyle.Class = "";
			this.m_regularExpression.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_regularExpression.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_regularExpression.Location = new System.Drawing.Point(6, 76);
			this.m_regularExpression.Name = "m_regularExpression";
			this.m_regularExpression.Size = new System.Drawing.Size(89, 20);
			this.m_regularExpression.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_regularExpression.TabIndex = 2;
			this.m_regularExpression.Text = "정규식(&X)";
			// 
			// m_findUp
			// 
			this.m_findUp.AutoSize = true;
			// 
			// 
			// 
			this.m_findUp.BackgroundStyle.Class = "";
			this.m_findUp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_findUp.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_findUp.Location = new System.Drawing.Point(6, 50);
			this.m_findUp.Name = "m_findUp";
			this.m_findUp.Size = new System.Drawing.Size(107, 20);
			this.m_findUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_findUp.TabIndex = 1;
			this.m_findUp.Text = "위로 검색(&U)";
			// 
			// m_matchCase
			// 
			this.m_matchCase.AutoSize = true;
			// 
			// 
			// 
			this.m_matchCase.BackgroundStyle.Class = "";
			this.m_matchCase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_matchCase.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_matchCase.Location = new System.Drawing.Point(6, 24);
			this.m_matchCase.Name = "m_matchCase";
			this.m_matchCase.Size = new System.Drawing.Size(135, 20);
			this.m_matchCase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_matchCase.TabIndex = 0;
			this.m_matchCase.Text = "대/소문자 구분(&C)";
			// 
			// m_findNextButton
			// 
			this.m_findNextButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_findNextButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_findNextButton.Location = new System.Drawing.Point(221, 178);
			this.m_findNextButton.Name = "m_findNextButton";
			this.m_findNextButton.Size = new System.Drawing.Size(120, 25);
			this.m_findNextButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_findNextButton.TabIndex = 3;
			this.m_findNextButton.Text = "다음 찾기(&F)";
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_closeButton.Location = new System.Drawing.Point(347, 178);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(120, 25);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 4;
			this.m_closeButton.Text = "닫기(&C)";
			// 
			// FindStringForm
			// 
			this.AcceptButton = this.m_findNextButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_closeButton;
			this.ClientSize = new System.Drawing.Size(475, 219);
			this.Controls.Add(this.m_closeButton);
			this.Controls.Add(this.m_findNextButton);
			this.Controls.Add(this.m_findOptionGroup);
			this.Controls.Add(this.textBoxX1);
			this.Controls.Add(this.m_contentLabel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FindStringForm";
			this.Text = "찾기";
			this.m_findOptionGroup.ResumeLayout(false);
			this.m_findOptionGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_contentLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
		private System.Windows.Forms.GroupBox m_findOptionGroup;
		private DevComponents.DotNetBar.ButtonX m_findNextButton;
		private DevComponents.DotNetBar.Controls.CheckBoxX m_matchCase;
		private DevComponents.DotNetBar.ButtonX m_closeButton;
		private DevComponents.DotNetBar.Controls.CheckBoxX m_regularExpression;
		private DevComponents.DotNetBar.Controls.CheckBoxX m_findUp;
	}
}