using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Dominio.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dasa.Laboratorios.Testes.Builders
{
   public class LaboratorioBuilder
    {
        private string _nome = "Delboni";
        private Endereco _endereco = new Endereco("Rua Lapena", "1234", "Jardins", "Itu", "SP", "01234567");
        private Status _status = Status.Ativo;
        private int _id;

        public static LaboratorioBuilder Novo()
        {
            return new LaboratorioBuilder();
        }

        public LaboratorioBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public LaboratorioBuilder ComEndereco(Endereco endereco)
        {
            _endereco = new Endereco(endereco.Logradouro, endereco.Numero, endereco.Bairro,
                endereco.Cidade, endereco.Estado,endereco.Cep);

            return this;
        }

        public LaboratorioBuilder ComStatus(Status status)
        {
            _status = status;
            return this;
        }

        public LaboratorioBuilder ComId(int id)
        {
            _id = id;
            return this;
        }

        public Laboratorio Build()
        {
            var laboratorioFake = new Laboratorio(_nome, _endereco, _status);

            if (_id > 0)
            {
                var propertyInfo = laboratorioFake.GetType().GetProperty("Id");
                propertyInfo.SetValue(laboratorioFake, Convert.ChangeType(_id, propertyInfo.PropertyType), null);
            }

            return laboratorioFake;
        }
    }
}
