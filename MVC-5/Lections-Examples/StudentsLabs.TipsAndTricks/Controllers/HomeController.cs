using System.IO;
using System.Web;
using System.Web.Mvc;

namespace StudentsLabs.TipsAndTricks.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult FileUpload()
		{
			return View();
		}


		[HttpPost]
		public ActionResult Upload(HttpPostedFileBase file)
		{
			// Verify that the user selected a file
			if (file != null && file.ContentLength > 0)
			{
				// extract only the fielname
				string fileName = Path.GetFileName(file.FileName);
				// store the file inside ~/App_Data/uploads folder
				string path = Path.Combine(Server.MapPath("~/App_Data/Uploads"), fileName);
				file.SaveAs(path);
			}
			// redirect back to the index action to show the form once again
			return RedirectToAction("Index");  
		}
	}
}
