using RestaurantMvC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvC.Repositories
{
	public class CustomerRepository
	{
		
		private RestaurantDBEntities objrestaurantDBEntities;
		public CustomerRepository()
		{

			objrestaurantDBEntities = new RestaurantDBEntities();
		}

		public IEnumerable<SelectListItem> GetAllItems()
		{
			var objSelectListItems = new List<SelectListItem>();
			objSelectListItems = (from obj in objrestaurantDBEntities.Customers
								  select new SelectListItem()
								  {
									  Text = obj.CustomerName,
									  Value = obj.CustomerId.ToString(),
									  Selected = true
								  }).ToList();

			return objSelectListItems;
		}

	}
}