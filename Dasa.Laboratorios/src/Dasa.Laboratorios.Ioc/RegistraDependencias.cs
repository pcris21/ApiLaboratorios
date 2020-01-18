using Dasa.Laboratorios.Dominio.Handlers;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Repositorio.Contexto;
using Dasa.Laboratorios.Repositorio.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dasa.Laboratorios.Ioc
{
    public static class RegistraDependencias
    {
        public static void ConfiguraServicos(IServiceCollection servicos, IConfiguration configuracao)
        {
            servicos.AddDbContext<ContextoLaboratorioBD>(opcoes =>
            opcoes.UseSqlServer(configuracao.GetConnectionString("DefaultConnection")));

            servicos.AddScoped(typeof(IBaseRepositorio<>), typeof(BaseRepositorio<>));
            servicos.AddScoped<IUnitOfWork, UnitOfWork>();

            servicos.AddScoped<ILaboratorioRepositorio, LaboratorioRepositorio>();
            servicos.AddScoped<IExameRepositorio, ExameRepositorio>();

            servicos.AddScoped<LaboratorioHandler, LaboratorioHandler>();
            servicos.AddScoped<ExameHandler, ExameHandler>();
        }
    }
}
