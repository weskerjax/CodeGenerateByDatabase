﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本: 14.0.0.0
//  
//     變更這個檔案可能會導致不正確的行為，而且如果已重新產生
//     程式碼，則會遺失變更。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerateByDatabase.Templates.Wcf
{
    using System.Linq;
    using CodeGenerateByDatabase.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class DaoTemplate : CodeGenerateByDatabase.Templates.TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 4 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 
	string className = TableMeta.Name + "Dao";
	FilePath = TableMeta.NameSpace + ".Dao/Impl/" + className + ".cs";

            
            #line default
            #line hidden
            this.Write("using Orion.API;\r\nusing Orion.API.Extensions;\r\nusing Orion.API.Models;\r\nusi" +
                    "ng ");
            
            #line 11 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Dao.Database;\r\nusing ");
            
            #line 12 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Domain;\r\nusing ");
            
            #line 13 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Domain.Enums;\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Li" +
                    "nq;\r\n\r\n\r\nnamespace ");
            
            #line 19 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Dao.Impl\r\n{\r\n\t/// <summary>");
            
            #line 21 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Description));
            
            #line default
            #line hidden
            this.Write("</summary>\r\n\tpublic class ");
            
            #line 22 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(" : I");
            
            #line 22 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\tprivate ");
            
            #line 24 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataContextName));
            
            #line default
            #line hidden
            this.Write(" _dc;\r\n\r\n\t\tpublic ");
            
            #line 26 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 26 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataContextName));
            
            #line default
            #line hidden
            this.Write(" dc)\r\n\t\t{\r\n\t\t\t_dc = dc;\r\n\t\t}\r\n\r\n\r\n\t\t//TODO 程式產生未完成\r\n\t\t//public Dictionary<int, st" +
                    "ring> GetDic(string status = null)\r\n\t\t//{\r\n\t\t//\tIQueryable<");
            
            #line 35 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write("> query = _dc.");
            
            #line 35 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t//\tquery = query.WhereHas(x => x.UseStatus == status);\r\n\r\n\t\t//\tvar items = q" +
                    "uery.ToDictionary(x => x.");
            
            #line 38 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Name));
            
            #line default
            #line hidden
            this.Write(", x => x.");
            
            #line 38 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write(@"Name);
		//	return items;
		//}


		//TODO 程式產生未完成
		//public Dictionary<string, string> GetStatusItems()
		//{
		//	var items = new Dictionary<string, string>
		//	{
		//		{ ""y"", ""開啟"" },
		//		{ ""n"", ""關閉"" },
		//	};
		//	return items;
		//}

		private ");
            
            #line 54 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain toDomain(_");
            
            #line 54 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write(" data)\r\n\t\t{\r\n\t\t\tif(data == null) { return null; }\r\n\r\n\t\t\tvar domain = new ");
            
            #line 58 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain \r\n\t\t\t{\r\n");
            
            #line 60 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 foreach(var col in TableMeta.Columns) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t");
            
            #line 61 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(" = data.");
            
            #line 61 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 62 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t};\t\t\t\r\n\r\n\t\t\treturn domain;\r\n\t\t}\r\n\r\n\r\n\r\n\r\n\t\tprivate IQueryable<_");
            
            #line 71 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("> getQuery(WhereParams<");
            
            #line 71 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain> findParam = null)\r\n\t\t{\r\n\t\t\tIQueryable<_");
            
            #line 73 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("> query =\r\n\t\t\t\tfrom x in _dc.");
            
            #line 74 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\tselect new _");
            
            #line 75 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t{\r\n");
            
            #line 77 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 foreach(var col in TableMeta.Columns) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t");
            
            #line 78 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(" = x.");
            
            #line 78 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 79 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t};\r\n\r\n\r\n\t\t\tif (findParam == null) { return query; }\r\n\r\n\t\t\tquery = query.Where" +
                    "Builder(findParam)\r\n");
            
            #line 86 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 foreach(var col in TableMeta.Columns) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t.WhereBind(x => x.");
            
            #line 87 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(",\ty => y.");
            
            #line 87 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 88 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t.Build();\r\n\r\n\t\t\treturn query;\r\n\t\t}\r\n\r\n\r\n\r\n\r\n\t\t//TODO 程式產生未完成\r\n\t\tpublic Pagina" +
                    "tion<");
            
            #line 98 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain> GetPagination(WhereParams<");
            
            #line 98 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain> findParam, PageParams<");
            
            #line 98 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Sort?> pageParams)\r\n\t\t{\r\n\t\t\tIQueryable<_");
            
            #line 100 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("> query = getQuery(findParam);\r\n\r\n\r\n\t\t\tif (pageParams == null) { pageParams = Pag" +
                    "eParams<");
            
            #line 103 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Sort?>.Unlimited(); }\r\n\r\n\t\t\tbool isDesc = pageParams.Descending;\r\n\t\t\ttry\r\n\t\t\t{\r\n\t" +
                    "\t\t\tquery = query.OrderBy(pageParams.OrderField, isDesc);\r\n\t\t\t}\r\n\t\t\tcatch (Except" +
                    "ion)\r\n\t\t\t{\r\n\t\t\t\tquery = query.OrderBy(x => x.");
            
            #line 112 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Name));
            
            #line default
            #line hidden
            this.Write(", isDesc);\r\n\t\t\t}\r\n\r\n\r\n\t\t\tvar result = query.AsPagination(pageParams.PageIndex, pa" +
                    "geParams.PageSize);\r\n\t\t\treturn result.As(x => toDomain(x));\r\n\t\t}\r\n\r\n\t\t\r\n\r\n\t\t//TO" +
                    "DO 程式產生未完成\r\n\t\t//public List<");
            
            #line 123 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain> GetList(WhereParams<");
            
            #line 123 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain> findParam = null)\r\n\t\t//{\r\n\t\t//\tIEnumerable<_");
            
            #line 125 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("> query = getQuery(findParam);\r\n\t\t//\r\n\t\t//\treturn query.Select(x => toDomain(x))." +
                    "ToList();\r\n\t\t//}\r\n\r\n\r\n\r\n\t\t//TODO 程式產生未完成\r\n\t\tpublic ");
            
            #line 133 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain GetById(");
            
            #line 133 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.CodeType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 133 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Variable));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n\t\t\t_");
            
            #line 135 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write(" data = getQuery().FirstOrDefault(x => x.");
            
            #line 135 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Name));
            
            #line default
            #line hidden
            this.Write(" == ");
            
            #line 135 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Variable));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\tif (data == null) { return null; }\r\n\r\n\t\t\t");
            
            #line 138 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain domain = toDomain(data);\r\n\r\n\t\t\treturn domain;\r\n\t\t}\r\n\r\n\r\n\r\n\t\t//TODO 程式產生未完成" +
                    "\r\n\t\tpublic int Save(");
            
            #line 146 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write("Domain domain)\r\n\t\t{\r\n\t\t\tvar datetimeNow = DateTime.Now;\r\n\r\n\t\t\t");
            
            #line 150 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write(" data;\r\n\r\n\t\t\tif (domain.");
            
            #line 152 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Name));
            
            #line default
            #line hidden
            this.Write(" > 0)\r\n\t\t\t{\r\n\t\t\t\tdata = _dc.");
            
            #line 154 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write(".FirstOrDefault(x => x.");
            
            #line 154 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Name));
            
            #line default
            #line hidden
            this.Write(" == domain.");
            
            #line 154 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t\tChecker.Has(data, \"");
            
            #line 155 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Description));
            
            #line default
            #line hidden
            this.Write("不存在無法修改\");\r\n\t\t\t}\r\n\t\t\telse\r\n\t\t\t{\r\n\t\t\t\tdata = new ");
            
            #line 159 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t{\r\n\t\t\t\t\tCreateBy = domain.ModifyBy,\r\n\t\t\t\t\tCreateDate = datetimeNow,\r\n\t\t\t\t};" +
                    "\r\n\t\t\t\t_dc.");
            
            #line 164 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write(".InsertOnSubmit(data);\r\n\t\t\t}\r\n\r\n\r\n");
            
            #line 168 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 foreach(var col in TableMeta.Columns.Where(x => !x.IsPrimaryKey && !(new[] {"CreateBy", "CreateDate", "ModifyBy", "ModifyDate"}).Contains(x.Name) )) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tdata.");
            
            #line 169 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(" = domain.");
            
            #line 169 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 170 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tdata.ModifyBy = domain.ModifyBy;\r\n\t\t\tdata.ModifyDate = datetimeNow;\r\n\r\n\t\t\t \r" +
                    "\n\r\n\t\t\t_dc.SubmitChanges();\r\n\r\n\r\n\t\t\treturn data.");
            
            #line 180 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.PK.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t}\r\n\r\n\r\n\r\n\r\n\t\t/*#############################################################" +
                    "#########*/\r\n\r\n\t\tprivate class _");
            
            #line 188 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.Name));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 188 "D:\Jax-Work\Dropbox\JW-Project\RDSystems\CodeGenerateByDatabase\CodeGenerateByDatabase\Templates\Wcf\DaoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableMeta.TableName));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n\t\t}\r\n\r\n\t}\r\n\t\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
