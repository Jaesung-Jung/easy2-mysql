
// AdvPropertiesForm.cs
//
using System;
using System.ComponentModel;

namespace Easy2.Forms
{
	public partial class AdvPropertiesForm : BaseForm
	{
		public AdvPropertiesForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 폼이 닫혀질 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;

			if(this.Visible == true)
			{
				this.Visible = false;
			}
		}

		/// <summary>
		/// 닫기버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseButtonClick(object sender, EventArgs e)
		{
			if(this.Visible == true)
			{
				this.Visible = false;
			}
		}
	}
}
