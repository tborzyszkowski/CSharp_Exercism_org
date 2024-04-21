using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercism {
	static class LogLine {
		const string INFO = "INFO";
		const string WARNING = "WARNING";
		const string ERROR = "ERROR";
		const string INFO_PREFIX = "[" + INFO + "]: ";
		const string WARNING_PREFIX = "[" + WARNING + "]: ";
		const string ERROR_PREFIX = "[" + ERROR + "]: ";

		public static string Message(string logLine) {
			return
				(logLine.StartsWith(INFO_PREFIX) ? logLine.Substring(INFO_PREFIX.Length) : "").Trim() +
				(logLine.StartsWith(WARNING_PREFIX) ? logLine.Substring(WARNING_PREFIX.Length).Trim() : "") +
				(logLine.StartsWith(ERROR_PREFIX) ? logLine.Substring(ERROR_PREFIX.Length).Trim() : "");
		}

		public static string LogLevel(string logLine) {
			if (logLine.StartsWith(INFO_PREFIX)) return INFO.ToLower();
			if (logLine.StartsWith(WARNING_PREFIX)) return WARNING.ToLower();
			if (logLine.StartsWith(ERROR_PREFIX)) return ERROR.ToLower();
			return "";
		}

		public static string Reformat(string logLine) {
			return $"{Message(logLine)} ({LogLevel(logLine)})";
		}
	}
}
