using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace BindingListConsoleApp
{
    class CustomersVM : INotifyPropertyChanged      
    {
       
        private BindingList<Customer> сustomersBl;

        public BindingList<Customer> CustomersBl
        {
            get { return сustomersBl; }
            set
            {
                сustomersBl = value;
                Debug.WriteLine("CustomersVM.сustomersBl : BindingList<Customer> CustomersBl");
                OnPropertyChanged("CustomersBl");
            }
        }


        public CustomersVM()
        {   
            LoadData();
        }

        

        private void LoadData()
        {
            CustomersBl = new BindingList<Customer>();

            CustomersBl.Add(new Customer() { CustomerID = 1, CustomerName = "CustomerName-1" });
            CustomersBl.Add(new Customer() { CustomerID = 2, CustomerName = "CustomerName-2" });
            CustomersBl.Add(new Customer() { CustomerID = 3, CustomerName = "CustomerName-3" });
        }

       
        public void Update(Customer baseCustomer, Customer newCustomer)
        {
            // int index = CustomersBl.IndexOf(baseCustomer);            
            int index = CustomersBl.IndexOf(CustomersBl.First(c => c.CustomerID == baseCustomer.CustomerID));
            CustomersBl[index] = newCustomer;
            var result = CustomersBl[index];
            // Debug.WriteLine($"{}");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
