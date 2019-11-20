using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMvC.Models
{
	public class MenuItems
	{
		[Key]
		public int ItemId { get; set; }
		public string ItemName { get; set; }
		public string ItemDescripion { get; set; }
		public Nullable<decimal> ItemPrice { get; set; }

	}
}