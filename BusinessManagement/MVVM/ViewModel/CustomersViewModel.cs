using BusinessManagement.Core;
using BusinessManagement.MVVM.ViewModel.Contracts;
using BusinessManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.MVVM.ViewModel
{
    public class CustomersViewModel : ViewModelBase, ICustomersViewModel
    {
        public IAddCustomerViewModel AddCustomerVm { get; set; }
        public ICustomersGridViewModel CustomersGridVm { get; set; }

        public RelayCommand AddCustomerCommand { get; set; }
        public RelayCommand CustomersGridCommand { get; set; }

        private object? currentView;

        public object? CurrentView
        {
            get => currentView; set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public CustomersViewModel(IUserRepository userRepo, IAddCustomerViewModel addCustomerVm, ICustomersGridViewModel customersGridVm)
        {
            this.AddCustomerVm = addCustomerVm;
            this.CustomersGridVm = customersGridVm;

            AddCustomerCommand = new RelayCommand(o =>
            {
                CurrentView = addCustomerVm;
                
            });

            CustomersGridCommand = new RelayCommand(o =>
            {
                CurrentView = customersGridVm;
            });

            currentView = customersGridVm;
        }
    }
}
