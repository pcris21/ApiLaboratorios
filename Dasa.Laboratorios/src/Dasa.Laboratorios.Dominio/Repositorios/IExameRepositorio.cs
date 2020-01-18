using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Queries;
using System.Collections.Generic;

namespace Dasa.Laboratorios.Dominio.Repositorios
{
    public interface IExameRepositorio: IBaseRepositorio<Exame>
    {
        IEnumerable<ExameQueryResult> Listar();
    }
}
