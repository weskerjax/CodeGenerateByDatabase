using CodeGenerateByDatabase.Models;
using CodeGenerateByDatabase.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerateByDatabase
{
	public class CodeGenerator
	{
		private DbMetaProvider _dbMetaProvider = new DbMetaProvider();

		private List<Type> _tplTypes = Assembly.GetExecutingAssembly().GetTypes()
			.Where(x => x.IsClass && !x.IsAbstract && !x.IsInterface)
			.Where(x => typeof(TemplateBase).IsAssignableFrom(x))
			.OrderBy(x => x.FullName)
			.ToList();

		public List<Type>  TemplateTypes { 
			get { return _tplTypes; }
		}

		public string BasePath { get; set; }
		public string DataContextName { get; set; }
		public string NameSpace { get; set; }
		public bool IsOverride { get; set; }


		public CodeGenerator(DbMetaProvider dbMetaProvider)
		{
			_dbMetaProvider = dbMetaProvider;
		}


		public void Execute(IEnumerable<string> templateNames, IEnumerable<string> tableNames, Action<bool, string> executed)
		{

			var selectTplTypes = templateNames
				.Select(x => _tplTypes.Single(y => y.FullName.EndsWith(x)))
				.ToList();


			var tableMetaList = tableNames
				.Select(x => _dbMetaProvider.GetTableMeta(x))
				.ToList();


			foreach (var tplType in selectTplTypes)
			foreach (TableMeta tableMeta in tableMetaList)
			{
				tableMeta.NameSpace = this.NameSpace;

				var tpl = (TemplateBase)Activator.CreateInstance(tplType);
				tpl.TableMeta = tableMeta;
				tpl.DataContextName = this.DataContextName;

				bool isGenerate = tpl.Generate(this.BasePath, this.IsOverride);
				executed(isGenerate, tpl.FilePath);
			}
		}


	}
}
