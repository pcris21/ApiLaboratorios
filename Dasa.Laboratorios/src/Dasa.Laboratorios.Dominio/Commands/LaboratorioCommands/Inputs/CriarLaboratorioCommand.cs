using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dasa.Laboratorios.Dominio.Commands.LaboratorioCommands.Inputs
{
    public class CriarLaboratorioCommand : ICommand
    {
        public string Nome { get; set; }
        public Status Status { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public bool Valid()
        {
            throw new NotImplementedException();
        }
    }
}
