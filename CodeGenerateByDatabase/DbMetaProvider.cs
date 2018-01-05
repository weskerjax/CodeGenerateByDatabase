using CodeGenerateByDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerateByDatabase
{
	public class DbMetaProvider
	{
		private static string[] _nullableType = { 
			"bool", "byte", "DateTime", "decimal", "double", "Guid", "int" 
		};


		private DataContext _dc;


        public DbMetaProvider() { }

        public DbMetaProvider(string connectionStr)
		{
            SetConnectionString(connectionStr);
		}



        public void SetConnectionString(string connectionStr)
        {
            _dc = new DataContext(connectionStr);			
			_dc.CommandTimeout = 5; /*[sec]*/
        }


		public List<TableInfo> GetTableList()
		{
			var list = _dc.ExecuteQuery<TableInfo>(@"
				SELECT 
					id AS [Id], 
					name AS [TableName],
					(SELECT value FROM fn_listextendedproperty(
						NULL, 'schema', 'dbo', 'table', name, NULL, NULL
					))AS [Description]				
				FROM sysobjects 
				WHERE xtype = 'U' 
				  AND name NOT IN('sysdiagrams','__RefactorLog')
				ORDER BY name ASC		
			").ToList();

			return list;
		}



		public TableMeta GetTableMeta(string tableName)
		{

			var table = new TableMeta();
			table.TableName = tableName;
			table.Name = tableName.Split('_').Last();

			table.Id = _dc.ExecuteQuery<int>(@"
				SELECT id FROM sysobjects WHERE name = @p0 AND xtype = 'U'
				", table.TableName
			)
			.FirstOrDefault();

			table.Description = _dc.ExecuteQuery<string>(@"
				SELECT value FROM fn_listextendedproperty(NULL, 'schema', 'dbo', 'table', @p0, NULL, NULL)
				", table.TableName
			)
			.FirstOrDefault();


			if (table.Id == 0) { return table; }



			/* 取得 Primary Key 欄位 */
			var primaryKeys = _dc.ExecuteQuery<string>(@"
				SELECT C.Column_Name 
				FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE C 
				INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS T    
				ON C.Constraint_Name = T.Constraint_Name AND C.Table_Name = T.Table_Name	
				WHERE T.Constraint_Type = 'PRIMARY KEY' AND C.Table_Name = @p0
				", table.TableName
			).ToList();


			/* 取得欄位資訊 */
			table.Columns = _dc.ExecuteQuery<ColumnMeta>(@"
				SELECT 
					SC.name AS [Name], 
					CAST (SC.isnullable AS BIT) AS [IsNullable],
					(SELECT name FROM systypes WHERE xusertype = SC.xusertype)AS [DbType],
					(SELECT value FROM fn_listextendedproperty (
						NULL, 'schema', 'dbo', 'table', @p1, 'column', SC.name
					))AS [Description]
				FROM syscolumns AS SC
				WHERE SC.id = @p0				
			", table.Id, table.TableName).ToList();



			/* 欄位類型對應處理 */
			table.Columns.ForEach(column =>
			{
				column.IsPrimaryKey = primaryKeys.Contains(column.Name);

				column.CodeType = mappingType(column.DbType);
				if (column.IsNullable && _nullableType.Contains(column.CodeType))
				{
					column.CodeType += "?";
				}
			});


			table.PK = table.Columns.First(x => x.IsPrimaryKey);

			return table;		
		}




		private string mappingType(string dbType)
		{
			switch (dbType)
			{
				case "bit":         return "bool";
				case "tinyint":     return "byte";
				case "binary":
				case "timestamp":
				case "varbinary":   return "byte[]"; 
				case "date":
				case "datetime":
				case "datetime2":
				case "smalldatetime": return "DateTime";
				case "decimal":
				case "money":
				case "numeric":
				case "smallmoney":  return "decimal"; 
				case "float":       return "double"; 
				case "uniqueidentifier": return "Guid";
				case "smallint":    return "short"; 
				case "int":         return "int"; 
				case "bigint":      return "long"; 
				case "real":        return "Single"; 
				case "time":        return "TimeSpan";
				case "xml":         return "Xml";
			}			

			return "string";
		}


	}
}
