namespace HomeAssistantGenerated
{
    public class CameraEntity
    {
        public void CallService(string service, NetatmoSetPersonAwayParameters data)
        {
            //do nothing here!
        }

        public void CallService(string service, NetatmoSetPersonsHomeParameters data)
        {
            //do nothing here!
        }


    }

    public static class CameraExtensions
    {
        public static void CallService(this IEnumerable<CameraEntity> target, string service, NetatmoSetPersonsHomeParameters data)
        {
            foreach (var item in target)
            {
                item.CallService("service", data);
            }
        }

        public static void CallService(this IEnumerable<CameraEntity> target, string service, NetatmoSetPersonAwayParameters data)
        {
            foreach (var item in target)
            {
                item.CallService("service", data);
            }
        }
    }
}