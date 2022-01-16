using BusinessManagement.Data;
using BusinessManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.Services
{
    public class UserRepository : IUserRepository
    {
        BusinessManagementDbContext _dbContext;

        public UserRepository(BusinessManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<User>> GetUsersAsync()
        {
            return _dbContext.Users.ToListAsync();
        }
    }
}
