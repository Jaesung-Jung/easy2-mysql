
// NewConnectForm.cs
//
using System;
using System.Windows.Forms;

namespace Easy2.Forms
{
	/// <summary>
	/// 새로운 연결명을 입력을 위한 폼 클래스입니다.
	/// </summary>
	public partial class NewConnectForm : BaseForm
	{
		/// <summary>
		/// NewConnectForm 인스턴스를 초기화합니다.
		/// </summary>
		public NewConnectForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 연결명 텍스트가 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnConnectNameTextChanged(object sender, EventArgs e)
		{
			this.m_commitButton.Enabled = this.m_connectNameText.TextLength == 0 ? false : true;
		}

		/// <summary>
		/// 닫기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseButtonClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Dispose(true);
		}

		/// <summary>
		/// 확인 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCommitButtonClick(object sender, EventArgs e)
		{
			this.m_connectionName = this.m_connectNameText.Text;
 			this.DialogResult = DialogResult.OK;
 			this.Dispose(true);
		}

		/// <summary>
		/// 입력된 연결명을 나타냅니다.
		/// </summary>
		public string ConnectionName
		{
			get { return this.m_connectionName; }
		}

		string m_connectionName;
	}
}
