namespace HemmsenHA.Core.NotificationMessages
{
    public class WindowStateChanged : BaseEntityStateChanged<EntityState<BinarySensorAttributes>>
    {
        public DateTime StateChangedAt { get; set; } = DateTime.Now;
    }
}
