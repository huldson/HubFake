using hub.aplication.Service;
using hub.Controllers;
using hub.domain.Contratos;
using hub.infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddScoped<IShop, Shop>(); // Adiciona a dependência entre a interface e a implementação NECESSARIO 
       // builder.Services.AddScoped<IMetodos, Metodos>(); tornei o metodo static não foi mais necessario 
        builder.Services.AddScoped<ILog, Log>();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        // Cria a instância de ControlerShop e resolve suas dependências Necessario
        using var serviceScope = app.Services.CreateScope();
        var serviceProvider = serviceScope.ServiceProvider;
        var controlerShop = ActivatorUtilities.CreateInstance<ShopController>(serviceProvider);

        app.Run();
    }
}
