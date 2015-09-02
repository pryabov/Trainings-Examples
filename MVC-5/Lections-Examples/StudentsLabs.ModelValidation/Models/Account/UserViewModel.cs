using System.ComponentModel.DataAnnotations;

namespace StudentsLabs.ModelValidation.Models.Account
{
	public class UserViewModel
	{
		[Required]
		[StringLength(20, MinimumLength = 3)]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		[StringLength(7, MinimumLength = 3)]
		public string Password { get; set; }
	}
}