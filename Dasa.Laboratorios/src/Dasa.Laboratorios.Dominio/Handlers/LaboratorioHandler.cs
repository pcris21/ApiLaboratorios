using Dasa.Laboratorios.Dominio.Commands.LaboratorioCommands.Inputs;
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

            //verificar se endereço é valido

            //criar entidade

            //verificar se entidade é valida

            //Chamar repositorio e Inserir


            throw new System.NotImplementedException();
        }
    }
}
