
// AdvPropertiesForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Easy2.Forms
{
	public partial class AdvTablePropertiesForm : BaseForm
	{
		/// <summary>
		/// AdvPropertiesForm 컴포넌트를 초기화합니다.
		/// </summary>
		/// <param name="option">테이블옵션 객체입니다.</param>
		public AdvTablePropertiesForm(TableOption option)
		{
			InitializeComponent();
			InitializeComboBox();
			WriteData(option);
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
		/// 문자셋 콤보의 선택된 인덱스가 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCharsetComboSelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.m_charsetCombo.SelectedIndex != 0)
			{
				string charset = this.m_charsetCombo.SelectedItem.ToString();

				try
				{
					this.m_collationCombo.Items.Clear();
					this.m_collationCombo.Items.AddRange(Program.ActivateCommunicator.GetCollation(charset));
					this.m_collationCombo.SelectedIndex = 0;
				}
				catch(MySqlException ex)
				{
					EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				}
			}
			else
			{
				this.m_collationCombo.Items.Clear();
				this.m_collationCombo.Items.Add("DEFAULT");
				this.m_collationCombo.SelectedIndex = 0;
			}
		}

		/// <summary>
		/// 컨트롤에서 값을 읽어옵니다.
		/// </summary>
		/// <returns>읽어진 테이블옵션 객체입니다.</returns>
		public TableOption ReadData()
		{
			TableOption option = new TableOption();
			option.Engine = this.m_engineCombo.SelectedItem.ToString();
			option.Charset = this.m_charsetCombo.SelectedItem.ToString();
			option.Collation = this.m_collationCombo.SelectedItem.ToString();
			option.Comment = this.m_commentText.Text.Length != 0 ? this.m_commentText.Text : null;
			option.Format = this.m_rowformatCombo.SelectedItem.ToString();
			option.Checksum = this.m_checksumCombo.SelectedItem.ToString();
			option.AutoIncrement = this.m_autoincrText.Text.Length != 0 ? this.m_autoincrText.Text : null;
			option.AvgRowLength = this.m_avgrowText.Text.Length != 0 ? this.m_avgrowText.Text : null;
			option.MinimumRows = this.m_minimumText.Text.Length != 0 ? this.m_minimumText.Text : null;
			option.MaximumRows = this.m_maximumText.Text.Length != 0 ? this.m_maximumText.Text : null;

			return option;
		}

		/// <summary>
		/// 컨트롤에 값을 씁니다.
		/// </summary>
		/// <param name="option">쓰여질 테이블옵션 객체입니다.</param>
		private void WriteData(TableOption option)
		{
			if(option != null)
			{
				this.m_engineCombo.SelectedIndex = this.m_engineCombo.FindString(option.Engine);
				this.m_charsetCombo.SelectedIndex = this.m_charsetCombo.FindString(option.Charset);
				this.m_collationCombo.SelectedIndex = this.m_collationCombo.FindString(option.Collation);
				this.m_commentText.Text = option.Comment != null ? option.Comment : "";
				this.m_rowformatCombo.SelectedIndex = this.m_rowformatCombo.FindString(option.Format);
				this.m_checksumCombo.SelectedIndex = this.m_checksumCombo.FindString(option.Checksum);
				this.m_autoincrText.Text = option.AutoIncrement != null ? option.AutoIncrement : "";
				this.m_avgrowText.Text = option.AvgRowLength != null ? option.AvgRowLength : "";
				this.m_minimumText.Text = option.MinimumRows != null ? option.MinimumRows : "";
				this.m_maximumText.Text = option.MaximumRows != null ? option.MaximumRows : "";
			}
		}
	}
}
