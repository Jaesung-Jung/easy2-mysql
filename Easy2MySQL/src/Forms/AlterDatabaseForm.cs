
// AlterDatabaseForm.cs
//
using Easy2.Properties;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Easy2
{
	public partial class AlterDatabaseForm : DatabaseBaseForm
	{
		public AlterDatabaseForm(string dbname)
		{
			InitializeComponent();
			this.m_dbname = dbname;
		}

		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);
			this.InitializeCharset();

			this.m_nameText.Text = this.m_dbname;
			this.m_nameText.Enabled = false;

			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowCharsetForUseDatabase());
				reader.Read();
				string charset = reader.GetString(1);
				reader.Close();

				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowCollationForUseDatabase());
				reader.Read();
				string collation = reader.GetString(1);
				reader.Close();

				this.m_charsetCombo.SelectedIndex = this.m_charsetCombo.FindString(charset);
				this.m_collationCombo.SelectedIndex = this.m_collationCombo.FindString(collation);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		protected override void OnCommitButtonClick(object sender, System.EventArgs e)
		{
			base.OnCommitButtonClick(sender, e);

			this.DialogResult = DialogResult.No;

			MySqlDataReader reader = null;
			try
			{
				if(this.m_charsetCombo.SelectedIndex == 0)
				{
					reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowCharsetServer());
					reader.Read();
					string charset = reader.GetString(1);
					reader.Close();

					reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowCollationServer());
					reader.Read();
					string collation = reader.GetString(1);
					reader.Close();

					Program.ActivateCommunicator.AlterDatabase(this.m_dbname, charset, collation);
				}
				else
				{
					string dbname = this.m_nameText.Text;
					string charset = this.m_charsetCombo.SelectedItem.ToString();
					string collation = this.m_collationCombo.SelectedItem.ToString();
					Program.ActivateCommunicator.AlterDatabase(dbname, charset, collation);
				}
				this.DialogResult = DialogResult.Yes;
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		private string m_dbname;
	}
}
