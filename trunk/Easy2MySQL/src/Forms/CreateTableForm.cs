
// CreateTableForm.cs
//
using System;
using System.Windows.Forms;
using Easy2.Classes;
using Easy2.Components;

namespace Easy2.Forms
{
	public partial class CreateTableForm : TableBaseForm
	{
		/// <summary>
		/// CreateTableForm 컴포넌트를 초기화합니다.
		/// </summary>
		public CreateTableForm()
		{
			InitializeComponent();
			this.m_tableEditor.SelectionChanged += new EventHandler(this.OnTableEditorSelectionChanged);
			base.TableEditorContainer = this.m_tableEditor;
		}

		/// <summary>
		/// 선택된 셀이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnTableEditorSelectionChanged(object sender, EventArgs e)
		{
			if(this.m_tableEditor.CurrentCell.OwningRow.IsNewRow == false)
			{
				this.m_deleteRowButton.Enabled = true;
			}
			else
			{
				this.m_deleteRowButton.Enabled = false;
			}
		}

		/// <summary>
		/// 확인버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
		{
			base.OnCommitButtonClick(sender, e);
			Program.ActivateCommunicator.CreateTable(this.m_tableEditor.ReadColumns(), this.m_tableOption);
		}

		/// <summary>
		/// 고급 기능버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
 		protected override void OnAdvanceButtonClick(object sender, EventArgs e)
 		{
			AdvTablePropertiesForm advPropertiesForm = new AdvTablePropertiesForm(this.m_tableOption);
			advPropertiesForm.ShowDialog(this);
			if(advPropertiesForm.DialogResult == DialogResult.OK)
			{
				this.m_tableOption = advPropertiesForm.ReadData();
			}
			base.OnAdvanceButtonClick(sender, e);
 		}

		/// <summary>
		/// 열 제거버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnDeleteRowButtonClick(object sender, EventArgs e)
		{
			this.m_tableEditor.RemoveRow();
			base.OnDeleteRowButtonClick(sender, e);
		}

		private TableEditor m_tableEditor = new TableEditor();
		private TableOption m_tableOption = null;
	}
}
