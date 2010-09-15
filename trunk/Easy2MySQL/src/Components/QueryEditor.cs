
// QueryEditor.cs
//
using System;
using System.Drawing;
using ScintillaNet;
using System.IO;
using System.Text;
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
		/// 
		/// </summary>
		public void WriteQueryToSqlFile()
		{
			WriteQueryToSqlFile(this.m_sqlPath);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		public void WriteQueryToSqlFile(string path)
		{
			FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs, Encoding.Default);

			sw.WriteLine(this.Text);

			sw.Close();
			fs.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		public void ReadQueryFromSqlFile(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sw = new StreamReader(fs, Encoding.Default);

			this.Text = sw.ReadToEnd();

			sw.Close();
			fs.Close();

			this.m_sqlPath = path;
		}

		public string Path
		{
			get { return this.m_sqlPath; }
		}

		private string m_sqlPath = null;
	}
}
