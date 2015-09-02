using System.Web.Mvc;
using WorkWithHtmlHelpers.Models.StandartHtmlHelpers;

namespace WorkWithHtmlHelpers.Controllers
{
	public class StandartHtmlHelpersController : Controller
	{
		public ActionResult CreateForm()
		{
			return View();
		}

		public ActionResult PostForm()
		{
			return RedirectToAction("CreateForm");
		}

		public ActionResult DataInput()
		{
			return View();
		}

		public ActionResult StrongDataInput()
		{
			return View(new StrongDataModel
			{
				IsApproved = true,
				SomeProperty = "SomeProperty",
				RadioVal = "val",
				Password = "Password",
				Bio = "Bio",
				Name = "Name",
				Gender = "F",
				Vals = new []{"A"}
			});
		}

		public ActionResult StrongDataInputWithAttributes()
		{
			return View(new StrongDataModel
			{
				IsApproved = true,
				SomeProperty = "SomeProperty",
				RadioVal = "val",
				Password = "Password",
				Bio = "Bio",
				Name = "Name",
				Gender = "F",
				Vals = new[] { "A" }
			});
		}
	}
}
