namespace Weather.Domain.Events;

public record OrderCreatedEvent(Order order) : IDomainEvent;
