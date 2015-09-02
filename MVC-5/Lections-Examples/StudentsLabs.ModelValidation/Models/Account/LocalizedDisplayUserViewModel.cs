using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StudentsLabs.ModelValidation.Resources;

namespace StudentsLabs.ModelValidation.Models.Account
{
	public class LocalizedDisplayUserViewModel
	{
		[DisplayName(@"First Name")]
		public string FirstName { get; set; }
		[DisplayName(@"Last Name")]
		public string LastName { get; set; }
		[Display(Name = @"Email")]
		public string Email { get; set; }
		[Display(ResourceType = typeof(DisplayNamesResource), Name = "Password_lbl" )]
		public string Password { get; set; }
	}
}