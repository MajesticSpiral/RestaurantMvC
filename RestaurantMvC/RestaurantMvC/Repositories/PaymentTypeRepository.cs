using RestaurantMvC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvC.Repositories
{
	public class PaymentTypeRepository
	{

		private RestaurantDBEntities objrestaurantDBEntities;
		public PaymentTypeRepository() {

			objrestaurantDBEntities = new RestaurantDBEntities();
		}

		public IEnumerable<SelectListItem> GetAllPaymentType()
		{
var objSelectListItems = new List<SelectListItem>();
			objSelectListItems = (from obj in objrestaurantDBEntities.PaymentTypes
								  select new SelectListItem()
								  {
									  Text = obj.PaymentTypeName,
									  Value = obj.PaymentTypeId.ToString(),
									  Selected = true 
								  }).ToList();

			return objSelectListItems;
		}
	}
}