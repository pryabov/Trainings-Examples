using System.Collections.Generic;
using System.Web.Mvc;
using StudentsLabs.ModelValidation.Models.Account;

namespace StudentsLabs.ModelValidation.Controllers
{
	public class AccountController : Controller
	{
		public ActionResult SaveUser(UserViewModel user)
		{
			SaveResultViewModel model = new SaveResultViewModel();

			if (!ModelState.IsValid)
			{
				model.Errors = new LinkedList<string>();
				foreach (ModelState modelState in ModelState.Values)
				{
					foreach (ModelError error in modelState.Errors)
					{
						model.Errors.AddLast(error.ErrorMessage);
					}
				}
			}

			return View("Result", model);
		}
	}
}
