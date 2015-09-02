using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WorkWithHtmlHelpers.Models.Editor
{
	public class EditorForModel
	{
		[DataType(DataType.EmailAddress)]
		public string StringField { get; set; }
		[DataType(DataType.Password)]
		public string PasswordField { get; set; }
		public int NumericField { get; set; }
		[AdditionalMetadata("foo", "bar")]
		public DateTime DateTime { get; set; }

		[UIHint("String2")]
		public string StringField2 { get; set; }
	}
}