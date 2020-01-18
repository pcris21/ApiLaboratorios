using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Dominio.ObjetosDeValor;
using Dasa.Laboratorios.Shared;
using Dasa.Laboratorios.Shared.Entidades;
using FluentValidator.Validation;

namespace Dasa.Laboratorios.Dominio.Entidades
{
    public class Laboratorio : EntidadeBase
    {
        #region Construtores

        public Laboratorio(string nome, Endereco endereco, Status status)
        {
            AddNotifications(new ValidationContract()
              .HasMinLen(nome, 3, "Nome", Mensagens.NomeInvalido));

            Nome = nome;
            Endereco = endereco;
            Status = status;


        }

        #endregion


        #region Propriedades

        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public Status Status { get; private set; }

        #endregion


        #region Métodos

        public void AlterarNome(string nome)
        {
            AddNotifications(new ValidationContract()
             .HasMinLen(nome, 3, "Nome", Mensagens.NomeInvalido));

            if (Notifications.Count == 0)               
                Nome = nome;
        }

        public void AlterarEndereco(Endereco endereco)
        {
            if (endereco.Valid)
            {
                Endereco = new Endereco(endereco.Logradouro, endereco.Numero, endereco.Bairro,
                    endereco.Cidade, endereco.Estado, endereco.Cep);
            }

        }

        public void AlterarStatus(Status status)
        {
            Status = Status;
        } 

        #endregion
    }
}
