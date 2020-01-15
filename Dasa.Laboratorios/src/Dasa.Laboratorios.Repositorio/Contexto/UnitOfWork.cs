using System.Threading.Tasks;
using Dasa.Laboratorios.Dominio.Repositorios;

namespace Dasa.Laboratorios.Repositorio.Contexto
{
    public class UnitOfWork : IUnitOfWork
    {
        private ContextoLaboratorioBD _contexto;

        public UnitOfWork(ContextoLaboratorioBD contexto)
        {
            _contexto = contexto;
        }
        public async Task Commit()
        {
            await _contexto.SaveChangesAsync();
        }
    }
}
