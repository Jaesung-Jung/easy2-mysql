
// NewConnectForm.cs
//
using System.Windows.Forms;

namespace Easy2
{
	public partial class NewConnectForm : BaseForm
	{
		public NewConnectForm(ConnectForm handle)
		{
			this.m_connectFormHandle = handle;
			InitializeComponent();
		}

		private void m_connectNameText_TextChanged(object sender, System.EventArgs e)
		{
			this.m_commitButton.Enabled = this.m_connectNameText.TextLength == 0 ? false : true;
		}

		private void m_cancelButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Dispose(true);
		}

		private void m_commitButton_Click(object sender, System.EventArgs e)
		{
			this.m_connectFormHandle.ConnectInfo.ConnectName = this.m_connectNameText.Text;
			this.DialogResult = DialogResult.OK;
			this.Close();
//			this.Dispose(true);
		}

		ConnectForm m_connectFormHandle;
	}
}
