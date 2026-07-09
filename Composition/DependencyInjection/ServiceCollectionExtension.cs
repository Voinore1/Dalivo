using Domain.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Presentation.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => 
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        
        services.AddControllers();
        
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        
        return services;
    }
}