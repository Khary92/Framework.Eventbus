namespace Eventbus.Contract;

public interface IEventPublisher
{
    Task Publish<TEvent>(TEvent @event);
}