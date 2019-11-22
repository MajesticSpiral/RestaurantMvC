using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMvC.Models
{
	public class Recipe
	{

		[Key] public int RecipeId { get; set; }
		public string Name { get; set; }

	}
}