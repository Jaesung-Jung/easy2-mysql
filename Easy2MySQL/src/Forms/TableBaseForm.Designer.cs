namespace Easy2.Forms
{
	partial class TableBaseForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.m_titleImgLabel = new DevComponents.DotNetBar.LabelX();
			this.m_titleLabel = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.m_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.m_tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.m_tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_titleImgLabel
			// 
			this.m_titleImgLabel.BackgroundStyle.Class = "";
			this.m_titleImgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleImgLabel.Image = global::Easy2.Properties.Resources.CreateTable;
			this.m_titleImgLabel.Location = new System.Drawing.Point(4, 4);
			this.m_titleImgLabel.Name = "m_titleImgLabel";
			this.m_titleImgLabel.Size = new System.Drawing.Size(48, 48);
			this.m_titleImgLabel.TabIndex = 0;
			// 
			// m_titleLabel
			// 
			this.m_titleLabel.BackgroundStyle.Class = "";
			this.m_titleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleLabel.Location = new System.Drawing.Point(63, 4);
			this.m_titleLabel.Name = "m_titleLabel";
			this.m_titleLabel.Size = new System.Drawing.Size(393, 50);
			this.m_titleLabel.TabIndex = 1;
			// 
			// m_tableLayoutPanel1
			// 
			this.m_tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_tableLayoutPanel1.ColumnCount = 1;
			this.m_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tableLayoutPanel1.Controls.Add(this.m_tableLayoutPanel2, 0, 1);
			this.m_tableLayoutPanel1.Location = new System.Drawing.Point(12, 60);
			this.m_tableLayoutPanel1.Name = "m_tableLayoutPanel1";
			this.m_tableLayoutPanel1.RowCount = 2;
			this.m_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.m_tableLayoutPanel1.Size = new System.Drawing.Size(917, 446);
			this.m_tableLayoutPanel1.TabIndex = 2;
			// 
			// m_tableLayoutPanel2
			// 
			this.m_tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_tableLayoutPanel2.ColumnCount = 5;
			this.m_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.m_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tableLayoutPanel2.Location = new System.Drawing.Point(3, 409);
			this.m_tableLayoutPanel2.Name = "m_tableLayoutPanel2";
			this.m_tableLayoutPanel2.RowCount = 1;
			this.m_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tableLayoutPanel2.Size = new System.Drawing.Size(911, 34);
			this.m_tableLayoutPanel2.TabIndex = 2;
			// 
			// TableBaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 518);
			this.Controls.Add(this.m_tableLayoutPanel1);
			this.Controls.Add(this.m_titleLabel);
			this.Controls.Add(this.m_titleImgLabel);
			this.DoubleBuffered = true;
			this.Name = "TableBaseForm";
			this.Text = "TableBaseForm";
			this.m_tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.LabelX m_titleImgLabel;
		private DevComponents.DotNetBar.Controls.ReflectionLabel m_titleLabel;
		private System.Windows.Forms.TableLayoutPanel m_tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel m_tableLayoutPanel2;
	}
}