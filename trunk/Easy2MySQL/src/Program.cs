
// Program.cs
//
using System;
using System.Windows.Forms;

namespace Easy2
{
	public class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

		public static MySqlCommunicator MySqlCommunicatorHandle
		{
			get { return Program.m_mysqlCommunicator; }
		}

		private static MySqlCommunicator m_mysqlCommunicator = new MySqlCommunicator();
	}
}
