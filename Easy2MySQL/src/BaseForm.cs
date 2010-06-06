
// BaseForm.cs
//
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 모든 다이얼로그를 구성하는 베이스폼 클래스입니다.
	/// </summary>
	public partial class BaseForm : Office2007Form
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public BaseForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// ShowDialog 재정의 입니다.
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
