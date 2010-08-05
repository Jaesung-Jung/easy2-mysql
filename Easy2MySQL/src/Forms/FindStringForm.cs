
// FindStringForm.cs
//
using System;

namespace Easy2.Forms
{
	/// <summary>
	/// 쿼리에디터의 문자열 검색을 위한 폼 클래스입니다.
	/// </summary>
	public partial class FindStringForm : BaseForm
	{
		/// <summary>
		/// FindStringForm 인스턴스를 초기화합니다.
		/// </summary>
		public FindStringForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 닫기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseButtonClick(object sender, EventArgs e)
		{
			this.Hide();
		}

		/// <summary>
		/// 찾기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnFindNextButtonClick(object sender, EventArgs e)
		{

		}
	}
}
