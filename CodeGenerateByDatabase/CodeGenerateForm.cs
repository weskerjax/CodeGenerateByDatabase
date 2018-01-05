using CodeGenerateByDatabase.Models;
using CodeGenerateByDatabase.Properties;
using CodeGenerateByDatabase.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace CodeGenerateByDatabase
{
	public partial class CodeGenerateForm : Form
	{
		private DataConnectionDialog _connectionDialog;
		private Settings _settings = Settings.Default;

		private DbMetaProvider _dbMetaProvider;
		private CodeGenerator _codeGenerator;


		public CodeGenerateForm()
		{
			_dbMetaProvider = new DbMetaProvider();
			_codeGenerator = new CodeGenerator(_dbMetaProvider);


			/*初始化组件*/
			InitializeComponent();


			/*建立樣版選項*/
			var tplCheckBoxs = _codeGenerator.TemplateTypes.Select((x, i) => new CheckBox
			{
				Name = x.FullName,
				Text = x.FormatTemplateName(),
				Size = new System.Drawing.Size(110, 16),
				TabIndex = 21 + i,
				TabStop = true,
			});

			_templateSelect.Controls.AddRange(tplCheckBoxs.ToArray());



			/*初始化設定*/
			this._cntStringBox.Items.AddRange(_settings.CntStringItems.Cast<string>().ToArray());
			this._solutionBox.Items.AddRange(_settings.SolutionItems.Cast<string>().ToArray());
			this.Size = _settings.FormSize;

        }



		/*########################################################*/


		private DataConnectionDialog getConnectionDialog()
		{
			if (_connectionDialog == null) 
			{ 
				_connectionDialog = new DataConnectionDialog();
				_connectionDialog.DataSources.Add(DataSource.SqlDataSource); /* Sql Server */
				_connectionDialog.DataSources.Add(DataSource.SqlFileDataSource); /* Sql Server File */

				_connectionDialog.SelectedDataSource = Microsoft.Data.ConnectionUI.DataSource.SqlDataSource;
				_connectionDialog.SelectedDataProvider = Microsoft.Data.ConnectionUI.DataProvider.SqlDataProvider;
			}
			return _connectionDialog;
		}



		private bool validation()
		{
			var errorMsg = new List<string>();

			_cntStringBox.ValidateText(errorMsg, "請選擇 Connection String");
			_solutionBox.ValidateText(errorMsg, "請選擇 Solution");
			_nameSpaceBox.ValidateText(errorMsg, "請輸入 NameSpace");
			_dcNameBox.ValidateText(errorMsg, "請輸入 DataContext 的名稱");

			if (!_tableSelect.HasChecked()) { errorMsg.Add("請選擇 Table"); }
			if (!_templateSelect.HasChecked()) { errorMsg.Add("請選擇樣版"); }

			if (errorMsg.Count == 0) { return true; }

			MessageBox.Show(string.Join("\n", errorMsg));
			return false;
		}



		private void generate()
		{
			if (!validation()) { return; }


			var tpls = _templateSelect.Controls.OfType<CheckBox>()
				.Where(x => x.Checked)
				.Select(x => x.Name)
				.ToList();


			var tables = _tableSelect.CheckedItems.Cast<TableInfo>()
				.Select(x => x.TableName)
				.ToList();


			_execStatusMsg.Clear();

			_codeGenerator.BasePath = Path.GetDirectoryName(_solutionBox.Text);
			_codeGenerator.DataContextName = _dcNameBox.Text;
			_codeGenerator.NameSpace = _nameSpaceBox.Text;
			_codeGenerator.IsOverride = _isOverride.Checked;

			_codeGenerator.Execute(tpls, tables, (isGenerate, filePath) =>
			{
				string msg = isGenerate ? "產生　" : "已存在";
				_execStatusMsg.AppendText(msg + "  " + filePath + "\n");
			});
	
			_execStatusMsg.AppendText("[執行結束]\n");
			_execStatusMsg.Focus();
		}





		/*########################################################*/

		#region Validating 資料即時驗證區段

		private void _cntStringBox_Validating(object sender, CancelEventArgs e)
		{
			_cntStringBox.ValidateText(_errorProvider, "請選擇 Connection String");
		}

		private void _solutionBox_Validating(object sender, CancelEventArgs e)
		{
			_solutionBox.ValidateText(_errorProvider, "請選擇 Solution");
		}

		private void _nameSpaceBox_Validating(object sender, CancelEventArgs e)
		{
			_nameSpaceBox.ValidateText(_errorProvider, "請輸入 NameSpace");
		}

		private void _dcNameBox_Validating(object sender, CancelEventArgs e)
		{
			_dcNameBox.ValidateText(_errorProvider, "請輸入 DataContext 的名稱");
		}

		#endregion




		/*########################################################*/

		private void cntStringBox_TextChanged(object sender, EventArgs e)
		{
			_tableSelect.DataSource = new List<TableInfo>(); 
			if (string.IsNullOrWhiteSpace(_cntStringBox.Text)) { return; }

			try
			{
				/*產生 Table 選項*/
				_dbMetaProvider.SetConnectionString(_cntStringBox.Text);
				List<TableInfo> list = _dbMetaProvider.GetTableList();

				_tableSelect.DataSource = list;
				_tableSelect.ValueMember = "TableName";
				_tableSelect.DisplayMember = "DisplayName";


				/*下拉選項紀錄*/
				_cntStringBox.Items.AddNotExists(_cntStringBox.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private void _cntStringBtn_Click(object sender, EventArgs e)
		{
			var connDialog = getConnectionDialog();
			connDialog.ConnectionString = _cntStringBox.Text;

			if (DataConnectionDialog.Show(connDialog) != DialogResult.OK) { return; }

			string connString = connDialog.ConnectionString;
			_cntStringBox.Items.AddNotExists(connString);
			_cntStringBox.Text = connString;

			_cntStringBox_Validating(sender, null);
		}


		/// <summary>選擇 Solution</summary>
        private void solutionBtn_Click(object sender, EventArgs e)
        {
			if (_solitionDialog.ShowDialog() != DialogResult.OK || _solitionDialog.FileName == null) { return; }

			string path = _solitionDialog.FileName;
			_solutionBox.Items.AddNotExists(path);
			_solutionBox.Text = path;

			_solutionBox_Validating(sender, null);
        }




        private void execBtn_Click(object sender, EventArgs e)
        {			
			generate();
        }


		private void _closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}


		/// <summary>關閉時儲存狀態設定</summary>
		private void CodeGenerateForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_settings.CntStringItems.Clear();
			_settings.CntStringItems.AddRange(_cntStringBox.Items.Cast<string>().TakeLast(10).ToArray());

			_settings.SolutionItems.Clear();
			_settings.SolutionItems.AddRange(_solutionBox.Items.Cast<string>().TakeLast(10).ToArray());

			_settings.Save();
		}

		

	}



}
