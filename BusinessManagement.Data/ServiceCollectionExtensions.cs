using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessManagement.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<BusinessManagementDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

        }
    }
}
