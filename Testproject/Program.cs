// See https://aka.ms/new-console-template for more information

using Eventbus.Contract;
using Eventbus.Generated;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

services.AddSingletonEventbusServices();
services.AddSingleton<Testproject.AService>();
services.AddSingleton<Testproject.Second.ASecondService>();
services.AddSingleton<Testproject.Second.AFourthService>();
services.AddSingleton<Testproject.Second.AThirdService>();

var sp = services.BuildServiceProvider();

var bus = sp.GetRequiredService<IEventPublisher>();
await bus.Publish(new Testproject.AnEvent("Hello World"));
await bus.Publish(new Testproject.Second.AdifferentEvent("Hello different World!"));

