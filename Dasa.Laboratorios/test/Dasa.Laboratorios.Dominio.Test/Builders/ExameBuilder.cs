using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Enuns;
using System;

namespace Dasa.Laboratorios.Testes.Builders
{
    public class ExameBuilder
    {
        private string _nome = "Hemograma";
        private TipoExame _tipo = TipoExame.AnaliseClinica;
        private Status _status = Status.Ativo;
        private int _id;

        public static ExameBuilder Novo()
        {
            return new ExameBuilder();
        }

        public ExameBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public ExameBuilder ComTipo(TipoExame tipo)
        {
            _tipo = tipo;
            return this;
        }

        public ExameBuilder ComStatus(Status status)
        {
            _status = status;
            return this;
        }

        public ExameBuilder ComId(int id)
        {
            _id = id;
            return this;
        }

        public Exame Build()
        {
            var exameFake = new Exame(_nome, _tipo, _status);

            if (_id > 0)
            {
                var propertyInfo = exameFake.GetType().GetProperty("Id");
                propertyInfo.SetValue(exameFake, Convert.ChangeType(_id, propertyInfo.PropertyType), null);
            }

            return exameFake;
        }


    }
}
