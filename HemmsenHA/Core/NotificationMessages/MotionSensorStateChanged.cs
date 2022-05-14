namespace HemmsenHA.Core.NotificationMessages;
public class MotionSensorStateActive : BaseEntityStateChanged<EntityState<BinarySensorAttributes>>
{
    public string LightEntityId { get; set; }
}