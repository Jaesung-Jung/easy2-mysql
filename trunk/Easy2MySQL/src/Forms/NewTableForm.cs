
// NewTableForm.cs
//
using System;
using DevComponents.DotNetBar;

namespace Easy2.Forms
{
	public partial class NewTableForm : BaseForm
	{
		public NewTableForm()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			this.m_tableNameText.Focus();
			this.m_tableNameText.SelectAll();
		}

		private void OnTableNameTextChanged(object sender, EventArgs e)
		{
			this.m_commitButton.Enabled = this.m_tableNameText.TextLength > 0? true : false;
		}

		public string TableName
		{
			get { return this.m_tableNameText.Text; }
		}
	}
}
