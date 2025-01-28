using CleanArch.Application.Mappings;

namespace CleanArch.MVC.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if(services == null) throw new ArgumentException(nameof(services));

            services.AddAutoMapper(typeof(DomainViewModelMappingProfile),
                typeof(ViewModelToDomainMappingProfile));
        }
    }
}
