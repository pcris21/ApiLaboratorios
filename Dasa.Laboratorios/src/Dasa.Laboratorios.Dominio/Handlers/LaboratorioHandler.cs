using Dasa.Laboratorios.Dominio.Commands.LaboratorioCommands.Inputs;
using Dasa.Laboratorios.Shared.Commands;
using FluentValidator;

namespace Dasa.Laboratorios.Dominio.Handlers
{
    public class LaboratorioHandler : Notifiable, ICommandHandler<CriarLaboratorioCommand>
    {
        public LaboratorioHandler()
        {

        }

        public ICommandResult Handle(CriarLaboratorioCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
