using System.Web.Mvc;
using StudentsLabs.ModelValidation.Models.Account;

namespace StudentsLabs.ModelValidation.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult SimpleServerValidation()
		{
			UserViewModel userViewModel = new UserViewModel();
			return View(userViewModel);
		}


		public ActionResult SimpleClientValidation()
		{
			UserViewModel userViewModel = new UserViewModel();
			return View(userViewModel);
		}

		public ActionResult ValidationLocalization()
		{
			LocalizedUserViewModel userViewModel = new LocalizedUserViewModel();
			return View(userViewModel);
		}

		public ActionResult DisplayNameLocalization()
		{
			LocalizedDisplayUserViewModel userViewModel = new LocalizedDisplayUserViewModel();
			return View(userViewModel);
		}
	}
}
