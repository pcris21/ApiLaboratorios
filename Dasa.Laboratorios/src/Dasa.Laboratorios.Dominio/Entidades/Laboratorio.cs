using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Dominio.ObjetosDeValor;
using Dasa.Laboratorios.Shared.Entidades;
using FluentValidator.Validation;

namespace Dasa.Laboratorios.Dominio.Entidades
{
    public class Laboratorio : EntidadeBase
    {
        public Laboratorio(string nome, Endereco endereco, Status status)
        {
            Nome = nome;
            Endereco = endereco;
            Status = status;

            AddNotifications(new ValidationContract()
               .HasMinLen(Nome, 3, "Nome", "O campo nome deve ter no minimo 3 caracteres"));
        }

        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public Status Status { get; private set; }

             
    }
}
