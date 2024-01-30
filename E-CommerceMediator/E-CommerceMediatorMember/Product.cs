using System.Threading.Channels;

namespace E_CommerceMediatorMember;

public class Product : Colleague
{
    public Product(IMediator mediator) : base(mediator)
    {
    }

    public void ProductCreated()
    {
        Console.WriteLine("ProductCreated method used");
        _mediator.Notify(this);
    }

    public override void Handle(string info)
    {
        Console.WriteLine($"{nameof(Product)}, info: {info}");
    }
}