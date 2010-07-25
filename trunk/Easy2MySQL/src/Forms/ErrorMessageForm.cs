
// ErrorMessageForm.cs
//
using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2.Forms
{
	/// <summary>
	/// EasyToMySQL 오류를 출력하는 폼 클래스입니다.
	/// </summary>
	public partial class ErrorMessageForm : BaseForm
	{
		/// <summary>
		/// ErrorMessageForm 인스턴스를 초기화합니다.
		/// </summary>
		public ErrorMessageForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 오류 메세지를 나타냅니다.
		/// </summary>
		public string ErrorMessage
		{
			get { return this.m_errorMessageText.Text; }
			set
			{
				this.m_errorMessageText.Text = value;
				this.m_errorMessageText.Select(this.m_errorMessageText.TextLength, 0);
			}
		}

		/// <summary>
		/// 오류에 대한 주제를 나타냅니다.
		/// </summary>
		public string ErrorSubject
		{
			get { return this.m_subjectLabel.Text; }
			set { this.m_subjectLabel.Text = value; }
		}

		/// <summary>
		/// 오류 번호를 나타냅니다.
		/// </summary>
		public string ErrorNumber
		{
			get { return this.m_errorNumberLabel.Text; }
			set { this.m_errorNumberLabel.Text = value; }
		}

		/// <summary>
		/// 닫기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseButtonClick(object sender, EventArgs e)
		{
			this.Dispose(true);
		}

		/// <summary>
		/// 복사버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCopyButtonClick(object sender, EventArgs e)
		{
			Clipboard.SetText(this.m_errorMessageText.Text);
		}
	}

	/// <summary>
	/// ErrorMessageForm을 생성하는 클래스입니다.
	/// </summary>
	public class EasyToMySqlError
	{
		/// <summary>
		/// 오류 메세지를 출력하는 폼을 생성합니다.
		/// </summary>
		/// <param name="owner">부모 윈도우입니다.</param>
		/// <param name="message">오류 메세지입니다.</param>
		/// <param name="subject">오류에 대한 주제입니다.</param>
		public static void Show(IWin32Window owner, string message, string subject)
		{
			Show(owner, message, subject, -1);
		}

		/// <summary>
		/// 오류 메세지를 출력하는 폼을 생성합니다.
		/// </summary>
		/// <param name="owner">부모 윈도우입니다.</param>
		/// <param name="message">오류 메세지입니다.</param>
		/// <param name="subject">오류에 대한 주제입니다.</param>
		/// <param name="number">오류 번호입니다.</param>
		public static void Show(IWin32Window owner, string message, string subject, int number)
		{
			ErrorMessageForm frm = new ErrorMessageForm();
			frm.ErrorMessage = message;
			frm.ErrorSubject = String.Format("<b>{0}</b>", subject);
			if(number > 0)
				frm.ErrorNumber = String.Format("<div align=\"right\">Error No. <font color=\"#FF0000\">{0}</font></div>", number);

			frm.ShowDialog(owner);
		}
	}
}