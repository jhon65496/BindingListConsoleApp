using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingListConsoleApp
{
    internal class Worker
    {
        CustomersVM customersVM;
        public Worker()
        {
            customersVM = new CustomersVM();
            
            Update();
        }


        public void Update()
        {
            Customer baseCustomer = new Customer()
            {
                CustomerID = 3,
                CustomerName = "CustomerName-3"
            };

            Customer newCustomer = new Customer()
            {
                CustomerID = 3,
                CustomerName = "CustomerName-3-Modifi"
            };

            customersVM.Update(baseCustomer, newCustomer);
        }

    }
}
