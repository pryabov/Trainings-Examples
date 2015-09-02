using System.Web.Mvc;
using WorkWithHtmlHelpers.Models.CustomHtmlHelpers;

namespace WorkWithHtmlHelpers.Controllers
{
	public class CustomHtmlHelpersController : Controller
	{
		public ActionResult InlineHtmlHelper1()
		{
			ArrayModel model = new ArrayModel
			{
				Values = new []{"1", "2", "3"}
			};

			return View(model);
		}

		public ActionResult InlineHtmlHelper2()
		{
			ArrayModel model = new ArrayModel
			{
				Values = new[]{ "1", "2", "3" }
			};

			return View(model);
		}

		public ActionResult ExternalHtmlHelper1()
		{
			ArrayModel model = new ArrayModel
			{
				Values = new[] { "1", "2", "3" }
			};

			return View(model);
		}

		public ActionResult ExternalHtmlHelper2()
		{
			ArrayModel model = new ArrayModel
			{
				Values = new[] { "1", "2", "3" }
			};

			return View(model);
		}
	}
}
