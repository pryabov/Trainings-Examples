﻿using System.Web.Mvc;

namespace WorkWithHtmlHelpers.Helpers.HtmlHelpers
{
	public static class CustomHelpers
	{
		//this HtmlHelper html - can be removed. @CustomHelpers.ListArrayitems(Model.Values)
		public static MvcHtmlString ListArrayitems(this HtmlHelper html, string[] list)
		{
			TagBuilder tag = new TagBuilder("ul");

			foreach (string str in list)
			{
				TagBuilder itemTag = new TagBuilder("li");
				itemTag.SetInnerText(str);
				tag.InnerHtml += itemTag.ToString();
			}

			return new MvcHtmlString(tag.ToString());
		}
	}
}