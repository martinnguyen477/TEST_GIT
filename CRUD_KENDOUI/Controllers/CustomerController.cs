using CRUD_KENDOUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_KENDOUI.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository customerRepository = new CustomerRepository();

        // GET: CustomerController
        public JsonResult GetCustomer()
        {
            var cus = customerRepository.GetAllCustomer();
            var result = new
            {
                Items = cus,
                TotalCount = cus.Count
            };
            return new JsonResult(result);
            ///casgasgasga force checkout/
            //hhh/h/h/h/h/h/h/

        }
    }
}
