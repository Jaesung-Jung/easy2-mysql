
// TableBaseForm.cs
//
using Easy2.Components;

namespace Easy2.Forms
{
	public partial class TableBaseForm : BaseForm
	{
		public TableBaseForm()
		{
			InitializeComponent();
			this.m_tableLayoutPanel1.Controls.Add(this.m_tableEditor);
		}

		protected void OnCommitButtonClick(object sender, System.EventArgs e)
		{
		}

		protected void OnDeleteRowButtonClick(object sender, System.EventArgs e)
		{
			this.m_tableEditor.RemoveRow();
		}

		protected void OnCloseButtonClick(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void OnAdvanceButtonClick(object sender, System.EventArgs e)
		{

		}

		private TableEditor m_tableEditor = new TableEditor();
	}
}
