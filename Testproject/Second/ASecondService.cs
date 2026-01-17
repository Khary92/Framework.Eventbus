using Eventbus.Contract;

namespace Testproject.Second;

public class ASecondService : IRecipient<AnEvent>, IRecipient<AdifferentEvent>
{
    public Task Receive(AnEvent @event)
    {
        Console.WriteLine("Event received in ASecondService " + @event.AName);
        return Task.CompletedTask;
    }

    public Task Receive(AdifferentEvent @event)
    {
        Console.WriteLine("Event received in ASecondService " + @event.AName);
        return Task.CompletedTask;
    }
}

public class AThirdService : IRecipient<AnEvent>
{
    public Task Receive(AnEvent @event)
    {
        Console.WriteLine("Event received in AThirdService " + @event.AName);
        return Task.CompletedTask;
    }
}

public class AFourthService : IRecipient<AnEvent>, IRecipient<AdifferentEvent>
{
    public Task Receive(AnEvent @event)
    {
        Console.WriteLine("Event received in AFourthService " + @event.AName);
        return Task.CompletedTask;
    }

    public Task Receive(AdifferentEvent @event)
    {
        Console.WriteLine("Event received in AFourthService " + @event.AName);
        return Task.CompletedTask;
    }
}

public record AdifferentEvent(string AName);