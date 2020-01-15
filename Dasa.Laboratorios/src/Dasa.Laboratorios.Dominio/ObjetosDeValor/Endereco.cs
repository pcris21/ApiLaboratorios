using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dasa.Laboratorios.Dominio.ObjetosDeValor
{
    public class Endereco : Notifiable
    {

        public Endereco(string logradouro,
            string numero, 
            string bairro,
            string cidade, 
            string estado,
            string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Logradouro, 5, "Logradouro", "O campo Logradouro deve conter no minimo 5 caracteres")
                .HasMinLen(Numero, 1, "Numero","o campo Numero deve conter no minimo 1 caracter")
                .HasMinLen(Cidade, 3, "Cidade", "O campo Cidade deve conter no minimo 3 caracteres")
                .HasLen(Estado, 2, "Estado", "O campo Estado deve conter 2 caracteres")
                .HasLen(Cep, 8, "Cep", "O campo Cep deve conter 8 caracteres"));
        }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; set; }


        private void AdicionarComplemento(string complemento)
        {
            Complemento = complemento;
        }
    }
}
