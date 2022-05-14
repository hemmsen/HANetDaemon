// namespace HemmsenHA.apps.Eva
// {
//     [NetDaemonApp]
//     public class EvaTemperatureApp
//     {
//         public EvaTemperatureApp(IEntities entities, IMediator mediator, ILogger<EvaWindowSensorApp> logger, INetDaemonScheduler scheduler)
//         {
//             try
//             {
//                 entities.Climate.NetatmoEva
//                 .StateAllChanges()
//                 .Where(x => x.New.Attributes.CurrentTemperature > 19 DateTime.Now.)
//                 // scheduler.RunDaily(TimeSpan.FromHours(18), async () =>
//                 // {
//                 //     if (entities?.Climate?.NetatmoEva?.Attributes?.CurrentTemperature > 19)
//                 //     {
//                 //         var notification = new SpeakerNotification()
//                 //         {
//                 //             EntityId = entities.MediaPlayer.TvStue.EntityId,
//                 //             NotificationMessage = "Husk at åben vinduet på Evas værelse"
//                 //         };
//                 //         await mediator.Publish(notification);
//                 //     }
//                 // });
//             }
//             catch (Exception ex)
//             {
//                 logger.LogCritical(ex, "Error starting {AppName}", nameof(EvaWindowSensorApp));
//             }
//         }
//     }
// }
