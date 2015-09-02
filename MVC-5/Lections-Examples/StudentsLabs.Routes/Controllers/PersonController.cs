using System.Web.Mvc;

namespace StudentsLabs.Routes.Controllers
{
	public class PersonController : Controller
	{
		[HttpGet]
		public ActionResult CheckPerson()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddPerson()
		{
			//TODO: Add Person to DB
			return Json(new {IsSuccuss = true});
		}
	}
}
