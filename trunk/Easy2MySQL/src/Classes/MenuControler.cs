
// MenuControler.cs
//
using Easy2.Forms;
using Easy2.Components;
using System;

namespace Easy2.Classes
{
	public class MenuControler
	{
		public MenuControler(MainForm main, ObjectTree tree, QueryEditor editor)
		{
			this.m_main = main;
			this.m_tree = tree;
			this.m_editor = editor;

			InitializeEvent();
		}

		void InitializeEvent()
		{
			this.m_tree.SelectionChanged += new EventHandler(OnTreeSelectionChanged);
			this.m_editor.TextChanged += new EventHandler<EventArgs>(OnEditorTextChanged);
			this.m_editor.SelectionChanged += new EventHandler(OnEditorSelectionChanged);
		}

		void OnEditorSelectionChanged(object sender, EventArgs e)
		{
			if(this.m_editor != null)
			{
				if(this.m_editor.Selection.Length != 0)
				{
					// 선택취소, 지우기, 잘라내기, 복사하기, 선택된 쿼리실행 활성화
					this.m_main.ControlRibbonTabItem2(true, true, true, true, true);
				}
				else
				{
					// 선택취소, 지우기, 잘라내기, 복사하기, 선택된 쿼리실행 비활성화
					this.m_main.ControlRibbonTabItem2(false, false, false, false, false);
				}
			}
		}

		void OnEditorTextChanged(object sender, EventArgs e)
		{
			if(this.m_editor != null)
			{
				if(this.m_editor.Text.Length != 0)
				{
					// 모두선택, 쿼리실행, 모든 쿼리실행 활성화
					this.m_main.ControlRibbonTabItem1(true, true, true);
				}
				else
				{
					// 모두선택, 쿼리실행, 모든 쿼리실행 비활성화
					this.m_main.ControlRibbonTabItem1(false, false, false);
				}
			}
		}

		void OnTreeSelectionChanged(object sender, EventArgs e)
		{
			ObjectNode n = (ObjectNode)(this.m_tree.SelectedNode);

			// 기본적으로 생각할것,
			// 데이터베이스 관련 작업이 문제없이 동작하는 노드 까지 판단
			// 테이블 관련 작업이 문제없이 동작하는 노드 까지 판단
			if(n.NodeType == ObjectNodeType.MySqlDatabase)
			{
				// DB 수정하기 활성화
				// DB 비우기 활성화
				// 테이블 만들기 활성화
			}
			else if(n.NodeType == ObjectNodeType.MySqlTable)
			{
				// 테이블 수정하기 활성화
				// 테이블 비우기 활성화
				// 테이블 제거하기 활성화
			}
			else
			{
				// 모두 비활성화
			}
		}

		public QueryEditor Editor
		{
			set
			{
				this.m_editor.TextChanged -= new EventHandler<EventArgs>(OnEditorTextChanged);
				this.m_editor.SelectionChanged -= new EventHandler(OnEditorSelectionChanged);
				value.TextChanged += new EventHandler<EventArgs>(OnEditorTextChanged);
				value.SelectionChanged += new EventHandler(OnEditorSelectionChanged);
				this.m_editor = value;
			}
		}

		readonly MainForm m_main;
		readonly ObjectTree m_tree;
		QueryEditor m_editor;
	}
}
