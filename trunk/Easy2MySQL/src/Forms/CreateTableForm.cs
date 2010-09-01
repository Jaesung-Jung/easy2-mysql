
// CreateTableForm.cs
//
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

		private TableEditor m_tableEditor = new TableEditor();
	}
}
