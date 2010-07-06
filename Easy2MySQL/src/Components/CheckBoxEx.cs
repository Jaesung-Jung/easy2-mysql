
// CheckBoxEx.cs
//
using System;
using DevComponents.DotNetBar.Controls;

namespace Easy2
{
	public class CheckBoxEx : CheckBoxX
	{
		public CheckBoxEx()
		{
			this.CheckedChanged += new System.EventHandler(OnCheckedChanged);
		}

		protected virtual void OnCheckedChanged(object sender, EventArgs e)
		{
		}
	}
}
