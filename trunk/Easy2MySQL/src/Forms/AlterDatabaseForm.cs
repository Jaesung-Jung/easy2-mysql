
// AlterDatabaseForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Easy2.Forms
{
	/// <summary>
	/// 데이터베이스를 수정을 위한 폼입니다.
	/// </summary>
	public partial class AlterDatabaseForm : DatabaseBaseForm
	{
		/// <summary>
		/// AlterDatabaseForm 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="dbname">수정될 데이터베이스의 이름입니다.</param>
		public AlterDatabaseForm(string dbname)
		{
			InitializeComponent();
			this.m_dbname = dbname;
		}

		/// <summary>
		/// 폼이 열릴 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.InitializeCharset();

			this.m_nameText.Text = this.m_dbname;
			this.m_nameText.Enabled = false;

			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.ShowCharsetForUseDatabase()
					);
				reader.Read();
				string charset = reader["Value"].ToString();
				reader.Close();

				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.ShowCollationForUseDatabase()
					);
				reader.Read();
				string collation = reader["Value"].ToString();
				reader.Close();

				this.m_charsetCombo.SelectedIndex = this.m_charsetCombo.FindString(charset);
				this.m_collationCombo.SelectedIndex = this.m_collationCombo.FindString(collation);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this,	ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		/// <summary>
		/// 확인 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
		{
			base.OnCommitButtonClick(sender, e);

			this.DialogResult = DialogResult.No;

			MySqlDataReader reader = null;
			try
			{
				if(this.m_charsetCombo.SelectedIndex == 0)
				{
					reader = Program.ActivateCommunicator.ExecuteReader(
						MySqlGenerator.ShowCharsetServer()
						);
					reader.Read();
					string charset = reader["Value"].ToString();
					reader.Close();

					reader = Program.ActivateCommunicator.ExecuteReader(
						MySqlGenerator.ShowCollationServer()
						);
					reader.Read();
					string collation = reader["Value"].ToString();
					reader.Close();

					Program.ActivateCommunicator.AlterDatabase(
						this.m_dbname,
						charset,
						collation
						);
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
