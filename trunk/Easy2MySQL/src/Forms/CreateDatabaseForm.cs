
// CreateDatabaseForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Easy2.Forms
{
	/// <summary>
	/// 데이터베이스 생성을 위한 폼 클래스입니다.
	/// </summary>
	public partial class CreateDatabaseForm : DatabaseBaseForm
	{
		/// <summary>
		/// CreateDatabaseForm 인스턴스를 초기화합니다.
		/// </summary>
		public CreateDatabaseForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 폼이 열릴 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.InitializeCharset();
		}

		/// <summary>
		/// 확인버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
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

		/// <summary>
		/// 생성할 데이터베이스 이름을 나타냅니다.
		/// </summary>
		public string CreatedDatabaseName
		{
			get { return this.m_nameText.Text; }
		}
	}
}
