﻿
// DatabaseBaseForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Easy2.Forms
{
	/// <summary>
	/// 데이터베이스 생성 및 수정을 위한 베이스 폼 클래스입니다.
	/// </summary>
	public partial class DatabaseBaseForm : BaseForm
	{
		/// <summary>
		/// DatabaseBaseForm 인스턴스를 초기화합니다.
		/// </summary>
		public DatabaseBaseForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 문자열이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnTextChanged(object sender, EventArgs e)
		{
			this.m_commitButton.Enabled = this.m_nameText.TextLength != 0 ? true : false;
		}

		/// <summary>
		/// 문자셋의 콤보박스를 초기화합니다.
		/// </summary>
		protected void InitializeCharset()
		{
			this.m_charsetCombo.Items.Add("기본값");
			this.m_collationCombo.Items.Add("기본값");
			this.m_charsetCombo.SelectedIndex = 0;
			this.m_collationCombo.SelectedIndex = 0;

			try
			{
				this.m_charsetCombo.Items.AddRange(Program.ActivateCommunicator.GetCharset());
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
		}

		/// <summary>
		/// 확인 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <remarks>
		/// DatabaseBaseForm을 상속받을 클래스는 이 메소드를 반드시 재정의해야합니다.
		/// </remarks>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnCommitButtonClick(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 닫기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnCloseButtonClick(object sender, EventArgs e)
		{
			this.Dispose(true);
		}

		/// <summary>
		/// 문자셋 콤보박스 인덱스가 변경되면 호출됩니다.
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
					this.m_descriptionLabel.Text = Program.ActivateCommunicator.GetDescription(charset);
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
				this.m_collationCombo.Items.Add("기본값");
				this.m_collationCombo.SelectedIndex = 0;
				this.m_descriptionLabel.Text = "Default Charset";
			}
		}
	}
}
