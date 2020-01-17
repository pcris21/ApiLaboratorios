using Dasa.Laboratorios.Dominio.Commands.LaboratorioCommands.Inputs;
using Dasa.Laboratorios.Dominio.ObjetosDeValor;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Shared.Commands;
using FluentValidator;

namespace Dasa.Laboratorios.Dominio.Handlers
{
    public class LaboratorioHandler : Notifiable, ICommandHandler<CriarLaboratorioCommand>
    {
        private readonly ILaboratorioRepositorio _laboratorioRepository;
        public LaboratorioHandler(ILaboratorioRepositorio laboratorioRepositorio)
        {
            _laboratorioRepository = laboratorioRepositorio;
        }

        public ICommandResult Handle(CriarLaboratorioCommand command)
        {
            //criar Obf endereço
            var endereco = new Endereco(command.Logradouro,
                                        command.Numero,
                                        command.Bairro,
                                        command.Cidade,
                                        command.Estado,
                                        command.Cep);

            if (string.IsNullOrEmpty(command.Complemento))           
                endereco.AdicionarComplemento(command.Complemento);



            //verificar se endereço é valido
            if (endereco.Invalid)
            {

            }

            //criar entidade

            //verificar se entidade é valida

            //Chamar repositorio e Inserir


            throw new System.NotImplementedException();
        }
    }
}
