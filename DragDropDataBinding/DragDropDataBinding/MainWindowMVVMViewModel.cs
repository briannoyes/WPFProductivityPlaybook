using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDropDataBinding
{
    public class MainWindowMVVMViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Status> _statuses;
        private ObservableCollection<Customer> _customers;

        public MainWindowMVVMViewModel()
        {
            Customers = new ObservableCollection<Customer>(DataLayer.GetCustomers());
            Statuses = new ObservableCollection<Status>(DataLayer.GetStatuses());
        }

        public ObservableCollection<Status> Statuses
        {
            get
            {
                return _statuses;
            }
            set
            {
                _statuses = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
            }
        }

        public ObservableCollection<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Customers"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
