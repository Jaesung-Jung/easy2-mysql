
// RenameConnectForm.cs
//

namespace Easy2
{
	public partial class RenameConnectForm : NewConnectForm
	{
		public RenameConnectForm(string currentConnectName)
		{
			InitializeComponent();
			this.m_connectNameText.Text = currentConnectName;
		}
	}
}
