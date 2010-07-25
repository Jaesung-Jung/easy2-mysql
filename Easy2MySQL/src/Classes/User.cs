
// User.cs
//

namespace Easy2.Classes
{
	/// <summary>
	/// 사용자정보 클래스입니다.
	/// </summary>
	public class User
	{
		/// <summary>
		/// 사용자명입니다.
		/// </summary>
		public string Username
		{
			get { return this.m_username; }
			set { this.m_username = value; }
		}

		/// <summary>
		/// 호스트명입니다.
		/// </summary>
		public string Host
		{
			get { return this.m_host; }
			set { this.m_host = value; }
		}

		/// <summary>
		/// 비밀번호입니다.
		/// </summary>
		public string Password
		{
			get { return this.m_password; }
			set { this.m_password = value; }
		}

		/// <summary>
		/// Select권한 여부입니다.
		/// </summary>
		public bool Select
		{
			get { return this.m_select; }
			set { this.m_select = value; }
		}

		/// <summary>
		/// Insert권한 여부입니다. 
		/// </summary>
		public bool Insert
		{
			get { return this.m_insert; }
			set { this.m_insert = value; }
		}

		/// <summary>
		/// Update권한 여부입니다. 
		/// </summary>
		public bool Update
		{
			get { return this.m_update; }
			set { this.m_update = value; }
		}

		/// <summary>
		/// Delete권한 여부입니다. 
		/// </summary>
		public bool Delete
		{
			get { return this.m_delete; }
			set { this.m_delete = value; }
		}

		/// <summary>
		/// Create권한 여부입니다. 
		/// </summary>
		public bool Create
		{
			get { return this.m_create; }
			set { this.m_create = value; }
		}

		/// <summary>
		/// Drop권한 여부입니다. 
		/// </summary>
		public bool Drop
		{
			get { return this.m_drop; }
			set { this.m_drop = value; }
		}

		/// <summary>
		/// Reload권한 여부입니다. 
		/// </summary>
		public bool Reload
		{
			get { return this.m_reload; }
			set { this.m_reload = value; }
		}

		/// <summary>
		/// Shutdown권한 여부입니다. 
		/// </summary>
		public bool Shutdown
		{
			get { return this.m_shutdown; }
			set { this.m_shutdown = value; }
		}

		/// <summary>
		/// Process권한 여부입니다. 
		/// </summary>
		public bool Process
		{
			get { return this.m_process; }
			set { this.m_process = value; }
		}

		/// <summary>
		/// File권한 여부입니다. 
		/// </summary>
		public bool File
		{
			get { return this.m_file; }
			set { this.m_file = value; }
		}

		/// <summary>
		/// Reference권한 여부입니다. 
		/// </summary>
		public bool Reference
		{
			get { return this.m_reference; }
			set { this.m_reference = value; }
		}

		/// <summary>
		/// Index권한 여부입니다. 
		/// </summary>
		public bool Index
		{
			get { return this.m_index; }
			set { this.m_index = value; }
		}

		/// <summary>
		/// Alter권한 여부입니다. 
		/// </summary>
		public bool Alter
		{
			get { return this.m_alter; }
			set { this.m_alter = value; }
		}

		/// <summary>
		/// Grant권한 여부입니다. 
		/// </summary>
		public bool Grant
		{
			get { return this.m_grant; }
			set { this.m_grant = value; }
		}

		/// <summary>
		/// Execute권한 여부입니다. 
		/// </summary>
		public bool Execute
		{
			get { return this.m_execute; }
			set { this.m_execute = value; }
		}

		/// <summary>
		/// Repl_slave권한 여부입니다. 
		/// </summary>
		public bool Repl_slave
		{
			get { return this.m_repl_slave; }
			set { this.m_repl_slave = value; }
		}

		/// <summary>
		/// Show_db권한 여부입니다. 
		/// </summary>
		public bool Show_db
		{
			get { return this.m_show_db; }
			set { this.m_show_db = value; }
		}

		/// <summary>
		/// Repl_client권한 여부입니다.
		/// </summary>
		public bool Repl_client
		{
			get { return this.m_repl_client; }
			set { this.m_repl_client = value; }
		}

		/// <summary>
		/// Super권한 여부입니다.
		/// </summary>
		public bool Super
		{
			get { return this.m_super; }
			set { this.m_super = value; }
		}

		/// <summary>
		/// Lock_tables권한 여부입니다. 
		/// </summary>
		public bool Lock_tables
		{
			get { return this.m_lock_tables; }
			set { this.m_lock_tables = value; }
		}

		/// <summary>
		/// Create_tmp_tables권한 여부입니다. 
		/// </summary>
		public bool Create_tmp_tables
		{
			get { return this.m_create_tmp_tables; }
			set { this.m_create_tmp_tables = value; }
		}

		/// <summary>
		/// Create_view권한 여부입니다. 
		/// </summary>
		public bool Create_view
		{
			get { return this.m_create_view; }
			set { this.m_create_view = value; }
		}

		/// <summary>
		/// Create_routine권한 여부입니다. 
		/// </summary>
		public bool Create_routine
		{
			get { return this.m_create_routine; }
			set { this.m_create_routine = value; }
		}

		/// <summary>
		/// Show_view권한 여부입니다. 
		/// </summary>
		public bool Show_view
		{
			get { return this.m_show_view; }
			set { this.m_show_view = value; }
		}

		/// <summary>
		/// Alter_routine권한 여부입니다. 
		/// </summary>
		public bool Alter_routine
		{
			get { return this.m_alter_routine; }
			set { this.m_alter_routine = value; }
		}

		/// <summary>
		/// Create_user권한 여부입니다. 
		/// </summary>
		public bool Create_user
		{
			get { return this.m_create_user; }
			set { this.m_create_user = value; }
		}

		/// <summary>
		/// Trigger권한 여부입니다. 
		/// </summary>
		public bool Trigger
		{
			get { return this.m_trigger; }
			set { this.m_trigger = value; }
		}

		/// <summary>
		/// Event권한 여부입니다. 
		/// </summary>
		public bool Event
		{
			get { return this.m_event; }
			set { this.m_event = value; }
		}

		// All version
		private string m_username;
		private string m_host;
		private string m_password;
		private bool m_select;
		private bool m_insert;
		private bool m_update;
		private bool m_delete;
		private bool m_create;
		private bool m_drop;
		private bool m_reload;
		private bool m_shutdown;
		private bool m_process;
		private bool m_file;
		private bool m_reference;
		private bool m_index;
		private bool m_alter;
		private bool m_grant;
		// 4.0.2 version
		private bool m_execute;
		private bool m_repl_slave;
		private bool m_show_db;
		private bool m_repl_client;
		private bool m_super;
		private bool m_lock_tables;
		private bool m_create_tmp_tables;
		// 5.0 version
		private bool m_create_view;
		private bool m_create_routine;
		private bool m_show_view;
		private bool m_alter_routine;
		private bool m_create_user;
		// 5.1 version
		private bool m_trigger;
		private bool m_event;
	}
}
