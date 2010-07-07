
// RenameConnectForm.cs
//

namespace Easy2
{
	/// <summary>
	/// RenameConnectForm 클래스입니다.
	/// </summary>
	public partial class RenameConnectForm : NewConnectForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="currentConnectName"></param>
		public RenameConnectForm(string currentConnectName)
		{
			InitializeComponent();
			this.m_connectNameText.Text = currentConnectName;
		}
	}
}
