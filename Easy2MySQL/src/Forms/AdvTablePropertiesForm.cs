
// AdvPropertiesForm.cs
//
using Easy2.Classes;
using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Easy2.Forms
{
	public partial class AdvTablePropertiesForm : BaseForm
	{
		/// <summary>
		/// AdvPropertiesForm 컴포넌트를 초기화합니다.
		/// </summary>
		public AdvTablePropertiesForm()
		{
			InitializeComponent();
			InitializeComboBox();
		}

		/// <summary>
		/// 콤보박스들을 초기화합니다.
		/// </summary>
		/// <exception cref="MySqlException">
		/// 쿼리문 실행을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		private void InitializeComboBox()
		{
			try
			{
				this.m_engineCombo.Items.Add("DEFAULT");
				this.m_engineCombo.Items.AddRange(Program.ActivateCommunicator.GetEngines());
				this.m_engineCombo.SelectedIndex = 0;

				this.m_charsetCombo.Items.Add("DEFAULT");
				this.m_charsetCombo.Items.AddRange(Program.ActivateCommunicator.GetCharset());
				this.m_charsetCombo.SelectedIndex = 0;

				this.m_collationCombo.Items.Add("DEFAULT");
				this.m_collationCombo.SelectedIndex = 0;

				this.m_rowformatCombo.Items.AddRange(new string[]{
					"DEFAULT",
					"COMPRESSED",
					"DYNAMIC",
					"FIXED"
				});
				this.m_rowformatCombo.SelectedIndex = 0;

				this.m_checksumCombo.Items.AddRange(new string[]{
					"DEFAULT",
					"0",
					"1"
				});
				this.m_checksumCombo.SelectedIndex = 0;
			}
			catch(MySqlException ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// 폼이 닫혀질 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;

			if(this.Visible == true)
			{
				this.Visible = false;
			}
		}

		/// <summary>
		/// 닫기버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseButtonClick(object sender, EventArgs e)
		{
			if(this.Visible == true)
			{
				this.Visible = false;
			}
		}

		/// <summary>
		/// 확인버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCommitButtonClick(object sender, EventArgs e)
		{
			UpdateData(true);
			if(this.Visible == true)
			{
				this.Visible = false;
			}
		}

		/// <summary>
		/// 컨트롤에 값을 쓰거나 읽어옵니다.
		/// </summary>
		/// <param name="b">true이면 컨트롤에서 데이터를 읽어오고, false이면 컨트롤에 데이터를 씁니다.</param>
		private void UpdateData(bool b)
		{
			if(b == true)
			{
				this.m_tableOption.Engine = this.m_engineCombo.SelectedItem.ToString();
				this.m_tableOption.Charset = this.m_charsetCombo.SelectedItem.ToString();
				this.m_tableOption.Collation = this.m_collationCombo.SelectedItem.ToString();
				this.m_tableOption.Comment = this.m_commentText.Text;
				this.m_tableOption.Format = this.m_rowformatCombo.SelectedItem.ToString();
				this.m_tableOption.Checksum = this.m_checksumCombo.SelectedItem.ToString();
				this.m_tableOption.AutoIncrement = this.m_autoincrText.Text;
				this.m_tableOption.AvgRowLength = this.m_avgrowText.Text;
				this.m_tableOption.MinimumRows = this.m_minimumText.Text;
				this.m_tableOption.MaximumRows = this.m_maximumText.Text;
			}
			else
			{

			}
		}

		/// <summary>
		/// 테이블옵션데이터를 나타냅니다.
		/// </summary>
		public TableOption OptionData
		{
			get { return this.m_tableOption; }
			set { this.m_tableOption = value; }
		}

		private TableOption m_tableOption = new TableOption();
	}
}
