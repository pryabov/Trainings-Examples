using System.ComponentModel.DataAnnotations;
using StudentsLabs.ModelValidation.Resources;

namespace StudentsLabs.ModelValidation.Models.Account
{
	public class LocalizedUserViewModel
	{
		[Required(ErrorMessage = @"This is required field.")]
		[StringLength(20, MinimumLength = 3, 
			ErrorMessageResourceType = typeof(ValidationLocalizationsResource), 
			ErrorMessageResourceName = "StringLengthError")]
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