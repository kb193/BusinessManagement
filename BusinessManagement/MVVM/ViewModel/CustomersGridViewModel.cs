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
    class CustomersGridViewModel : ViewModelBase, ICustomersGridViewModel
    {

        public RelayCommand CustomersEditVmCommand { get; set; }
        public RelayCommand CustomerAddVmCommand { get; set; }


        private object? currentView;
        public object? CurrentView
        {
            get => currentView; set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public CustomersGridViewModel() 
        {

       

        }


    }
}
