
// CheckBoxEx.cs
//
using System;
using DevComponents.DotNetBar.Controls;

namespace Easy2
{
	/// <summary>
	/// TextBoxEx 클래스입니다.
	/// </summary>
	public class CheckBoxEx : CheckBoxX
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public CheckBoxEx()
		{
			this.CheckedChanged += new System.EventHandler(OnCheckedChanged);
		}

		/// <summary>
		/// CheckedChanged 이벤트입니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnCheckedChanged(object sender, EventArgs e)
		{
		}
	}
}
