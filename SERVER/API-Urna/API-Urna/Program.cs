using API_Urna.Data;
using API_Urna.Repository;
using API_Urna.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_Urna
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer("Data Source=DESKTOP-79VD9KU\\SQLEXPRESS;Initial Catalog=Banco_API_Urna;Trusted_Connection=True"));

            // Configurando a injeção de dependências 
            builder.Services.AddScoped<ICandidatoRepositorio, CandidatoRepositorio>();
            builder.Services.AddScoped<IVotoRepositorio, VotoRepositorio>();

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}