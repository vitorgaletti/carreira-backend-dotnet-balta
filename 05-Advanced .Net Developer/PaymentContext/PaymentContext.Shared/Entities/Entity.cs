using Flunt.Notifications;

namespace PaymentContext.Shared.Entities;

public abstract class Entity : Notifiable
{
    public Guid Id { get; private set; } = Guid.NewGuid();
}