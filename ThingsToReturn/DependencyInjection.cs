using ThingsToReturn.Interfaces;
using ThingsToReturn.Repositories;
using ThingsToReturn.Services;

namespace ThingsToReturn
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this IServiceCollection services)
        {
            services.AddTransient<IOfferService, OfferService>();
            services.AddTransient<IOfferRepository, OfferRepository>();

            services.AddTransient<IOfferCategoryService, OfferCategoryService>();
            services.AddTransient<IOfferCategoryRepository, OfferCategoryRepository>();

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddTransient<IAppUserService, AppUserService>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();

            services.AddTransient<IAppUserOfferService, AppUserOfferService>();
            services.AddTransient<IAppUserOfferRepository, AppUserOfferRepository>();

            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<IAddressRepository, AddressRepository>();

            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<ICommentRepository, CommentRepository>();

            return services;
        }
    }
}
