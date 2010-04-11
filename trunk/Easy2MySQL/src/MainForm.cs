
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
			else if(source.CommandParameter is Color)
			{
				StyleManager.ColorTint = (Color)source.CommandParameter;
			}
		}

		#region Automatic Color Scheme creation based on the selected color table
		private bool colorSelected = false;
		private eStyle baseStyle = eStyle.Office2010Silver;
		private void customColor_ExpandChange(object sender, EventArgs e)
		{
			if(this.customColor.Expanded)
			{
				// Remember the starting color scheme to apply if no color is selected during live-preview
				colorSelected = false;
				baseStyle = StyleManager.Style;
			}
			else
			{
				if(!colorSelected)
				{
					StyleManager.ChangeStyle(baseStyle, Color.Empty);
				}
			}
		}

		private void customColor_ColorPreview(object sender, ColorPreviewEventArgs e)
		{
			StyleManager.ColorTint = e.Color;
		}

		private void customColor_SelectedColorChanged(object sender, EventArgs e)
		{
			colorSelected = true; // Indicate that color was selected for buttonStyleCustom_ExpandChange method
			customColor.CommandParameter = customColor.SelectedColor;
		}
		#endregion
	}
}
