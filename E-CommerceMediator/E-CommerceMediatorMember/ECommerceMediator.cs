namespace E_CommerceMediatorMember;

public class ECommerceMediator : IMediator
{

    public Product Product { get; set; }
    public Order Order { get; set; }

  

    public void Notify(Colleague colleague)
    {
        if (colleague == Product)
        {
            Product.Handle("Product used");
            Order.OrderStarted();
        }
        else
        {
            Order.Handle("Order used");
        }
    }
}