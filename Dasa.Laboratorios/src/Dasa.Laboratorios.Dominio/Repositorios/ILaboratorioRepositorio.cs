using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Queries;
using System.Collections.Generic;

namespace Dasa.Laboratorios.Dominio.Repositorios
{
    public interface ILaboratorioRepositorio: IBaseRepositorio<Laboratorio>
    {
        IEnumerable<LaboratorioQueryResult> Listar();
    }
}
