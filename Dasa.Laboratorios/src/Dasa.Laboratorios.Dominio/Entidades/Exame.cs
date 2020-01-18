using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Shared;
using Dasa.Laboratorios.Shared.Entidades;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dasa.Laboratorios.Dominio.Entidades
{
   public class Exame : EntidadeBase
    {
        #region Construtores

        public Exame(string nome, TipoExame tipo, Status status)
        {
            AddNotifications(new ValidationContract()
                .HasMinLen(nome, 3, "Nome", Mensagens.NomeInvalido));

            Nome = nome;
            Tipo = tipo;
            Status = status;
        }

        #endregion

        #region Propriedades

        public string Nome { get; private set; }
        public TipoExame Tipo { get; private set; }
        public Status Status { get; set; }

        #endregion

        #region Métodos

        public void AlterarNome(string nome)
        {
            AddNotifications(new ValidationContract()
                .HasMinLen(nome, 3, "Nome", Mensagens.NomeInvalido));

            if (Notifications.Count == 0)           
                Nome = nome;
                      
        }

        public void AlterarTipo(TipoExame tipo)
        {

        }

        public void AlterarStatus(Status status)
        {

        } 

        #endregion
    }

}
