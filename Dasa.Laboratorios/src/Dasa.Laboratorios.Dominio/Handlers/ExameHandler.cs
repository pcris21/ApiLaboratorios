using Dasa.Laboratorios.Dominio.Commands;
using Dasa.Laboratorios.Dominio.Commands.ExameCommands;
using Dasa.Laboratorios.Dominio.Commands.ExameCommands.Inputs;
using Dasa.Laboratorios.Dominio.Commands.LaboratorioCommands.Inputs;
using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Shared;
using Dasa.Laboratorios.Shared.Commands;
using FluentValidator;

namespace Dasa.Laboratorios.Dominio.Handlers
{
    public class ExameHandler : Notifiable, ICommandHandler<CriarExameCommand>
    {
        private readonly IExameRepositorio _exameRepositorio;
        public ExameHandler(IExameRepositorio exameRepositorio)
        {
            _exameRepositorio = exameRepositorio;
        }
        public ICommandResult Handle(CriarExameCommand command)
        {  

            //criar entidade

            var exame = new Exame(command.Nome, command.Tipo, command.Status);

            if (exame.Invalid)
            {
                return new CommandResult(false, Mensagens.CorrigirCampos, Notifications);
            }


            _exameRepositorio.Adicionar(exame);

            return new CommandResult(true, Mensagens.ExameCadastrado, new { });
        }
    }
}
