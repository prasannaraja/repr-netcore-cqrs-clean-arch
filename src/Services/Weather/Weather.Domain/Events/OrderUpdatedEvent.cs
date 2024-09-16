namespace Weather.Domain.Events;

public record OrderUpdatedEvent(Order order) : IDomainEvent;
