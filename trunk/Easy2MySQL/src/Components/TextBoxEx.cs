
// TextBoxEx.cs
//
using System;
using DevComponents.DotNetBar.Controls;

namespace Easy2
{
	/// <summary>
	/// TextBoxEx 클래스입니다.
	/// </summary>
	public class TextBoxEx : TextBoxX
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public TextBoxEx()
		{
			this.TextChanged += new EventHandler(OnTextChanged);
		}

		/// <summary>
		/// TextChanged 이벤트입니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnTextChanged(object sender, EventArgs e)
		{
		}

	}
}
