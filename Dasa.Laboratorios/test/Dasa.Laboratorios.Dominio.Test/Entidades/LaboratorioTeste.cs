using Bogus;
using Dasa.Laboratorios.Dominio.Enuns;
using Xunit;

namespace Dasa.Laboratorios.Testes.Entidades
{
    public class LaboratorioTeste
    {
        private readonly string _nome;
        private readonly Status _status;
        private readonly Faker _faker;
        public LaboratorioTeste()
        {
            _faker = new Faker();

            //endereco


            _nome = _faker.Random.Word();
            _status = Status.Ativo;

        }

        [Fact]
        public void DeveCriarLaboratorio()
        {
           

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarLaboratorioComNomeInvalido(string nome)
        {

        }

        [Fact]
        public void DeveAlterarNome()
        {

        }

        [Fact]
        public void NaoDeveAlterarQuandoNomeForInvalido()
        {

        }

        [Fact]
        public void DeveAlterarStatus()
        {

        }

        [Fact]
        public void DeveAlterarEndereco()
        {

        }

        [Fact]
        public void NaoDeveAlterarQuandoEnderecoForInvalido()
        {

        }
    }
}
