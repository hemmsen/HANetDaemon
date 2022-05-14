namespace HemmsenHA.Core.NotificationMessages;
public class MotionSensorCleared : BaseEntityStateChanged<EntityState<BinarySensorAttributes>>
{
    public string LightEntityId { get; set; }
}