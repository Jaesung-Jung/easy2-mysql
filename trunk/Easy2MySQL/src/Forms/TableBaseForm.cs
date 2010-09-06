
// TableBaseForm.cs
//
using Easy2.Components;
using System;

namespace Easy2.Forms
{
	public partial class TableBaseForm : BaseForm
	{
		/// <summary>
		/// 컴포넌트를 초기화합니다.
		/// </summary>
		public TableBaseForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 닫기버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected void OnCloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// 고급 기능버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnAdvanceButtonClick(object sender, EventArgs e)
		{
			this.m_advPropertiesForm.ShowDialog(this);
		}

		/// <summary>
		/// 테이블에디터를 담는 컨테이너를 나타냅니다.
		/// </summary>
		public TableEditor TableEditorContainer
		{
			set { this.m_layoutPanel.Controls.Add(value); }
		}

		private AdvTablePropertiesForm m_advPropertiesForm = new AdvTablePropertiesForm();
	}
}
