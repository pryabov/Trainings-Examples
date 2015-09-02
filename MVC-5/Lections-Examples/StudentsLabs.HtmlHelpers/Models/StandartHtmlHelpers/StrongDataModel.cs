using System.ComponentModel.DataAnnotations;

namespace WorkWithHtmlHelpers.Models.StandartHtmlHelpers
{
	public class StrongDataModel
	{
		public bool IsApproved { get; set; }
		public string SomeProperty { get; set; }
		public string RadioVal { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public string Bio { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public string[] Vals { get; set; }
	}
}