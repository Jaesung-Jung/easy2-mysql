
// NewConnectForm.cs
//
using System.Windows.Forms;

namespace Easy2
{
	/// <summary>
	/// 새로운 연결명을 입력하는 폼 클래스입니다.
	/// </summary>
	public partial class NewConnectForm : BaseForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public NewConnectForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 연결명을 입력하는 텍스트박스의 텍스트가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_connectNameText_TextChanged(object sender, System.EventArgs e)
		{
			this.m_commitButton.Enabled = this.m_connectNameText.TextLength == 0 ? false : true;
		}

		/// <summary>
		/// 취소버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_cancelButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Dispose(true);
		}

		/// <summary>
		/// 확인버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_commitButton_Click(object sender, System.EventArgs e)
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
