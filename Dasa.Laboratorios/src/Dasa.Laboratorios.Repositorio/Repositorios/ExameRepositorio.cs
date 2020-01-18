using System.Collections.Generic;
using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Queries;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Repositorio.Contexto;

namespace Dasa.Laboratorios.Repositorio.Repositorios
{
    public class ExameRepositorio : BaseRepositorio<Exame>, IExameRepositorio
    {
        public ExameRepositorio(ContextoLaboratorioBD contexto) : base(contexto)
        {
        }

       

        IEnumerable<ExameQueryResult> IExameRepositorio.Listar()
        {
            var result = new List<ExameQueryResult>();

            result.Add(new ExameQueryResult {Nome = "Hemograma", Status = "Ativo", TipoExame = "Analise clinica" });

            return result;
        }
    }
}
