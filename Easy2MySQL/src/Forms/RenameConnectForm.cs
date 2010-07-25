
// RenameConnectForm.cs
//

namespace Easy2.Forms
{
	/// <summary>
	/// 연결명을 수정하기 위한 폼 클래스입니다.
	/// </summary>
	public partial class RenameConnectForm : NewConnectForm
	{
		/// <summary>
		/// RenameConnectForm 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="currentConnectName">수정하기 전의 연결명입니다.</param>
		public RenameConnectForm(string currentConnectName)
		{
			InitializeComponent();
			this.m_connectNameText.Text = currentConnectName;
		}
	}
}
