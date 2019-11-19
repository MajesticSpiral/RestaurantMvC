using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvC.Models
{
	[Bind(Exclude = "MenuItemId")]
	public class MenuItems
	{
		[ScaffoldColumn(false)]
		public int MenuItemId { get; set; }


		[Required(ErrorMessage = "Price is required")]
		[Range(0.01, 100.00,
			ErrorMessage = "Price must be between 0.01 and 100.00")]
		public decimal Price { get; set; }

		

		public virtual MenuItems MenuItem { get; set; }
		public virtual List<MenuItems> OrderDetails { get; set; }
	}
}