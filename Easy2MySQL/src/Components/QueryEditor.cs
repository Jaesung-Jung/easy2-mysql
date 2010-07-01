
// QueryEditor.cs
//
using System;
using System.Xml;
using System.Windows.Forms;

namespace Easy2
{
	/// <summary>
	/// 쿼리에디터 클래스입니다.
	/// </summary>
	public class QueryEditor : SyntaxHighlightTextBox
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public QueryEditor()
		{
			InitializeComponent();

			if(!(QueryEditor.m_compiledHighlightWord))
			{
				// 속도 문제로 잠시 보류
// 				try
// 				{
// 					string highlightWordXmlFilePath = @"..\..\xml\HighlightWords.xml";
// 					XmlDocument xmlDocument = new XmlDocument();
// 					xmlDocument.Load(highlightWordXmlFilePath);
// 
// 					XmlElement xmlElement = xmlDocument.DocumentElement;
// 					XmlNodeList highlightWordList = xmlElement.ChildNodes;
// 
// 					foreach(XmlElement word in xmlElement)
// 					{
// 						if(word.Name == "KEYWORD")
// 						{
// 							this.Keywords.Add(word.InnerText);
// 						}
// 						else if(word.Name == "FUNCTION")
// 						{
// 							this.Functions.Add(word.InnerText);
// 						}
// 					}
// 
// 				}
// 				catch(Exception ex)
// 				{
// 					MessageBox.Show(ex.ToString());
// 				}
// 				this.CompileHighlightWord();
			}
		}

		/// <summary>
		/// 컴포넌트를 초기화합니다.
		/// </summary>
		private void InitializeComponent()
		{
			this.Font = new System.Drawing.Font("Courier New", 11);
		}

		private static bool m_compiledHighlightWord = false;
	}
}
