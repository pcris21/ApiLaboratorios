using Bogus;
using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Dominio.ObjetosDeValor;
using Dasa.Laboratorios.Testes.Builders;
using ExpectedObjects;
using Xunit;

namespace Dasa.Laboratorios.Testes.Entidades
{
    public class LaboratorioTeste
    {
        private readonly string _nome;
        private readonly Status _status;
        private readonly Endereco _endereco;
        private readonly Faker _faker;
        public LaboratorioTeste()
        {
            _faker = new Faker();

            //endereco


            _nome = _faker.Random.Word();
            _endereco = new Endereco(_faker.Address.StreetName(), _faker.Address.BuildingNumber(),
                 _faker.Address.City(), _faker.Address.StateAbbr(), _faker.Address.ZipCode());
            _status = Status.Ativo;

        }

        [Fact]
        public void DeveCriarLaboratorio()
        {
            var laboratorioEsperado = new
            {
                Nome = _nome,
                Endereco = _endereco,
                Status = _status

            };

            var laboratorio = new Laboratorio(laboratorioEsperado.Nome, laboratorioEsperado.Endereco, laboratorioEsperado.Status);

            laboratorioEsperado.ToExpectedObject().ShouldMatch(laboratorio);

        }

        [Theory]
        [InlineData("")]
        [InlineData("A")]
        [InlineData("AB")]
        public void NaoDeveCriarLaboratorioComNomeInvalido(string nomeInvalido)
        {
            var laboratorioFake = LaboratorioBuilder.Novo().ComNome(nomeInvalido).Build();

            Assert.True(laboratorioFake.Invalid);
        }

        [Fact]
        public void DeveAlterarNome()
        {
            var nomeEsperado = _faker.Random.Word();
            var laboratorioFake = LaboratorioBuilder.Novo().Build();
            laboratorioFake.AlterarNome(nomeEsperado);

            Assert.True(laboratorioFake.Valid);
        }

        [Theory]
        [InlineData("")]
        [InlineData("A")]
        [InlineData("AB")]
        public void NaoDeveAlterarQuandoNomeForInvalido(string nomeInvalido)
        {
            var laboratorioFake = LaboratorioBuilder.Novo().Build();
            laboratorioFake.AlterarNome(nomeInvalido);

            Assert.True(laboratorioFake.Invalid);
        }

        [Fact]
        public void DeveAlterarStatus()
        {

        }

        [Fact]
        public void DeveAlterarEndereco()
        {
            var laboratorioFake = LaboratorioBuilder.Novo().Build();

            var enderecoAlterado = new Endereco(_faker.Address.StreetName(), _faker.Address.BuildingNumber(),
                 _faker.Address.City(), _faker.Address.StateAbbr(), _faker.Address.ZipCode());

            laboratorioFake.AlterarEndereco(enderecoAlterado);

            Assert.True(laboratorioFake.Valid);
        }

        [Theory]
        [InlineData("")]
        [InlineData("000")]
        [InlineData("010100")]
        public void NaoDeveAlterarQuandoEnderecoForInvalido(string zipCodeInvalido)
        {
            var laboratorioFake = LaboratorioBuilder.Novo().Build();

            var enderecoAlterado = new Endereco(_faker.Address.StreetName(), _faker.Address.BuildingNumber(),
                 _faker.Address.City(), _faker.Address.StateAbbr(), zipCodeInvalido);

            laboratorioFake.AlterarEndereco(enderecoAlterado);

            Assert.True(enderecoAlterado.Invalid);
            Assert.NotEqual(laboratorioFake.Endereco.Cep, enderecoAlterado.Cep);
        }
    }
}
