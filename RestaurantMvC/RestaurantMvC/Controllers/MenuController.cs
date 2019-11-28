using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMvC.Models;
namespace RestaurantMvC.Controllers
{
    public class MenuController : Controller
    {
		//
		// GET: /Menu/
		public ActionResult Index()
		{
			return View();
		}
		//
		// GET: /Menu/Browse?Recipe=Burger
		public ActionResult Browse(string Title)
		{
			var foodItemModel = new FoodItem { Title = Title };
			return View(foodItemModel);
		}

		//
		// GET: /Menu/Details/5
		public ActionResult Details(int id)
		{
			var recipe= new Recipe { Name = "Recipe " + id };
			return View(recipe);
		}



	}
}