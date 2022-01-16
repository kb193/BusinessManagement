using BusinessManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.Services
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
    }
}
