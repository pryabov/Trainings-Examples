using System.Web.Mvc;

namespace StudentsLabs.APIControllers.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
