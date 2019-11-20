using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvC.Controllers
{
    public class MenuController : Controller
    {
		//
		// GET: /Menu/
		public string Index()
		{
			return "Hello from Menu.Index()";
		}
		//
		// GET: /Menu/Browse?Recipe=Burger
		public string Browse(string recipe)
		{
			string message = HttpUtility.HtmlEncode("Menu.Browse, Recipe = "
		+ recipe);

			return message;
		}

		//
		// GET: /Menu/Details/5
		public string Details(int id)
		{
			string message = "Menu.Details, ID = " + id;

			return message;
		}



	}
}