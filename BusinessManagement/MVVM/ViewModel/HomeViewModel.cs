using BusinessManagement.Core;
using BusinessManagement.Data;
using BusinessManagement.Models;
using BusinessManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.MVVM.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private readonly IUserRepository userRepo;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private List<User> _users;
        public List<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Users)));
            }
        }

        public RelayCommand GetUsersCommand { get; set; }

        public HomeViewModel(IUserRepository userRepo)
        {
            this.userRepo = userRepo;

            GetUsersCommand = new RelayCommand(async (o) =>
            {
                Users = await userRepo.GetUsersAsync();
            });

            //Users = userRepo.GetUsersAsync().Result;
        }


    }
}
