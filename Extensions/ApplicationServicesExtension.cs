using Microsoft.EntityFrameworkCore;

namespace Razor_blog.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services, IConfiguration config)
        {

            services.AddRazorPages();
            services.AddDbContext<BlogContext>(x =>
                x.UseSqlServer(config.GetConnectionString("RazorBlog")));



            return services;
        }
    }
}
