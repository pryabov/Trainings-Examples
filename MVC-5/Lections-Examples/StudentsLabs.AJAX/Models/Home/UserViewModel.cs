using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentsLabs.AJAX.Models.Home
{
	public class UserViewModel
	{
		[Required]
		[DisplayName("First Name")]
		public string FirstName { get; set; }
		[Required]
		[DisplayName("Last Name")]
		public string LastName { get; set; }
	}
}