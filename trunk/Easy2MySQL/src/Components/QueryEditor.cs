﻿
// QueryEditor.cs
//
using System;
using System.Drawing;
using ScintillaNet;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Easy2.Components
{
	/// <summary>
	/// 쿼리문을 입력 및 편집할 수 있는 에디터클래스입니다.
	/// </summary>
	public class QueryEditor : Scintilla
	{
		/// <summary>
		/// QueryEditor 인스턴스를 초기화합니다.
		/// </summary>
		public QueryEditor()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 컴포넌트를 초기화합니다.
		/// </summary>
		private void InitializeComponent()
		{
			this.ConfigurationManager.CustomLocation = "..\\..\\xml";
			this.ConfigurationManager.Language = "mysql";

			this.Margins.Margin0.Type = MarginType.Symbol;
			this.Margins.Margin0.Width = 10;
			this.Margins.Margin1.Type = MarginType.Number;
			
			this.Styles.LineNumber.BackColor = Color.White;

			this.LineWrap.Mode = WrapMode.Word;
		}

		/// <summary>
		/// 쿼리문을 SQL파일에 씁니다.
		/// </summary>
		public void WriteQueryToSqlFile()
		{
			WriteQueryToSqlFile(this.m_sqlPath);
		}

		/// <summary>
		/// 쿼리문을 SQL파일에 씁니다.
		/// </summary>
		/// <param name="path">파일 경로입니다.</param>
		public void WriteQueryToSqlFile(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs, Encoding.Default);

			sw.WriteLine(this.Text);
			

			sw.Close();
			fs.Close();

			this.m_sqlPath = path;
		}

		/// <summary>
		/// 쿼리문을 SQL파일에서 읽어옵니다.
		/// </summary>
		/// <param name="path">파일 경로입니다.</param>
		public void ReadQueryFromSqlFile(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sw = new StreamReader(fs, Encoding.Default);

			this.Text = sw.ReadToEnd();

			sw.Close();
			fs.Close();

			this.m_sqlPath = path;
		}

		/// <summary>
		/// 파일 경로를 나타냅니다.
		/// </summary>
		public string Path
		{
			get { return this.m_sqlPath; }
		}

		/// <summary>
		/// 현재 에디트창의 주석문을 제외한 쿼리문만을 파싱합니다.
		/// </summary>
		public string[] ParseQuery()
		{
			string singlePattern = "--(.*)";	// 단일라인 주석 찾는 정규식
			string multiPattern = "(/\\*)(.|\\s)*?(\\*/)";	// 다중라인 주석 찾는 정규식
			StringBuilder builder = new StringBuilder(this.Text);

			Regex regex = new Regex(singlePattern);
			MatchCollection matches = regex.Matches(builder.ToString());

			foreach(Match match in matches)
			{
				builder.Replace(match.Value, "");	// 주석을 찾아서 지움
			}

			regex = new Regex(multiPattern);
			matches = regex.Matches(builder.ToString());

			foreach(Match match in matches)
			{
				builder.Replace(match.Value, "");	// 주석을 찾아서 지움
			}

			string[] split = builder.ToString().Trim().Split(';');
			string[] queries = new string[split.Length];

			for(int i = 0; i < queries.Length; i++)
			{
				queries[i] = split[i].Trim() + ";";
			}
				
			return queries;
		}

		private string m_sqlPath = null;
	}
}
