using System.Web.Mvc;

namespace FirstEmptyApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
