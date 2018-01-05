using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerateByDatabase.Models
{
	public class ColumnMeta
	{

		public string Name { get; set; }

		public string DbType { get; set; }

		public string CodeType { get; set; }

		public bool IsPrimaryKey { get; set; }

		public bool IsNullable { get; set; }

		public string Description { get; set; }

		public string Variable {
			get { return char.ToLower(Name[0]) + Name.Substring(1); }
			set { }
		}

	}
}
