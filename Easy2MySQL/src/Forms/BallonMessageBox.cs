
// BalloonMessageBox.cs
//
using Easy2.Properties;
using System;
using System.Windows.Forms;
using System.Drawing;
using DevComponents.DotNetBar;

namespace Easy2.Forms
{
	/// <summary>
	/// 풍선 메세지박스입니다.
	/// </summary>
	public partial class BallonMessageBox : Balloon
	{
		/// <summary>
		/// 컴포넌트들을 초기화합니다.
		/// </summary>
		public BallonMessageBox()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 메세지를 표시하는 레이블의 크기가 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnMessageSizeChanged(object sender, EventArgs e)
		{
			Size labelSize = this.m_msgLabel.Size;
			Size clientSize = this.Size;
			this.Size = new Size(labelSize.Width + 50, clientSize.Height);
		}

		/// <summary>
		/// 메세지박스를 표시합니다.
		/// </summary>
		/// <param name="msg">메세지박스에 나타낼 메세지입니다.</param>
		/// <param name="icon">메세지박스에 표시할 아이콘입니다.</param>
		public void ShowMessageBox(string msg, MessageBoxIcon icon = MessageBoxIcon.None)
		{
			this.BoxIcon = icon;
			this.m_msgLabel.Text = msg;
			base.Show();
		}

		/// <summary>
		/// 메세지박스를 표시합니다.
		/// </summary>
		/// <param name="msg">메세지박스에 나타낼 메세지입니다.</param>
		/// <param name="balloonFocus">메세지박스 포커스여부입니다.</param>
		/// <param name="icon">메세지박스에 표시할 아이콘입니다.</param>
		public void ShowMessageBox(string msg, bool balloonFocus, MessageBoxIcon icon = MessageBoxIcon.None)
		{
			this.BoxIcon = icon;
			this.m_msgLabel.Text = msg;
			base.Show(balloonFocus);
		}

		/// <summary>
		/// 메세지박스를 표시합니다.
		/// </summary>
		/// <param name="referenceControl">참조할 컨트롤입니다.</param>
		/// <param name="msg">메세지박스에 나타낼 메세지입니다.</param>
		/// <param name="icon">메세지박스에 표시할 아이콘입니다.</param>
		public void ShowMessageBox(Control referenceControl, string msg, MessageBoxIcon icon = MessageBoxIcon.None)
		{
			this.BoxIcon = icon;
			this.m_msgLabel.Text = msg;
			base.Show(referenceControl);
		}

		/// <summary>
		/// 메세지박스를 표시합니다.
		/// </summary>
		/// <param name="owner">메세지박스를 소유한 오너 윈도우객체입니다.</param>
		/// <param name="msg">메세지박스에 나타낼 메세지입니다.</param>
		/// <param name="icon">메세지박스에 표시할 아이콘입니다.</param>
		public void ShowMessageBox(IWin32Window owner, string msg, MessageBoxIcon icon = MessageBoxIcon.None)
		{
			this.BoxIcon = icon;
			this.m_msgLabel.Text = msg;
			base.Show(owner);
		}

		/// <summary>
		/// 메세지박스를 표시합니다.
		/// </summary>
		/// <param name="item">베이스 아이템입니다.</param>
		/// <param name="msg">메세지박스에 나타낼 메세지입니다.</param>
		/// <param name="balloonFocus">메세지박스 포커스여부입니다.</param>
		/// <param name="icon">메세지박스에 표시할 아이콘입니다.</param>
		public void ShowMessageBox(BaseItem item, string msg, bool balloonFocus, MessageBoxIcon icon = MessageBoxIcon.None)
		{
			this.BoxIcon = icon;
			this.m_msgLabel.Text = msg;
			base.Show(item, balloonFocus);
		}

		/// <summary>
		/// 메세지박스를 표시합니다.
		/// </summary>
		/// <param name="referenceControl">참조할 컨트롤입니다.</param>
		/// <param name="msg">메세지박스에 나타낼 메세지입니다.</param>
		/// <param name="balloonFocus">메세지박스 포커스여부입니다.</param>
		/// <param name="icon">메세지박스에 표시할 아이콘입니다.</param>
		public void ShowMessageBox(Control referenceControl, string msg, bool balloonFocus, MessageBoxIcon icon = MessageBoxIcon.None)
		{
			this.BoxIcon = icon;
			this.m_msgLabel.Text = msg;
			base.Show(referenceControl, balloonFocus);
		}

		/// <summary>
		/// 메세지박스를 표시합니다.
		/// </summary>
		/// <param name="referenceScreenRect">참조할 스크린의 크기입니다.</param>
		/// <param name="msg">메세지박스에 나타낼 메세지입니다.</param>
		/// <param name="balloonFocus">메세지박스 포커스여부입니다.</param>
		/// <param name="icon">메세지박스에 표시할 아이콘입니다.</param>
		public void ShowMessageBox(Rectangle referenceScreenRect, string msg, bool balloonFocus, MessageBoxIcon icon = MessageBoxIcon.None)
		{
			this.BoxIcon = icon;
			this.m_msgLabel.Text = msg;
			base.Show(referenceScreenRect, balloonFocus);
		}

		public void HideMessageBox()
		{
			base.Visible = false;
		}

		/// <summary>
		/// 메세지박스에 표시될 아이콘을 나타냅니다.
		/// </summary>
		public MessageBoxIcon BoxIcon
		{
			get { return this.m_icon; }
			set
			{
				this.m_icon = value;
				switch((int)this.m_icon)
				{
					case 0:		// 아이콘 없음
						this.m_iconLabel.Image = null;
						break;
					case 16:	// 에러 아이콘
						this.m_iconLabel.Image = Resources.MessageBoxError;
						break;
					case 32:	// 물음표 아이콘
						this.m_iconLabel.Image = Resources.MessageBoxQuestion;
						break;
					case 48:	// 경고 아이콘
						this.m_iconLabel.Image = Resources.MessageBoxWarning;
						break;
					case 64:	// 느낌표 아이콘
						this.m_iconLabel.Image = Resources.MessageBoxInformation;
						break;
				}
			}
		}

		private MessageBoxIcon m_icon;
	}
}
