
// MainForm.cs
//
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 메인폼 클래스입니다.
	/// </summary>
	public partial class MainForm : Office2007RibbonForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public MainForm()
		{
			this.m_dockingManager = new DockingManager(this);
			InitializeComponent();
		}

		/// <summary>
		/// 새로운 오브젝트 브라우저를 생성합니다.
		/// </summary>
		/// <param name="dockSide">오브젝트 브라우저의 도킹위치입니다.</param>
		/// <param name="size">오브젝트 브라우저의 크기입니다.</param>
		private void CreateObjectBrowser(eDockSide dockSide, Size size)
		{
			this.m_objectBrowser = new ObjectBrowser("오브젝트 브라우저");
			this.m_objectBrowser.Size = size;

			this.m_dockingManager.Dock(this.m_objectBrowser, dockSide);
		}

		/// <summary>
		/// 메세지 윈도우를 생성합니다.
		/// </summary>
		/// <param name="dockSide">메세지 윈도우의 도킹위치입니다.</param>
		/// <param name="size">메세지 윈도우의 사이즈입니다.</param>
		private void CreateMessageWindow(eDockSide dockSide, Size size)
		{
			this.m_messageWindow = new MessageWindow("메세지 창");
			this.m_messageWindow.Size = size;

			this.m_dockingManager.Dock(this.m_messageWindow, dockSide);
		}

		/// <summary>
		/// 새로운 도큐먼트를 생성합니다.
		/// </summary>
		/// <param name="type">도큐먼트의 타입입니다.</param>
		private void CreateNewDocument(DocumentType type)
		{
			DockContainerItem documentItem = new DockContainerItem();

			switch(type)
			{
				case DocumentType.QueryEditor:
					this.m_queryEditorsCount++;
					documentItem.Control = new QueryEditor();
					documentItem.Text = "QueryEditor" + this.m_queryEditorsCount.ToString();
					break;

				case DocumentType.QueryBuilder:
//					documentItem.Control = new QueryBuilder();
					break;
			}

			Bar bar = GetFirstDocumentBar();
			bar.Items.Add(documentItem);
			if(!bar.Visible)
				bar.Visible = true;

			bar.SelectedDockTab = bar.Items.IndexOf(documentItem);
			bar.DockTabControl.CloseButtonPosition = eTabCloseButtonPosition.Right;
			bar.DockTabControl.CloseButtonOnTabsVisible = true;
			bar.DockTabControl.TabLayoutType = eTabLayoutType.MultilineNoNavigationBox;
			bar.RecalcLayout();
		}

		/// <summary>
		/// 가장 첫번째 도큐먼트 바의 객체를 가져옵니다.
		/// </summary>
		/// <returns>첫번째 도큐먼트 바 객체입니다.</returns>
		private Bar GetFirstDocumentBar()
		{
			foreach(Bar b in this.m_dockingManager.Bars)
			{
				if(b.DockSide == eDockSide.Document && b.Visible)
					return b;
			}
			Bar bar = BarUtilities.CreateDocumentBar();
			bar.DockTabClosing += new DockTabClosingEventHandler(DockableTabClosing);
			this.m_dockingManager.FillDockSite.GetDocumentUIManager().Dock(bar);

			return bar;
		}

		/// <summary>
		/// OnShown 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			this.OnNewConnectionClick(this, null);
		}

		/// <summary>
		/// OnClose 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			Program.CoummunicatorList.DisconnectAll();
		}

		/// <summary>
		/// 종료하기 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnQuitApplicationClick(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 테마커맨드 이벤트입니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected void OnExecutedThemeCommand(object sender, System.EventArgs e)
		{
			ICommandSource source = sender as ICommandSource;
			if(source.CommandParameter is string)
			{
				eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
				// Using StyleManager change the style and color tinting
				StyleManager.ChangeStyle(style, Color.Empty);
			}
		}

		/// <summary>
		/// 탭이 닫힐 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void DockableTabClosing(object sender, DockTabClosingEventArgs e)
		{
			e.RemoveDockTab = true;
			if(((Bar)sender).Items.Count == 1)
				this.m_dockingManager.Bars.Remove((Bar)sender);
		}

		/// <summary>
		/// 새로운연결 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnNewConnectionClick(object sender, EventArgs e)
		{
			ConnectForm connectForm = new ConnectForm();
			DialogResult dlgResult = connectForm.ShowDialog(this);
			if(dlgResult == DialogResult.OK)
			{
				CreateObjectBrowser(eDockSide.Left, new Size(250, 100));
				CreateMessageWindow(eDockSide.Bottom, new Size(100, 250));
				CreateNewDocument(DocumentType.QueryEditor);
			}
			else if(dlgResult == DialogResult.Cancel)
				return;

			this.m_objectBrowser.Tree.UpdateTree();
			this.m_objectBrowser.Tree.ActivateConnection = Program.CoummunicatorList.Count - 1;
			this.m_objectBrowser.Tree.SelectedNode.Expand();
		}

		/// <summary>
		/// 연결종료 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDisconnectMySqlClick(object sender, EventArgs e)
		{
			if(Program.ActivateCommunicator != null)
			{
				Program.ActivateCommunicator.Disconnect();
				Program.ActivateCommunicator = null;
				if(Program.CoummunicatorList.Count == 0)
					this.m_dockingManager.Bars.Clear();
				
				else
					this.m_objectBrowser.Tree.UpdateTree();
			}
		}

		/// <summary>
		/// 모든연결종료 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDisconnectAllMySqlClick(object sender, EventArgs e)
		{
			Program.CoummunicatorList.DisconnectAll();
			this.m_dockingManager.Bars.Clear();
		}

		/// <summary>
		/// 새로고침 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnRefreshObjectBrowserClick(object sender, EventArgs e)
		{
			this.m_objectBrowser.Tree.UpdateTree();
		}

		/// <summary>
		/// 새 쿼리에디터 만들기 버튼을 클릭하였을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnNewQueryEditorClick(object sender, EventArgs e)
		{
			CreateNewDocument(DocumentType.QueryEditor);
		}

		/// <summary>
		/// 사용자추가 버튼을 클릭하였을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCreateUserClick(object sender, EventArgs e)
		{
			new CreateUserForm().ShowDialog(this);
		}

		/// <summary>
		/// 사용자수정 버튼을 클릭하였을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnAlterUserClick(object sender, EventArgs e)
		{
			new AlterUserForm().ShowDialog(this);
		}

		/// <summary>
		/// 데이터베이스 만들기 버튼을 클릭하였을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCreateDatabaseClick(object sender, EventArgs e)
		{
			CreateDatabaseForm createDatabaseForm = new CreateDatabaseForm();
			createDatabaseForm.ShowDialog(this);
			if(createDatabaseForm.DialogResult == DialogResult.Yes)
			{
				int selecteIndex = this.m_objectBrowser.Tree.SelectedIndex;
				this.m_objectBrowser.Tree.UpdateTree();
				this.m_objectBrowser.Tree.SelectedIndex = selecteIndex;
				this.m_objectBrowser.Tree.SelectedNode.Expand();
			}
		}

		private int m_queryEditorsCount;
		private DockingManager m_dockingManager;
		private ObjectBrowser m_objectBrowser;
		private MessageWindow m_messageWindow;
	}

	/// <summary>
	/// 탭문서 형색을 나타내는 열거형입니다.
	/// </summary>
	public enum DocumentType
	{
		QueryEditor,
		QueryBuilder,
	}
}
