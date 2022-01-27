using BusinessManagement.Core;
using BusinessManagement.MVVM.ViewModel.Contracts;
using BusinessManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BusinessManagement.MVVM.ViewModel
{
    public class CustomersViewModel : ViewModelBase, ICustomersViewModel
    {
        public RelayCommand SwitchCommand { get; set; }

        private Visibility _editVisible;

        public Visibility EditVisible
        {
            get
            {
                return _editVisible;
            }
            set
            {
                _editVisible = value;
                OnPropertyChanged();
            }
        }


        private string _button1Text;

        public string Button1Text
        {
            get { return _button1Text; }
            set
            {
                _button1Text = value;
                OnPropertyChanged();
            }
        }

        private object? currentView;

        public object? CurrentView
        {
            get => currentView; set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public IAddCustomerViewModel AddCustomerVm { get; }
        public ICustomersGridViewModel CustomersGridVm { get; }

        public CustomersViewModel(IUserRepository userRepo, IAddCustomerViewModel addCustomerVm, ICustomersGridViewModel customersGridVm)
        {
            SwitchCommand = new RelayCommand(o =>
            {
                if (CurrentView == CustomersGridVm)
                {
                    CurrentView = AddCustomerVm;
                    Button1Text = "Save";
                    EditVisible = Visibility.Hidden;
                }
                else
                {
                    CurrentView = CustomersGridVm;
                    Button1Text = "Add";
                    EditVisible = Visibility.Visible;
                }
            });

            Button1Text = "Add";

            AddCustomerVm = addCustomerVm;
            CustomersGridVm = customersGridVm;

            CurrentView = CustomersGridVm;
        }
    }
}
