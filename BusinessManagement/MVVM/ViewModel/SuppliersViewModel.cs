using BusinessManagement.MVVM.ViewModel.Contracts;
using BusinessManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.MVVM.ViewModel
{
    public class SuppliersViewModel : ViewModelBase, ISuppliersViewModel
    {
        public SuppliersViewModel(IUserRepository userRepo)
        {

        }
    }
}
