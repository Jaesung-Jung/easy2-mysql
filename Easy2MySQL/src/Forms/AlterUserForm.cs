
// AlterUserForm.cs
//
using Easy2.Properties;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Easy2
{
	public partial class AlterUserForm : UserBaseForm
	{
		public AlterUserForm()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			if(Program.ActivateCommunicator.v402 == false)
				this.m_402VersionGroupBox.Enabled = false;
			if(Program.ActivateCommunicator.v500 == false)
				this.m_500VersionGroupBox.Enabled = false;
			if(Program.ActivateCommunicator.v510 == false)
				this.m_510VersionGroupBox.Enabled = false;
		}
	}
}
