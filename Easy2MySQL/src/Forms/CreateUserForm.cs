
// CreateUserForm.cs
//
using System.Collections.Generic;
using DevComponents.DotNetBar.Controls;

namespace Easy2
{
	public partial class CreateUserForm : UserForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public CreateUserForm()
		{
			InitializeComponent();
			this.m_checkList.AddRange(
				new CheckBoxX[]
				{
					this.m_select, this.m_insert, this.m_update, this.m_delete, this.m_create,
					this.m_drop, this.m_reload, this.m_shutdown, this.m_process, this.m_file,
					this.m_reference, this.m_index, this.m_alter, this.m_grant, this.m_execute,
					this.m_repl_slave, this.m_show_db, this.m_repl_client, this.m_super,
					this.m_lock_tables, this.m_create_tmp_tables, this.m_create_view, this.m_create_routine,
					this.m_show_view, this.m_alter_routine, this.m_create_user, this.m_trigger, this.m_event
				}
			);
		}

		/// <summary>
		/// 모두선택 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void m_selectAllButton_Click(object sender, System.EventArgs e)
		{
			foreach(CheckBoxX check in this.m_checkList)
			{
				check.Checked = true;
			}
		}

		/// <summary>
		/// 선택해제 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void m_deselectAllButton_Click(object sender, System.EventArgs e)
		{
			foreach(CheckBoxX check in this.m_checkList)
			{
				check.Checked = false;
			}
		}

		private List<CheckBoxX> m_checkList = new List<CheckBoxX>(28);
	}
}
