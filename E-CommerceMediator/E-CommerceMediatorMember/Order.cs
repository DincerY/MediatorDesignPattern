namespace E_CommerceMediatorMember;

public class Order : Colleague
{
    public Order(IMediator mediator) : base(mediator)
    {
    }

    public void OrderStarted()
    {
        Console.WriteLine("OrderStarted method used");
        _mediator.Notify(this);
    }

    public override void Handle(string info)
    {
        Console.WriteLine($"{nameof(Order)}, info: {info}");

    }
}