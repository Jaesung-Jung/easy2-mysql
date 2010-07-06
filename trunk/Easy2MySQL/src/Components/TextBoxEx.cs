
// TextBoxEx.cs
//
using System;
using DevComponents.DotNetBar.Controls;

namespace Easy2
{
	public class TextBoxEx : TextBoxX
	{
		public TextBoxEx()
		{
			this.TextChanged += new EventHandler(OnTextChanged);
		}

		void OnTextChanged(object sender, EventArgs e)
		{
		}
	}
}
