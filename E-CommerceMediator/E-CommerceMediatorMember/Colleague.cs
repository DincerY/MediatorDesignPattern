namespace E_CommerceMediatorMember;

public abstract class Colleague
{
    protected IMediator _mediator;

    protected Colleague(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Handle(string info);
}