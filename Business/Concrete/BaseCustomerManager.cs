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
    public abstract class BaseCustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        protected BaseCustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public virtual void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }
    }
}
