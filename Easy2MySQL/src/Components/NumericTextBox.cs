
// NumericTextBox.cs
//
using Easy2.Properties;
using Easy2.Forms;
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
				if(this.m_balloon.Visible == false)
					this.m_balloon.ShowMessageBox(this, Resources.Easy2Exception_NotAllowedCharacter, false, MessageBoxIcon.Error);
			}
			else
			{
				this.m_balloon.HideMessageBox();
			}
			base.OnKeyPress(e);
		}

		/// <summary>
		/// 컨트롤이 포커스를 잃으면 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			
			if(this.m_balloon.Visible)
			{
				this.m_balloon.HideMessageBox();
			}
		}

		private BallonMessageBox m_balloon = new BallonMessageBox();
	}
}
