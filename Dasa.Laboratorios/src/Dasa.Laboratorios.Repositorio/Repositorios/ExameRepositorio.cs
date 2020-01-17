using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Repositorio.Contexto;

namespace Dasa.Laboratorios.Repositorio.Repositorios
{
    public class ExameRepositorio : BaseRepositorio<Exame>, IExameRepositorio
    {
        public ExameRepositorio(ContextoLaboratorioBD contexto) : base(contexto)
        {
        }
    }
}
