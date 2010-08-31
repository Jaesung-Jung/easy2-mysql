
// NumericTextBox.cs
//
using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace Easy2.Components
{
	/// <summary>
	/// 숫자만 입력가능한 텍스트박스입니다.
	/// 숫자가 아닌 입력이 들어올 때 풍선 팁을 보여줍니다.
	/// </summary>
	class NumericTextBox : TextBoxX
	{
		/// <summary>
		/// 키가 눌러지면 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			char key = e.KeyChar;
			if(Char.IsLetter(key) || Char.IsWhiteSpace(key) || Char.IsSymbol(key) || Char.IsPunctuation(key))
			{
				e.Handled = true;
			}
			base.OnKeyPress(e);
		}
	}
}
