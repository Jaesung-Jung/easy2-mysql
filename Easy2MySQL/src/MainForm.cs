
// MainForm.cs
//
using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Collections.Generic;

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
		/// OnLoad 이벤트 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트 객체입니다.</param>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			CreateObjectBrowser(eDockSide.Left, new Size(250, 100));
			CreateNewDocument(DocumentType.QueryEditor);
		}

		/// <summary>
		/// 테마커맨드 이벤트입니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트정보 객체입니다.</param>
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
		/// 새로운 오브젝트 브라우저를 생성합니다.
		/// </summary>
		/// <param name="dockSide">오브젝트 브라우저의 도킹위치입니다.</param>
		/// <param name="size">오브젝트 브라우저의 크기입니다.</param>
		private void CreateObjectBrowser(eDockSide dockSide, Size size)
		{
			this.m_objectBrowser = new ObjectBrowser();
			this.m_objectBrowser.Text = "오브젝트 브라우저";
			this.m_objectBrowser.Size = size;

			this.m_dockingManager.Dock(this.m_objectBrowser, dockSide);
		}

		/// <summary>
		/// 새로운 도큐먼트를 생성합니다.
		/// </summary>
		/// <param name="type">도큐먼트의 타입입니다.</param>
		private void CreateNewDocument(DocumentType type)
		{
			DockContainerItem documentItem = new DockContainerItem();
			if(type == DocumentType.QueryEditor)
			{
				this.m_queryEditorsCount++;
				QueryEditor queryEditor = new QueryEditor();
				documentItem.Control = queryEditor;
				documentItem.Text = "QueryEditor" + this.m_queryEditorsCount.ToString();
				this.m_queryEditors.Add(queryEditor);
			}
//			else if(type == DocumentType.QueryBuilder)
//				documentItem.Control = new QueryBuilder();
			Bar bar = GetFirstDocumentBar();
			bar.Items.Add(documentItem);
			if(!bar.Visible)
				bar.Visible = true;
			bar.SelectedDockTab = bar.Items.IndexOf(documentItem);
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
			this.m_dockingManager.FillDockSite.GetDocumentUIManager().Dock(bar);

			return bar;
		}

		#region 이벤트
		/// <summary>
		/// 새 쿼리에디터 만들기 버튼을 클릭하였을 경우의 이벤트입니다.
		/// </summary>
		/// <param name="sender">이벤트를 호출한 객체입니다.</param>
		/// <param name="e">이벤트 객체입니다.</param>
		private void m_newQueryEditor_Click(object sender, EventArgs e)
		{
			CreateNewDocument(DocumentType.QueryEditor);
		}
		#endregion

		private int m_queryEditorsCount;
		private DockingManager m_dockingManager;							// 도킹 매니저
		private ObjectBrowser m_objectBrowser;								// 오브젝트 브라우저
		private List<QueryEditor> m_queryEditors = new List<QueryEditor>();	// 쿼리에디터 리스트
	}

	public enum DocumentType
	{
		QueryEditor,
		QueryBuilder,
	}
}
