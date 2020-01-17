using Dasa.Laboratorios.Dominio.Entidades;
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
    }
}
