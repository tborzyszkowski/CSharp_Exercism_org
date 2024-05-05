using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	static class Badge
	{
		public static string Print(int? id, string name, string? department) =>
			(id.HasValue)
				? (
					(department != null) ? 
						$"[{id}] - {name} - {department?.ToUpper()}" : $"[{id}] - {name} - OWNER"
				)
				: (
					(department != null) ? 
						$"{name} - {department?.ToUpper()}" : $"{name} - OWNER"
				);

	}

}
