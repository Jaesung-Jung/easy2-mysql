
// CreateTableForm.cs
//
using System;
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
			base.TableEditorContainer = this.m_tableEditor;
		}

		/// <summary>
		/// 고급 기능버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
 		protected override void OnAdvanceButtonClick(object sender, EventArgs e)
 		{
			this.m_advPropertiesForm.ShowDialog(this);
			base.OnAdvanceButtonClick(sender, e);
 		}

		protected override void OnDeleteRowButtonClick(object sender, EventArgs e)
		{
			this.m_tableEditor.RemoveRow();
			base.OnDeleteRowButtonClick(sender, e);
		}

		private TableEditor m_tableEditor = new TableEditor();
		private AdvTablePropertiesForm m_advPropertiesForm = new AdvTablePropertiesForm();
	}
}
