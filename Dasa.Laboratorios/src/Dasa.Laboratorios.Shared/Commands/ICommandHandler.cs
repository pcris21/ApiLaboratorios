namespace Dasa.Laboratorios.Shared.Commands
{
    public interface ICommandHandlerr<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
