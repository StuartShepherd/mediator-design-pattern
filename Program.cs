using MediatorDesignPattern;

Console.WriteLine("Mediator Design Pattern");
Console.WriteLine("Mediator is a behavioral design pattern that reduces coupling between components of a program by making them communicate indirectly, through a special mediator object.");
Console.WriteLine();

Component1 component1 = new();
Component2 component2 = new();
new ConcreteMediator(
    component1, 
    component2);

Console.WriteLine("Client triggers operation Alpha");
component1.DoAlpha();

Console.WriteLine();

Console.WriteLine("Client triggers operation Delta.");
component2.DoDelta();
