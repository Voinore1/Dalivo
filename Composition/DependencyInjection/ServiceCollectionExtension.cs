using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Presentation.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => 
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        
        services.AddControllers();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        
        return services;
    }
}