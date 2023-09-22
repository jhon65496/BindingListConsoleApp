using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace BindingListConsoleApp
{
    public class Customer : INotifyPropertyChanged
    {
        private int customerID;        
        [DisplayName("CustomerID")]
        public int CustomerID
        {
            get { return customerID; }
            set 
            { 
                customerID = value;
                OnPropertyChanged();
            }
        }

        
        private string customerName;
        [DisplayName("CustomerName")]
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            // Debug.WriteLine(_name);
        }
    }
}
