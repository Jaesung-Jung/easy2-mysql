﻿
// MainApplication.cs
//
using System;
using System.Windows.Forms;

namespace Easy2
{
	class Program
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
	}
}
