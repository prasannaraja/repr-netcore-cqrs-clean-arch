using Weather.Domain.Abstractions;
using Weather.Domain.Models;

namespace Weather.Domain.Events;

public record OrderUpdatedEvent(Order order) : IDomainEvent;
