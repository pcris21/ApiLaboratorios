using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dasa.Laboratorios.Dominio.Entidades
{
   public class Exame : EntidadeBase
    {

        public Exame(string nome, TipoExame tipoExame, Status status)
        {

        }
        public string Nome { get; private set; }
        public TipoExame Tipo { get; private set; }
        public Status Status { get; set; }
    }
}
