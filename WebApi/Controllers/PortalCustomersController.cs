using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    
    public class PortalCustomersController : Controller
    {
        ICustomerService customerService = new PortalCustomerManager(new EfCustomerDal());



        [HttpPost("[controller]/add")]
        public IActionResult Add(Customer customer)
        {
            customerService.Add(customer);
            return RedirectToAction("GetAll");
        }
        [HttpGet("[controller]/add")]
        public IActionResult Add()
        {
            return View(new Customer());
        }
        [HttpGet("[controller]/getall")]
        public IActionResult GetAll()
        {
            var result = customerService.GetAll("portal");
            return View(result);
        }
    }
}
