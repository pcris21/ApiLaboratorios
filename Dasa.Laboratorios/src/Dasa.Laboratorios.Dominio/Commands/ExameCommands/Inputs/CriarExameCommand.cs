using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dasa.Laboratorios.Dominio.Commands.ExameCommands.Inputs
{
   public class CriarExameCommand : ICommand
    {
        public string Nome { get; set; }
        public TipoExame Tipo { get; set; }
        public Status Status { get; set; }

        public bool Valid()
        {
            throw new NotImplementedException();
        }
    }
}
