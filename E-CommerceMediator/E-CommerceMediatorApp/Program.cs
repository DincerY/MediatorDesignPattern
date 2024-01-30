using E_CommerceMediatorMember;

ECommerceMediator mediator = new ECommerceMediator();


Product product = new(mediator);
Order order = new(mediator);

mediator.Product = product;
mediator.Order = order;


product.ProductCreated();
