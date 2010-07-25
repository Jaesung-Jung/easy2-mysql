
// CreateDatabaseForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Easy2.Forms
{
	/// <summary>
	/// CreateDatabaseForm 클래스입니다.
	/// </summary>
	public partial class CreateDatabaseForm : DatabaseBaseForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public CreateDatabaseForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// OnLoad 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);
			this.InitializeCharset();
		}

		/// <summary>
		/// OnCommitButtonClick 재정의입니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, System.EventArgs e)
		{
			base.OnCommitButtonClick(sender, e);

			try
			{
				if(this.m_charsetCombo.SelectedIndex == 0)
				{
					string dbname = this.m_nameText.Text;
					Program.ActivateCommunicator.CreateDatabase(dbname);
				}
				else
				{
					string dbname = this.m_nameText.Text;
					string charset = this.m_charsetCombo.SelectedItem.ToString();
					string collation = this.m_collationCombo.SelectedItem.ToString();
					Program.ActivateCommunicator.CreateDatabase(dbname, charset, collation);
				}
				this.DialogResult = DialogResult.Yes;
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
		}

		public string CreatedDatabaseName
		{
			get { return this.m_nameText.Text; }
		}
	}
}
