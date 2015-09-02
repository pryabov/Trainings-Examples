using System.Collections.Generic;

namespace StudentsLabs.ModelValidation.Models.Account
{
	public class SaveResultViewModel
	{
		public bool IsSuccess
		{
			get
			{
				return Errors == null || Errors.Count == 0;
			}
		}

		public LinkedList<string> Errors { get; set; }
	}
}