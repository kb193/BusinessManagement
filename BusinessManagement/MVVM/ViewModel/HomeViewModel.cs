using BusinessManagement.Data;
using BusinessManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.MVVM.ViewModel
{
    public class HomeViewModel
    {
        private readonly BusinessManagementDbContext dbContext;
        public List<User> Users { get; set; }

        public HomeViewModel(BusinessManagementDbContext dbContext)
        {
            this.dbContext = dbContext;

            //Users = dbContext.Users.ToList();
        }


    }
}
