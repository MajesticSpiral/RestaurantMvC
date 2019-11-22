
using RestaurantMvC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvC.Controllers
{
    public class BookTableController : Controller
    {
        // GET: BookTable
        public ActionResult Index()
        {
			CustomerRepository objCustomerRepository = new CustomerRepository();
			ItemRepository objItemRepository = new ItemRepository();
			PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();

			var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
				
				(objCustomerRepository.GetAllCustomers(), objItemRepository.GetAllItems(), objPaymentTypeRepository.GetAllPaymentType());


			return View(objMultipleModels);
        }
    }
}