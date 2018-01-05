using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerateByDatabase
{
	public static class Utility
	{

		public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int count)
		{
			return source.Skip(Math.Max(0, source.Count() - count));
		}


		public static void ValidateText(this Control control, ErrorProvider errorProvider, string errorMsg)
		{
			if (!string.IsNullOrWhiteSpace(control.Text)) { errorMsg = null; }
			errorProvider.SetError(control, errorMsg);
		}

		public static void ValidateText(this Control control, List<string> errorMsgDisplay, string errorMsg)
		{
			if (!string.IsNullOrWhiteSpace(control.Text)) { return; }
			errorMsgDisplay.Add(errorMsg);
		}


		public static bool HasChecked(this Control control)
		{
			var listBox = control as CheckedListBox;
			if(listBox != null)
			{
				return listBox.CheckedItems.Count > 0;
			}
			else
			{			
				return control.Controls.OfType<CheckBox>().Where(x => x.Checked).Any();
			}
		}


		public static void AddNotExists(this ComboBox.ObjectCollection items, object value)
		{
			if (items.Contains(value)) { return; }
			items.Add(value);
		}


		public static string FormatTemplateName(this Type type)
		{
			string name = type.FullName.Replace("Template", "");
			return string.Join(".", name.Split('.').TakeLast(2));
		}


	}
}
