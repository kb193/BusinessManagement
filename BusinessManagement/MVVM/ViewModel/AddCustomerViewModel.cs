using BusinessManagement.Core;
using BusinessManagement.Models;
using BusinessManagement.MVVM.ViewModel.Contracts;
using BusinessManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.MVVM.ViewModel
{
    public class AddCustomerViewModel : ViewModelBase, IAddCustomerViewModel
    {
        public Customer Customer { get; set; }

        public AddCustomerViewModel() 
        {

        }


    }
}
