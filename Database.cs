using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD157_Coursework
{
	public static class Database
	{
		// Removed login credentials for security reasons.
		public static String server = "";
		public static String database = "";
		public static String username = "";
		public static String password = "";
		public static String SSL = "none";
		public static String connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";" + "SslMode=" + SSL + ";";
	}
}
