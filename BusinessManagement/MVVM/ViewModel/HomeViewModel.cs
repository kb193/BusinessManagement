using BusinessManagement.Core;
using BusinessManagement.Data;
using BusinessManagement.Models;
using BusinessManagement.MVVM.ViewModel.Contracts;
using BusinessManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.MVVM.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public ICustomersViewModel CustomersVm { get; set; }
        public ISuppliersViewModel SuppliersVm { get; set; }
        public IDashboardViewModel DashboardVm { get; set; }

        public RelayCommand CustomersVmCommand { get; set; }
        public RelayCommand SuppliersVmCommand { get; set; }
        public RelayCommand DashboardVmCommand { get; set; }
      
        private object? currentView;

        public object? CurrentView
        {
            get => currentView; set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel(ICustomersViewModel customerVm, ISuppliersViewModel suppliersVm, IDashboardViewModel dashboardVm)
        {
            CustomersVm = customerVm;
            SuppliersVm = suppliersVm;
            DashboardVm = dashboardVm;

            CustomersVmCommand = new RelayCommand(o =>
            {
                CurrentView = CustomersVm;
            });

            SuppliersVmCommand = new RelayCommand(o =>
            {
                CurrentView = SuppliersVm;
            });

            DashboardVmCommand = new RelayCommand(o => { 
                CurrentView = DashboardVm; 
            });

            CurrentView = DashboardVm;
        }


    }
}
