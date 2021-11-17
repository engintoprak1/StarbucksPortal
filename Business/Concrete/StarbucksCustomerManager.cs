using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        ICustomerDal _customerDal;
        
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService,ICustomerDal customerDal):base(customerDal)
        {
            _customerCheckService = customerCheckService;
            _customerDal = customerDal;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        
    }
}
