
// SyntaxHighlightTextBox.cs
//
using System;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace System.Windows.Forms
{
	/// <summary>
	/// 문자열을 분석하여 지정된 구문의 색상을 변경하는 텍스트박스 컨트롤입니다.
	/// 작성자 : 정재성
	/// </summar>
	public class SyntaxHighlightTextBox : RichTextBox
	{
		#region Control attribute
		private List<string> m_keywords = new List<string>();			// 키워드 리스트
		private List<string> m_functions = new List<string>();			// 함수 리스트
		private List<string> m_others = new List<string>();				// 기타구문 리스트
		private string m_singleLineCommentBegin = "//";					// 단일라인주석 시작형식
		private bool m_enableKeywords = true;							// 키워드 사용여부
		private bool m_enableFunctions = false;							// 함수 사용여부
		private bool m_enableOthers = false;							// 기타구문 사용여부
		private bool m_enableSingleLineComment = true;					// 단일라인주석 사용여부
		private bool m_enableString = true;								// 문자열형식 사용여부
		private bool m_enableCharacter = true;							// 문자형식 사용여부
		private bool m_enableInteger = false;							// 숫자형식 사용여부
		private bool m_enableCaseSenstive = false;						// 대소문자 구분여부
		private Color m_colorKeywordsHighlight = Color.Blue;			// 키워드 색상
		private Color m_colorFunctionsHighlight = Color.Brown;			// 함수 색상
		private Color m_colorOthersHighlight = Color.Navy;				// 기타구문 색상
		private Color m_colorSingleLineCommenHighlight = Color.Green;	// 단일라인주석 색상
		private Color m_colorStringHighlight = Color.Red;				// 문자열색상
		private Color m_colorCharacterHighlight = Color.Red;			// 문자 색상
		private Color m_colorIntegerHighlight = Color.Black;			// 숫자 색상
		#endregion
		private string m_regexKeywords = "";							// 키워드 정규식
		private string m_regexFunctions = "";							// 함수 정규식
		private string m_regexOthers = "";								// 기타구문 정규식
		private bool m_isPaint = true;									// 화면을 새로 그릴지 여부
		private bool m_isIMEComposition = false;						// 한글이 조립중인지 판단
		private bool m_isEnterKeyDown = false;							// 엔터키가 눌러졌는지 판단
		private bool m_isCompileHighlightWord = false;					// 강조 될 단어가 컴파일 되었는지 판단

		/// <summary>
		/// WndProc의 재정의입니다.
		/// </summary>
		/// <param name="m">윈도우메세지 객체입니다.</param>
		protected override void WndProc(ref Message m)
		{
			switch(m.Msg)
			{
				case 0x000F: // WM_PAINT
					if(this.m_isPaint)
						base.WndProc(ref m);
					else
						m.Result = IntPtr.Zero;
					break;

				case 0x010D: // WM_IME_STARTCOMPOSITION
					this.m_isIMEComposition = true;
					base.WndProc(ref m);
					break;

				case 0x010E: // WM_IME_ENDCOMPOSITION
					this.m_isIMEComposition = false;
					base.WndProc(ref m);
					break;

				default:
					base.WndProc(ref m);
					break;
			}
		}

		/// <summary>
		/// OnTextChanged의 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트 아규먼트 객체입니다.</param>
		protected override void OnTextChanged(EventArgs e)
		{
			// 한글조립중에 구문분석을 수행하면 한글조립이
			// 완료되어 한글입력이 제대로 되지 않음
			if(!this.m_isIMEComposition)
			{
				this.m_isPaint = false;
				if(this.m_isEnterKeyDown) // 엔터키가 눌러졌으면 이전줄의 구문 다시 분석
				{
					string previousLineText = this.Lines[this.GetCurrentLineIndex() - 1];
					this.SyntaxHighlightProc(previousLineText, this.GetFirstCharIndexOfCurrentLine() - (previousLineText.Length + 1));
					this.m_isEnterKeyDown = false;
				}
				this.SyntaxHighlightProc(this.GetCurrentLineText(), this.GetFirstCharIndexOfCurrentLine());
				this.m_isPaint = true;
			}

			base.OnTextChanged(e);
		}

		/// <summary>
		/// OnKeyDown의 재정의입니다.
		/// </summary>
		/// <param name="e">키 이벤트 아규먼트 객체입니다.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter && this.Lines.Length != 0)
				this.m_isEnterKeyDown = true;

			base.OnKeyDown(e);
		}

		/// <summary>
		/// 입력된 구문을 분석하여 강조합니다.
		/// </summary>
		/// <param name="synxtax">분석할 구문</param>
		/// <param name="startIndex">구문의 시작 인덱스</param>
		private void SyntaxHighlightProc(string syntax, int startIndex)
		{
			if(syntax.Length == 0 || startIndex < 0)
				return;

			if(!this.m_isCompileHighlightWord)
				this.CompileHighlightWord();

			int caretPosition = this.SelectionStart;
			this.SelectionStart = startIndex;
			this.SelectionLength = syntax.Length;
			this.SelectionColor = this.ForeColor;

			if(this.m_enableKeywords)
				this.AnalysisSyntaxAndChangeColor(this.m_regexKeywords, syntax, this.m_colorKeywordsHighlight);
			if(this.m_enableFunctions)
				this.AnalysisSyntaxAndChangeColor(this.m_regexFunctions, syntax, this.m_colorFunctionsHighlight);
			if(this.m_enableOthers)
				this.AnalysisSyntaxAndChangeColor(this.m_regexOthers, syntax, this.m_colorOthersHighlight);
			if(this.m_enableString)
				this.AnalysisSyntaxAndChangeColor("\"[^\"\\\\\\r\\n]*(?:\\\\.[^\"\\\\\\r\\n]*)*\"", syntax, this.m_colorStringHighlight);
			if(this.m_enableCharacter)
				this.AnalysisSyntaxAndChangeColor("\'[^\'\\\\\\r\\n]*(?:\\\\.[^\'\\\\\\r\\n]*)*\'", syntax, this.m_colorCharacterHighlight);
			if(this.m_enableInteger)
				this.AnalysisSyntaxAndChangeColor("\\b(?:[0-9]*\\.)?[0-9]+\\b", syntax, this.m_colorIntegerHighlight);
			if(this.m_enableSingleLineComment && !string.IsNullOrEmpty(this.m_singleLineCommentBegin))
				this.AnalysisSyntaxAndChangeColor(this.m_singleLineCommentBegin + ".*$", syntax, this.m_colorSingleLineCommenHighlight);

			this.SelectionStart = caretPosition;
			this.SelectionLength = 0;
			// 단일라인주석이 입력중이면 전경색을 그대로 유지
			if(!(this.SelectionColor == this.m_colorSingleLineCommenHighlight))
				this.SelectionColor = this.ForeColor;
		}

		/// <summary>
		/// 입력된 구문을 정규표현식으로 분석하여 색상을 변경합니다.
		/// </summary>
		/// <param name="regularExpression">정규표현식</param>
		/// <param name="syntax">분석할 구문</param>
		/// <param name="color">변경할 색상</param>
		private void AnalysisSyntaxAndChangeColor(string regularExpression, string syntax, Color color)
		{
			Regex regex = m_enableCaseSenstive ?
				new Regex(regularExpression, RegexOptions.Compiled) : new Regex(regularExpression, RegexOptions.IgnoreCase | RegexOptions.Compiled);

			for(Match match = regex.Match(syntax) ; match.Success ; match = match.NextMatch())
			{
				this.SelectionStart = this.GetFirstCharIndexOfCurrentLine() + match.Index;
				this.SelectionLength = match.Length;
				this.SelectionColor = color;
			}
		}

		/// <summary>
		/// 입력된 키워드리스트, 함수리스트, 기타구문을 정규표현식으로 만듭니다.
		/// </summary>
		private void CompileHighlightWord()
		{
			StringBuilder regexBuilder = new StringBuilder();

			// Compile keywords
			for(int i = 0 ; i < this.m_keywords.Count ; i++)
				regexBuilder.AppendFormat("\\b{0}\\b|", this.m_keywords[i]);
			if(regexBuilder.Length != 0)
				regexBuilder.Remove(regexBuilder.Length - 1, 1); // 마지막에 위치한 '|' 문자를 제거
			this.m_regexKeywords = regexBuilder.ToString();

			// Compile functions
			regexBuilder.Remove(0, regexBuilder.Length);
			for(int i = 0; i < this.m_functions.Count; i++)
				regexBuilder.AppendFormat("\\b{0}\\b|", this.m_functions[i]);
			if(regexBuilder.Length != 0)
				regexBuilder.Remove(regexBuilder.Length - 1, 1);
			this.m_regexFunctions = regexBuilder.ToString();

			// Compile Others
			regexBuilder.Remove(0, regexBuilder.Length);
			for(int i = 0; i < this.m_others.Count; i++)
				regexBuilder.AppendFormat("\\b{0}\\b|", this.m_others[i]);
			if(regexBuilder.Length != 0)
				regexBuilder.Remove(regexBuilder.Length - 1, 1);
			this.m_regexOthers = regexBuilder.ToString();
		}

		/// <summary>
		/// 현재 캐럿이 위치해 있는 곳의 라인의 텍스트를 가져옵니다.
		/// </summary>
		/// <returns>현재 위치한 라인의 텍스트</returns>
		public string GetCurrentLineText()
		{
			return this.Lines.Length != 0 ? this.Lines[this.GetCurrentLineIndex()] : "";
		}

		/// <summary>
		/// 현재 캐럿이 위치해 있는 곳의 라인의 인덱스를 가져옵니다.
		/// </summary>
		/// <returns>현재 위치한 라인의 인덱스</returns>
		public int GetCurrentLineIndex()
		{
			int stringLengthCurrentPosition = this.SelectionStart;
			int lineCounter = 0;

			foreach(string s in this.Lines)
			{
				if(s.Length != 0)
					stringLengthCurrentPosition -= s.Length + 1;
				else
					stringLengthCurrentPosition--;

				if(stringLengthCurrentPosition < 0)
					break;

				lineCounter++;
			}

			return lineCounter;
		}

		#region Properties
		/// <summary>
		/// 키워드 리스트입니다.
		/// </summary>
		[Category("항목")]
		[Description("키워드 항목입니다.")]
		public List<string> Keywords
		{
			get	{ return this.m_keywords; }
		}
		/// <summary>
		/// 함수 리스트입니다.
		/// </summary>
		[Category("항목")]
		[Description("함수 항목입니다.")]
		public List<string> Functions
		{
			get { return this.m_functions; }
		}
		/// <summary>
		/// 기타구문 리스트입니다.
		/// </summary>
		[Category("항목")]
		[Description("기타 항목입니다.")]
		public List<string> Others
		{
			get { return this.m_others; }
		}
		/// <summary>
		/// 단일라인주석의 시작 형식입니다.
		/// </summary>
		[Category("형식")]
		[DefaultValue("//")]
		[Description("단일라인주석의 시작 형식입니다.")]
		public string SingleLineCommentBegin
		{
			get { return this.m_singleLineCommentBegin; }
			set { this.m_singleLineCommentBegin = value; }
		}
		/// <summary>
		/// 키워드의 강조여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(true)]
		[Description("키워드의 강조여부를 나타냅니다.")]
		public bool EnableKeywords
		{
			get { return this.m_enableKeywords; }
			set { this.m_enableKeywords = value; }
		}
		/// <summary>
		/// 함수의 강조여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(false)]
		[Description("함수의 강조여부를 나타냅니다")]
		public bool EnableFunctions
		{
			get { return this.m_enableFunctions; }
			set { this.m_enableFunctions = value; }
		}
		/// <summary>
		/// 기타구문의 강조여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(false)]
		[Description("기타구문 강조여부를 나타냅니다.")]
		public bool EnableOthers
		{
			get	{ return this.m_enableOthers; }
			set { this.m_enableOthers = value; }
		}
		/// <summary>
		/// 단일라인주석의 강조여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(true)]
		[Description("단일라인주석의 강조여부를 나타냅니다")]
		public bool EnableSingleLineComment
		{
			get { return this.m_enableSingleLineComment; }
			set { this.m_enableSingleLineComment = value; }
		}
		/// <summary>
		/// 문자열형식의 강조여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(true)]
		[Description("문자열형식의 강조여부를 나타냅니다.")]
		public bool EnableString
		{
			get { return this.m_enableString; }
			set { this.m_enableString = value; }
		}
		/// <summary>
		/// 문자형식의 강조여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(true)]
		[Description("문자형식의 강조여부를 나타냅니다.")]
		public bool EnableCharacter
		{
			get { return this.m_enableCharacter; }
			set { this.m_enableCharacter = value; }
		}
		/// <summary>
		/// 숫자형식의 강조여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(false)]
		[Description("숫자형식의 강조여부를 나타냅니다.")]
		public bool EnableInteger
		{
			get { return this.m_enableInteger; }
			set { this.m_enableInteger = value; }
		}
		/// <summary>
		/// 대소문자 구분여부를 나타냅니다.
		/// </summary>
		[Category("동작")]
		[DefaultValue(false)]
		[Description("대소문자 구분여부를 나타냅니다.")]
		public bool EnableCaseSenstive
		{
			get { return this.m_enableCaseSenstive; }
			set { this.m_enableCaseSenstive = value; }
		}
		/// <summary>
		/// 키워드를 강조할 때 나타내는 색상입니다.
		/// </summary>
		[Category("모양")]
		[DefaultValue(typeof(Color), "Blue")]
		[Description("키워드를 강조할 때 나타내는 색상입니다.")]
		public Color KeywordsHighliteColor
		{
			get { return this.m_colorKeywordsHighlight; }
			set { this.m_colorKeywordsHighlight = value; }
		}
		/// <summary>
		/// 함수를 강조할 때 나타내는 색상입니다.
		/// </summary>
		[Category("모양")]
		[DefaultValue(typeof(Color), "Brown")]
		[Description("함수를 강조할 때 나타내는 색상입니다.")]
		public Color FunctionsHighliteColor
		{
			get { return this.m_colorFunctionsHighlight; }
			set { this.m_colorFunctionsHighlight = value; }
		}
		/// <summary>
		/// 기타구문을 강조할 때 나타내는 색상입니다.
		/// </summary>
		[Category("모양")]
		[DefaultValue(typeof(Color), "Navy")]
		[Description("기타구문을 강조할 때 나타내는 색상입니다.")]
		public Color OthersHighliteColor
		{
			get { return this.m_colorOthersHighlight; }
			set { this.m_colorOthersHighlight = value; }
		}
		/// <summary>
		/// 단일라인주석을 강조할 때 나타내는 색상입니다.
		/// </summary>
		[Category("모양")]
		[DefaultValue(typeof(Color), "Green")]
		[Description("단일라인주석을 강조할 때 나타내는 색상입니다.")]
		public Color SingleLineCommentHighliteColor
		{
			get { return this.m_colorSingleLineCommenHighlight; }
			set { this.m_colorSingleLineCommenHighlight = value; }
		}
		/// <summary>
		/// 문자열을 강조할 때 나타내는 색상입니다.
		/// </summary>
		[Category("모양")]
		[DefaultValue(typeof(Color), "Red")]
		[Description("문자열을 강조할 때 나타내는 색상입니다.")]
		public Color StringHighliteColor
		{
			get { return this.m_colorStringHighlight; }
			set { this.m_colorStringHighlight = value; }
		}
		/// <summary>
		/// 문자를 강조할 때 나타내는 색상입니다.
		/// </summary>
		[Category("모양")]
		[DefaultValue(typeof(Color), "Red")]
		[Description("문자를 강조할 때 나타내는 색상입니다.")]
		public Color CharacterHighliteColor
		{
			get { return this.m_colorCharacterHighlight; }
			set { this.m_colorCharacterHighlight = value; }
		}
		/// <summary>
		/// 숫자를 강조할 때 나타내는 색상입니다.
		/// </summary>
		[Category("모양")]
		[DefaultValue(typeof(Color), "Black")]
		[Description("숫자를 강조할 때 나타내는 색상입니다.")]
		public Color IntegerHighliteColor
		{
			get { return this.m_colorIntegerHighlight; }
			set { this.m_colorIntegerHighlight = value; }
		}
		#endregion
	}
}