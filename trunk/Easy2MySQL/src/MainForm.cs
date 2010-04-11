
// MainForm.cs
using System;
using System.Drawing;
using DevComponents.DotNetBar;

namespace Easy2
{
	public partial class MainForm : Office2007RibbonForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void AppCommandTheme_Executed(object sender, System.EventArgs e)
		{
			ICommandSource source = sender as ICommandSource;
			if(source.CommandParameter is string)
			{
				eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
				// Using StyleManager change the style and color tinting
				StyleManager.ChangeStyle(style, Color.Empty);
			}
		}
	}
}
