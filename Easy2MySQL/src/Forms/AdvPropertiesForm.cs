
// AdvPropertiesForm.cs
//
using Easy2.Classes;
using System;
using System.ComponentModel;

namespace Easy2.Forms
{
	public partial class AdvPropertiesForm : BaseForm
	{
		/// <summary>
		/// AdvPropertiesForm 컴포넌트를 초기화합니다.
		/// </summary>
		public AdvPropertiesForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 폼이 보여질 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnShown(EventArgs e)
		{
			this.m_engineCombo.Items.Add("[Default]");
			this.m_engineCombo.Items.AddRange(Program.ActivateCommunicator.GetEngines());
			this.m_engineCombo.SelectedIndex = 0;

			this.m_charsetCombo.Items.Add("[Default]");
			this.m_charsetCombo.Items.AddRange(Program.ActivateCommunicator.GetCharset());
			this.m_charsetCombo.SelectedIndex = 0;

			this.m_collationCombo.Items.Add("[Default]");
			this.m_collationCombo.SelectedIndex = 0;

			this.m_rowformatCombo.Items.AddRange(new string[]{
				"[Default]",
				"Compressed",
				"Dynamic",
				"Fixed"
			});
			this.m_rowformatCombo.SelectedIndex = 0;

			this.m_checksumCombo.Items.AddRange(new string[]{
				"[Default]",
				"0",
				"1"
			});
			this.m_checksumCombo.SelectedIndex = 0;

			base.OnShown(e);
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
