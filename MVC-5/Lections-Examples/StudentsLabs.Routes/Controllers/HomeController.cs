using System.Web.Mvc;

namespace StudentsLabs.Routes.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
