
// BaseForm.cs
//
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2.Forms
{
	/// <summary>
	/// 모든 대화상자를 구성하는 베이스폼 클래스입니다.
	/// </summary>
	public partial class BaseForm : Office2007Form
	{
		/// <summary>
		/// BaseForm 인스턴스를 초기화합니다.
		/// </summary>
		public BaseForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 다이얼폼을 모달 대화 상자로 표시합니다.
		/// </summary>
		/// <param name="owner">부모 윈도우 객체입니다.</param>
		/// <returns>대화상자 결과 객체입니다.</returns>
		new public DialogResult ShowDialog(IWin32Window owner)
		{
			this.BackColor = ((Form)owner).BackColor;
			return base.ShowDialog(owner);
		}
	}
}
