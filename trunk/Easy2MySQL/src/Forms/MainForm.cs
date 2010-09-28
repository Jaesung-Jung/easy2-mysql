
// MainForm.cs
//
using Easy2.Properties;
using Easy2.Classes;
using Easy2.Components;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using System.IO;

namespace Easy2.Forms
{
	/// <summary>
	/// 메인폼 클래스입니다.
	/// </summary>
	public partial class MainForm : Office2007RibbonForm
	{
		/// <summary>
		/// MainForm 인스턴스를 초기화합니다.
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
		/// 도킹 컨테이너 아이템바를 생성합니다. 
		/// </summary>
		/// <param name="dockSide">도킹위치 입니다.</param>
		/// <param name="size">바의 크기입니다.</param>
		private void CreateDockContainerItemBar(eDockSide dockSide, Size size)
		{
			this.m_messageWindow = new MessageWindow("메세지 창");
			this.m_tableWindow = new TableWindow("테이블 창");

			this.m_dockContainerItemBar = new Bar();
			this.m_dockContainerItemBar.AccessibleRole = AccessibleRole.ToolBar;
			this.m_dockContainerItemBar.CloseSingleTab = true;
			this.m_dockContainerItemBar.GrabHandleStyle = eGrabHandleStyle.CaptionDotted;
			this.m_dockContainerItemBar.LayoutType = eLayoutType.DockContainer;
			this.m_dockContainerItemBar.Stretch = true;
			this.m_dockContainerItemBar.DockTabChange += new DotNetBarManager.DockTabChangeEventHandler(OnDockTabBarDockTabChange);
			this.m_dockContainerItemBar.Text = this.m_messageWindow.Text;
			this.m_dockContainerItemBar.Size = size;
			this.m_dockContainerItemBar.Items.AddRange(new BaseItem[] { this.m_messageWindow, this.m_tableWindow });
			this.m_dockingManager.Dock(this.m_dockContainerItemBar, dockSide);
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
					QueryEditor queryEditor = new QueryEditor();
					documentItem.Control = queryEditor;
					documentItem.Text = "QueryEditor" + this.m_queryEditorsCount.ToString();
					break;

// 				case DocumentType.QueryBuilder:
// 					documentItem.Control = new QueryBuilder();
// 					break;
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
			bar.DockTabClosing += new DockTabClosingEventHandler(OnDockableTabClosing);
			bar.DockTabChange += new DotNetBarManager.DockTabChangeEventHandler(OnDocumentDockTabChange);
			this.m_dockingManager.FillDockSite.GetDocumentUIManager().Dock(bar);

			return bar;
		}

		/// <summary>
		/// 선택된 탭의 문자열을 변경합니다.
		/// </summary>
		/// <param name="text">변경할 문자열입니다.</param>
		private void SetTextCurrentTab(string text)
		{
			Bar bar = GetFirstDocumentBar();
			bar.Items[bar.SelectedDockTab].Text = text;
		}

		/// <summary>
		/// 쿼리문을 실행하여 쿼리뷰, 메세지창에 결과를 출력합니다.
		/// </summary>
		/// <param name="query">실행할 쿼리문입니다.</param>
		private void ExecuteQuery(string query)
		{
			if(query == null)
				return;

			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(query);
				if(reader.FieldCount == 0)
				{
					this.m_messageWindow.Message = String.Format(Resources.Easy2Message_AffectedRows, reader.RecordsAffected);
					this.m_dockContainerItemBar.SelectedDockTab = this.m_dockContainerItemBar.Items.IndexOf(this.m_messageWindow);
					((ReadonlyTextBox)(this.m_messageWindow.Control)).SelectionLength = 0;
				}
				else
				{
					this.m_tableWindow.Viewer.FillTableData(reader);
					this.m_dockContainerItemBar.SelectedDockTab = this.m_dockContainerItemBar.Items.IndexOf(this.m_tableWindow);
				}

				reader.Close();
			}
			catch(MySqlException ex)
			{
				this.m_messageWindow.Message = String.Format(Resources.Easy2Message_ErrorMessage, query, ex.Number, ex.Message);
				this.m_dockContainerItemBar.SelectedDockTab = this.m_dockContainerItemBar.Items.IndexOf(this.m_messageWindow);
				((ReadonlyTextBox)(this.m_messageWindow.Control)).SelectionLength = 0;

			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		/// <summary>
		/// 폼이 보여질 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			this.OnNewConnectionClick(this, null);
		}

