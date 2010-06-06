
// ErrorMessageForm.cs
//
using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2
{
	public partial class ErrorMessageForm : BaseForm
	{
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

		private void m_closeButton_Click(object sender, EventArgs e)
		{
			this.Dispose(true);
		}
	}

	public class EasyToMySqlError
	{
		/// <summary>
		/// 오류 메세지를 출력하는 폼을 띄웁니다.
		/// </summary>
		/// <param name="owner">부모 윈도우입니다.</param>
		/// <param name="message">오류 메세지입니다.</param>
		/// <param name="subject">오류에 대한 주제입니다.</param>
		public static void Show(IWin32Window owner, string message, string subject)
		{
			Show(owner, message, subject, -1);
		}

		/// <summary>
		/// 오류 메세지를 출력하는 폼을 띄웁니다.
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