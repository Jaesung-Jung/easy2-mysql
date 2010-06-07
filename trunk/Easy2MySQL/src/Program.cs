
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
			Program.m_mainForm = new MainForm();
			Application.EnableVisualStyles();
			Application.Run(Program.m_mainForm);
		}

		/// <summary>
		/// 연결객체를 나타냅니다.
		/// </summary>
		public static MySqlCommunicator MySqlConnector
		{
			get { return Program.m_mysqlCommunicator; }
			set { Program.m_mysqlCommunicator = value; }
		}

		/// <summary>
		/// 현재 활성화된 연결객체를 나타냅니다.
		/// </summary>
		public static MySqlCommunicator ActivateCommunicator
		{
			get { return Program.m_activateCommunicator; }
			set { Program.m_activateCommunicator = value; }
		}

		/// <summary>
		/// Communicator 객체의 컬렉션을 나타냅니다.
		/// </summary>
		public static CommunicatorCollection CoummunicatorList
		{
			get { return Program.m_communicatorList; }
		}

		/// <summary>
		/// 메인 폼의 핸들을 나타냅니다.
		/// </summary>
		public static MainForm MainFormHandle
		{
			get { return Program.m_mainForm; }
		}

		private static MainForm m_mainForm;
		private static MySqlCommunicator m_activateCommunicator = null;
		private static MySqlCommunicator m_mysqlCommunicator;
		private static CommunicatorCollection m_communicatorList = new CommunicatorCollection();
	}
}
