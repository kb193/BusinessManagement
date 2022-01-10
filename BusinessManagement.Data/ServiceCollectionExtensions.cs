using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddDbContext<BusinessManagementDbContext>(options =>
            {
                options.UseSqlServer("Data Source=DESKTOP-2P8RQV3");
            });
        }
    }
}
