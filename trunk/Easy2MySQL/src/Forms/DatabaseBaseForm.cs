
// DatabaseBaseForm.cs
//
using Easy2.Properties;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Easy2
{
	/// <summary>
	/// DatabaseBaseForm 클래스입니다.
	/// </summary>
	public partial class DatabaseBaseForm : BaseForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public DatabaseBaseForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// OnLoad의 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			this.m_charsetCombo.Items.Add("기본값");
			this.m_collationCombo.Items.Add("기본값");
			this.m_charsetCombo.SelectedIndex = 0;
			this.m_collationCombo.SelectedIndex = 0;

			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowCharset());
				SortedSet<string> readerSet = new SortedSet<string>();
				while(reader.Read())
				{
					readerSet.Add(reader.GetString(0));
				}
				foreach(string s in readerSet)
				{
					this.m_charsetCombo.Items.Add(s);
				}
				readerSet.Clear();
				reader.Close();
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

		/// <summary>
		/// 확인 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnCommitButtonClick(object sender, System.EventArgs e)
		{
			this.m_dataEffectiveness = false;

			if(this.m_nameText.Text.Trim().Length == 0)
			{
				MessageBox.Show(
					this, String.Format(
						Resources.Easy2Message_EmptyItem,
						this.m_nameLabel.Text.Substring(0, this.m_nameLabel.Text.Length - 4)),
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

				this.m_nameText.Focus();
				return;
			}
			this.m_dataEffectiveness = true;
		}

		/// <summary>
		/// 닫기 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnCloseButtonClick(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		/// <summary>
		/// 문자셋 콤보박스 인덱스가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCharsetComboSelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.m_charsetCombo.SelectedIndex != 0)
			{
				string charset = this.m_charsetCombo.SelectedItem.ToString();

				MySqlDataReader reader = null;
				try
				{
					reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowCharset(charset));
					reader.Read();
					this.m_descriptionLabel.Text = reader.GetString(1);
					reader.Close();

					this.m_collationCombo.Items.Clear();
					reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowCollation(charset));
					while(reader.Read())
					{
						this.m_collationCombo.Items.Add(reader.GetString(0));
					}
					this.m_collationCombo.SelectedIndex = 0;
					reader.Close();
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
			else
			{
				this.m_collationCombo.Items.Clear();
				this.m_collationCombo.Items.Add("기본값");
				this.m_collationCombo.SelectedIndex = 0;
				this.m_descriptionLabel.Text = "Default Charset";
			}
		}

		/// <summary>
		/// 확인버튼을 눌렀을 때, UserBaseForm에서 데이터유효성을 검사하여 다음작업을 수행해도 될지 여부입니다.
		/// </summary>
		protected bool DataEffectiveness
		{
			get { return this.m_dataEffectiveness; }
		}

		private bool m_dataEffectiveness;
	}
}
