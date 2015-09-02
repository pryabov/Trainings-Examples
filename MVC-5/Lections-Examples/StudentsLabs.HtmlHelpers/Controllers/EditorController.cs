using System;
using System.Web.Mvc;
using WorkWithHtmlHelpers.Models.Editor;

namespace WorkWithHtmlHelpers.Controllers
{
	public class EditorController : Controller
	{
		public ActionResult EditorFor()
		{
			EditorForModel model = new EditorForModel
			{
				DateTime = DateTime.UtcNow,
				NumericField = 10,
				PasswordField = "Password",
				StringField = "String"
			};

			return View(model);
		}

		public ActionResult EditorForModel()
		{
			EditorForModel model = new EditorForModel
			{
				DateTime = DateTime.UtcNow,
				NumericField = 10,
				PasswordField = "Password",
				StringField = "String"
			};

			return View(model);
		}

	}
}
