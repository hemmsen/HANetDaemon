//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HemmsenHA.apps.LivingRoom
//{
//    [NetDaemonApp]
//    public class CO2CheckerApp
//    {
//        public CO2CheckerApp(IHaContext haContext, ILogger<CO2CheckerApp> logger)
//        {
//            var entities = new Entities(haContext);
//            var services = new Services(haContext);
//            try
//            {
//                entities.Sensor.NetatmoEngelstoft157IndoorCo2
//                    .StateChanges()
//                    .Subscribe(s =>
//                    {
//                        var newState = s.New.State;
//                        var oldState = s.Old.State;
//                        //Set helper
//                        if (newState >= 1000 && oldState <= 1000)
//                        {
//                            services.InputBoolean.TurnOn(ServiceTarget.FromEntity(entities.InputBoolean.Co2leveltohighlivingroom.EntityId));
//                            services.Light.TurnOn(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId), new LightTurnOnParameters() { Flash = "short" });
//                        }

//                    });
//                entities.Sensor.NetatmoEngelstoft157IndoorCo2
//                    .StateChanges()
//                    .Subscribe(s =>
//                    {
//                        //Set helper
//                        var newState = s.New.State;
//                        var oldState = s.Old.State;
//                        if (newState < 1000 && oldState > 1000)
//                        {
//                            services.InputBoolean.TurnOff(ServiceTarget.FromEntity(entities.InputBoolean.Co2leveltohighlivingroom.EntityId));
//                        }
//                    });
//            }
//            catch (Exception ex)
//            {
//                logger.LogCritical(ex, "Error starting {AppName}", nameof(CO2CheckerApp));
//            }
//        }
//    }
//}
