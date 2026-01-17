namespace Eventbus.Contract;

public interface IRecipient<TEvent>
{
    Task Receive(TEvent @event);
}