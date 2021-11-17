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
    public class PortalCustomerManager : BaseCustomerManager
    {
        public PortalCustomerManager(ICustomerDal customerDal) : base(customerDal)
        {
        }

        public override void Add(Customer customer)
        {
            base.Add(customer);
        }
    }
}