		/// <summary>
		/// 폼이 닫힐 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			Program.CoummunicatorList.DisconnectAll();
		}

		/// <summary>
		/// 종료하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnQuitApplicationClick(object sender, EventArgs e)
		{
			Program.CoummunicatorList.DisconnectAll();
			this.Close();
		}

		/// <summary>
		/// 테마커맨드 이벤트입니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected void OnExecutedThemeCommand(object sender, EventArgs e)
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
		private void OnDockableTabClosing(object sender, DockTabClosingEventArgs e)
		{
			e.RemoveDockTab = true;
			if(((Bar)sender).Items.Count == 1)
				this.m_dockingManager.Bars.Remove((Bar)sender);
		}

		/// <summary>
		/// 도큐먼트 탭이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnDocumentDockTabChange(object sender, DockTabChangeEventArgs e)
		{
			this.m_selectedQueryEditor = (QueryEditor)(((DockContainerItem)(e.NewTab)).Control);
			this.m_selectedQueryEditor.DataBindings.Clear();
			this.m_selectedQueryEditor.DataBindings.Add("Zoom", this.m_zoomSlider, "Value");
 			this.m_zoomSlider.DataBindings.Clear();
 			this.m_zoomSlider.DataBindings.Add("Value", this.m_selectedQueryEditor, "Zoom");
		}

		/// <summary>
		/// 도킹탭이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnDockTabBarDockTabChange(object sender, DockTabChangeEventArgs e)
		{
			this.m_dockContainerItemBar.Text = e.NewTab.Text;
		}

		/// <summary>
		/// 슬라이더의 값이 변경되면 호출됩니다.
		/// </summary>
		/// <remarks>
		/// 슬라이더의 현재값을 Percentage형태로 나타냅니다.
		/// </remarks>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnZoomSliderValueChanged(object sender, EventArgs e)
		{
 			int pecentage = 100 + ((this.m_zoomSlider.BaseValue / this.m_zoomSlider.Step) * 10);
 			pecentage = pecentage == 0 ? 5 : pecentage;
 
 			this.m_zoomSlider.Text = String.Format(@"{0}%", pecentage.ToString());
		}
		
