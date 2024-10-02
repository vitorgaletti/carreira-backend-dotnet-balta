using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Handlers.Interfaces
{
    public interface IHandler<in T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}