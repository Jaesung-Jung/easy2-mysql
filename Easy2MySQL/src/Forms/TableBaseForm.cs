
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
			this.m_tableLayoutPanel1.Controls.Add(new TableEditor());
		}
	}
}
