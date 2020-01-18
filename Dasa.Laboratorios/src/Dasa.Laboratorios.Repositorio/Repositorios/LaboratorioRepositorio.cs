using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Queries;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dasa.Laboratorios.Repositorio.Repositorios
{
    public class LaboratorioRepositorio : BaseRepositorio<Laboratorio>, ILaboratorioRepositorio
    {
        public LaboratorioRepositorio(ContextoLaboratorioBD contexto) : base(contexto)
        {
        }

        

        IEnumerable<LaboratorioQueryResult> ILaboratorioRepositorio.Listar()
        {
            var result = new List<LaboratorioQueryResult>();
            result.Add(new LaboratorioQueryResult { Nome = "Delboni", Status = "Ativo" });
            result.Add(new LaboratorioQueryResult { Nome = "Lavoisier", Status = "Ativo" });

            return result;
        }
    }
}
