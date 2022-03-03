namespace HemmsenHA.Core.NotificationMessages
{
    public class BaseEntityStateChanged<TEntityType> : INotification
    {
        public string EntityId { get; set; }
        public TEntityType? NewEntityState { get; set; }
        public TEntityType? OldEntityState { get; set; }
        public DateTimeOffset MeasuredAt { get; set; } = DateTimeOffset.Now;
    }
}
