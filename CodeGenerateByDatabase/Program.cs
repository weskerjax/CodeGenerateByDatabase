using CodeGenerateByDatabase.Models;
using CodeGenerateByDatabase.Templates;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace CodeGenerateByDatabase
{
	static class Program
	{

        [STAThread]
        static void Main()
        {
			//Test(); return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CodeGenerateForm());
        }



		static void Test()
		{
			var connectionStr = "Data Source=localhost;Initial Catalog=PAHSCO;Integrated Security=True";
			var provider = new DbMetaProvider(connectionStr);
			var generator = new CodeGenerator(provider);


			/*Solution 的位置*/
			//generator.BasePath = @"D:\Jax-Work\Dropbox\JW-Project\PAHSCO.WMS\PAHSCO.MCS.MVC";
			generator.BasePath = @"D:\temp";
			generator.DataContextName = "MCSDataContext";
			generator.NameSpace = "PAHSCO.WMS";
			generator.IsOverride = true;

			var tables = new[] {
				"JDE_OrderCommandReply",
				"JDE_SrcOrderCommand",
			};

			var tpls = new []{
				"Mvc.ViewModelTemplate",
				"Wcf.DomainTemplate",
			};

			generator.Execute(tpls, tables, (isGenerate, filePath) => {
				if (!isGenerate) { Console.WriteLine("已存在 " + filePath); }
			});


			Console.WriteLine("Complete !");
		}



	}
}
