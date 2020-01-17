using Bogus;
using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Enuns;
using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Dasa.Laboratorios.Testes.Entidades
{
    public class ExameTeste
    {
        private readonly string _nome;
        private readonly TipoExame _tipo;
        private readonly Status _status;
        private readonly Faker _faker;

        public ExameTeste()
        {
            _faker = new Faker();
            _nome = _faker.Random.Word();
            _tipo = TipoExame.AnaliseClinica;
            _status = Status.Ativo;
        }

        [Fact]
        public void DeveCriarExame()
        {

            var exameEsperado = new
            {
                Nome = _nome,
                Tipo = _tipo,
                Status = _status
            };

            var exame = new Exame(exameEsperado.Nome, exameEsperado.Tipo, exameEsperado.Status);

            exameEsperado.ToExpectedObject().ShouldMatch(exame);

        }

        [Theory]
        [InlineData("")]
        [InlineData("XY")]
        [InlineData("Z")]
        public void NaoDeveCriarExameComNomeInvalido(string nomeInvalido)
        {

        }

        [Fact]
        public void DeveAlterarNome()
        {

        }

        [Theory]
        [InlineData("")]
        [InlineData("TS")]
        [InlineData("H")]
        public void NaoDeveAlterarExameQuandoNomeForInvalido(string nomeInvalido)
        {

        }

        [Fact]
        public void DeveAlterarStatus()
        {

        }

        [Fact]
        public void DeveAlterarTipo()
        {

        }
    }
}
