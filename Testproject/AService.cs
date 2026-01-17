using Eventbus.Contract;

namespace Testproject;

public class AService : IRecipient<AnEvent>
{
    public Task Receive(AnEvent @event)
    {
        Console.WriteLine($"Received event: {@event.AName}");
        return Task.CompletedTask;
    }
}