		/// <summary>
		/// 새로운연결 버튼을 클릭하면 호출됩니다.
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
				CreateDockContainerItemBar(eDockSide.Bottom, new Size(100, 250));
				CreateNewDocument(DocumentType.QueryEditor);
			}
			else if(dlgResult == DialogResult.Cancel)
				return;

			this.m_objectBrowser.Tree.UpdateTree();
			this.m_objectBrowser.Tree.ActivateConnection = Program.CoummunicatorList.Count - 1;
			this.m_objectBrowser.Tree.SelectedNode.Expand();
		}

		/// <summary>
		/// 연결종료 버튼을 클릭하면 호출됩니다.
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
		/// 불러오기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnOpenFileInSameTabClick(object sender, EventArgs e)
		{
			OpenFileDialog OpenFileDialog = new OpenFileDialog();
			OpenFileDialog.InitialDirectory = "C:\\";
			OpenFileDialog.Title = "열기";
			OpenFileDialog.Filter = "SQL 파일(*.sql)|*.sql";

			if (OpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.SetTextCurrentTab(OpenFileDialog.SafeFileName);
				this.m_selectedQueryEditor.ReadQueryFromSqlFile(OpenFileDialog.FileName);
			}
		}

		/// <summary>
		/// 새 탭에 불러오기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnOpenFileInNewTabClick(object sender, EventArgs e)
		{
			OpenFileDialog OpenFileDialog = new OpenFileDialog();
			OpenFileDialog.InitialDirectory = "C:\\";
			OpenFileDialog.Title = "열기";
			OpenFileDialog.Filter = "SQL 파일(*.sql)|*.sql";

			if (OpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				CreateNewDocument(DocumentType.QueryEditor);
				this.SetTextCurrentTab(OpenFileDialog.SafeFileName);
				this.m_selectedQueryEditor.ReadQueryFromSqlFile(OpenFileDialog.FileName);
			}
		}

		/// <summary>
		/// 저장하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnSaveFileClick(object sender, EventArgs e)
		{
			if (this.m_selectedQueryEditor.Path == null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.InitialDirectory = "C:\\";
				saveFileDialog.Title = "다른이름으로 저장";
				saveFileDialog.Filter = "SQL 파일(*.sql)|*.sql";

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.m_selectedQueryEditor.WriteQueryToSqlFile(saveFileDialog.FileName);
					this.SetTextCurrentTab(Path.GetFileName(saveFileDialog.FileName));
				}
			}
			else
			{
				this.m_selectedQueryEditor.WriteQueryToSqlFile();
			}
		}

		/// <summary>
		/// 다른 이름으로 저장하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnSaveAsClick(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = "C:\\";
			saveFileDialog.Title = "다른 이름으로 저장";
			saveFileDialog.Filter = "SQL 파일(*.sql)|*.sql";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_selectedQueryEditor.WriteQueryToSqlFile(saveFileDialog.FileName);
				this.SetTextCurrentTab(Path.GetFileName(saveFileDialog.FileName));
			}
		}

		/// <summary>
		/// 모든연결종료 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDisconnectAllMySqlClick(object sender, EventArgs e)
		{
			Program.CoummunicatorList.DisconnectAll();
			this.m_dockingManager.Bars.Clear();
		}

		/// <summary>
		/// 새 쿼리에디터 만들기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnNewQueryEditorClick(object sender, EventArgs e)
		{
			CreateNewDocument(DocumentType.QueryEditor);
		}

		/// <summary>
		/// 탭 닫기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseTabClick(object sender, EventArgs e)
		{
			Bar bar = GetFirstDocumentBar();

			DockContainerItem previousItem = null; // 이전 탭
			DockContainerItem currentItem = null;  // 현재 탭

			// 바에서 탭아이템을 삭제할 경우 가장 첫번째 아이템이 선택됨
			// 그에따라 이전아이템을 참조하면서 삭제 될 때 이전 아이템을 선택하도록 함
			for(int i = 0; i < bar.Items.Count; i++)
			{
				previousItem = currentItem;
				currentItem = (DockContainerItem)(bar.Items[i]);

				if(currentItem.Control == this.m_selectedQueryEditor)
				{
					bar.Items.Remove(currentItem);
					if(previousItem != null)
						bar.SelectedDockTab = bar.Items.IndexOf(previousItem);

					break;
				}
			}
		}

		/// <summary>
		/// 새로고침 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnRefreshObjectBrowserClick(object sender, EventArgs e)
		{
			this.m_objectBrowser.Tree.UpdateTree();
		}

		/// <summary>
		/// 붙여넣기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnPasteToClipboardClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.Clipboard.Paste();
		}

		/// <summary>
		/// 잘라내기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCutSelectionClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.Clipboard.Cut();
		}

		/// <summary>
		/// 복사하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCopySelectionClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.Clipboard.Copy();
		}

		/// <summary>
		/// 찾기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnFindDataClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.FindReplace.ShowFind();
		}

		/// <summary>
		/// 바꾸기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnReplaceDataClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.FindReplace.ShowReplace();
		}

		/// <summary>
		/// 바로가기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnGoToLineClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.GoTo.ShowGoToDialog();
		}

		/// <summary>
		/// 모두선택 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnSelectAllClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.Selection.SelectAll();
		}

		/// <summary>
		/// 선택취소 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCancelSelectionClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.Selection.SelectNone();
		}

		/// <summary>
		/// 지우기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnClearSelectionClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.Selection.Clear();
		}

		/// <summary>
		/// 입력취소 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnUndoActionClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.UndoRedo.Undo();
		}

		/// <summary>
		/// 다시입력 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnRedoActionClick(object sender, EventArgs e)
		{
			this.m_selectedQueryEditor.UndoRedo.Redo();
		}

		/// <summary>
		/// 쿼리 실행하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnExecuteQueryClick(object sender, EventArgs e)
		{
			// 쿼리문을 파싱합니다.
			string[] queries = this.m_selectedQueryEditor.ParseQuery();
			if((queries.Length > 0) && (queries[queries.Length - 1] != null))
				ExecuteQuery(queries[queries.Length - 1]);
			else if((queries.Length > 1) && (queries[queries.Length - 2] != null))
				ExecuteQuery(queries[queries.Length - 2]);
		}

		/// <summary>
		/// 선택된 쿼리 실행하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnExecuteSelectQueryClick(object sender, EventArgs e)
		{
			string[] queries = this.m_selectedQueryEditor.ParseQuery(this.m_selectedQueryEditor.Selection.Text);
			foreach(string query in queries)
			{
				if(query != null && query.Length > 0)
					ExecuteQuery(query);
			}
		}

		/// <summary>
		/// 모든 쿼리 실행하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnExecyteAllQueryClick(object sender, EventArgs e)
		{
			string[] queries = this.m_selectedQueryEditor.ParseQuery();
			foreach(string query in queries)
			{
				if(query != null && query.Length > 0)
					ExecuteQuery(query);
			}
		}

		/// <summary>
		/// 사용자추가 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCreateUserClick(object sender, EventArgs e)
		{
			new CreateUserForm().ShowDialog(this);
		}

		/// <summary>
		/// 사용자수정 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnAlterUserClick(object sender, EventArgs e)
		{
			new AlterUserForm().ShowDialog(this);
		}

		/// <summary>
		/// 사용자권한 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnPrivilegeUserClick(object sender, EventArgs e)
		{
			new ManagePrivilegesUserForm().ShowDialog(this);
		}

		/// <summary>
		/// 데이터베이스 만들기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCreateDatabaseClick(object sender, EventArgs e)
		{
			CreateDatabaseForm createDatabaseForm = new CreateDatabaseForm();
			createDatabaseForm.ShowDialog(this);
			if(createDatabaseForm.DialogResult == DialogResult.Yes)
			{
				this.m_objectBrowser.Tree.InsertDatabase(createDatabaseForm.CreatedDatabaseName);
			}
		}

		/// <summary>
		/// 데이터베이스 수정하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnAlterDatabaseClick(object sender, EventArgs e)
		{
			ObjectNode node = (ObjectNode)(this.m_objectBrowser.Tree.SelectedNode);
			if(node.NodeType != ObjectNodeType.MySqlDatabase)
				return;

			string dbname = this.m_objectBrowser.Tree.SelectedNode.Text;

			AlterDatabaseForm alterDatabaseForm = new AlterDatabaseForm(dbname);
			alterDatabaseForm.ShowDialog(this);
		}

		/// <summary>
		/// 테이블 비우기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnTruncateDatabaseClick(object sender, EventArgs e)
		{
			String dbname = Program.ActivateCommunicator.UseDatabaseName;
			DialogResult result = MessageBoxEx.Show(
				this, String.Format(Resources.Easy2Message_TruncateDatabaseQuestion, dbname), Resources.Easy2Message_Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				try
				{
					bool dropViews = false;
					bool dropProcs = false;
					bool dropFuncs = false;
					bool dropEvents = false;
					bool dropTriggers = false;

					if(Program.ActivateCommunicator.v500)
					{
						dropViews = true;
						dropProcs = true;
						dropFuncs = true;
					}
					if(Program.ActivateCommunicator.v510)
					{
						dropEvents = true;
						dropTriggers = true;
					}
					Program.ActivateCommunicator.TrucateDatabase(dbname, true, dropViews, dropProcs, dropFuncs, dropEvents, dropTriggers);
					this.m_objectBrowser.Tree.TrucateDatabase(dbname);
				}
				catch(MySqlException ex)
				{
					EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				}
			}
		}

		/// <summary>
		/// 데이터베이스 제거하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDropDatabaseClick(object sender, EventArgs e)
		{
			String dbname = Program.ActivateCommunicator.UseDatabaseName;
			DialogResult result = MessageBoxEx.Show(
				this, String.Format(Resources.Easy2Message_DropDatabaseQuestion, dbname), Resources.Easy2Message_Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				try
				{
					Program.ActivateCommunicator.DropDatabase(dbname);
					this.m_objectBrowser.Tree.DeleteDatabase(dbname);
				}
				catch(MySqlException ex)
				{
					EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				}
			}
		}

		/// <summary>
		/// 테이블만들기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCreateTableClick(object sender, EventArgs e)
		{
			CreateTableForm createTableForm = new CreateTableForm();
			createTableForm.ShowDialog(this);
			if(createTableForm.DialogResult == DialogResult.OK)
			{
				this.m_objectBrowser.Tree.AddTable(
					Program.ActivateCommunicator.UseDatabaseName,
					createTableForm.CreateTableName
					);
			}
		}

		private int m_queryEditorsCount;
		private QueryEditor m_selectedQueryEditor;
		private DockingManager m_dockingManager;
		private ObjectBrowser m_objectBrowser;
		private MessageWindow m_messageWindow;
		private TableWindow m_tableWindow;
		private Bar m_dockContainerItemBar;
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
