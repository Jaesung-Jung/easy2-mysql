
// ObjectBrowser.cs
//
using System.Drawing;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 오브젝트 브라우저 클래스입니다.
	/// </summary>
	class ObjectBrowser : DockBrowser
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public ObjectBrowser() : base("Object Browser")
		{
		}

		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="captionText">캡션 문자열입니다.</param>
		public ObjectBrowser(string captionText) : base(captionText)
		{
		}
	}
}
