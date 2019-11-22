using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMvC.Models
{
	public class FoodItem
	{
		[Key] public int FoodItemId { get; set; }
		public string Title { get; set; }
		public Recipe Recipe { get; set; }
			
	}
}