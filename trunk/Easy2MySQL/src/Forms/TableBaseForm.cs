
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
		}

		protected void OnCloseButtonClick(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void OnAdvanceButtonClick(object sender, System.EventArgs e)
		{

		}
	}
}
