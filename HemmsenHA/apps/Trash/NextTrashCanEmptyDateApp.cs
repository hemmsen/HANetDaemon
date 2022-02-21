using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.apps.Trash
{
    [NetDaemonApp]
    [Focus]
    public class NextTrashCanEmptyDateApp
    {
        private IServices _services;
        private IEntities _entities;
        private readonly ILogger<NextTrashCanEmptyDateApp> _logger;
        public NextTrashCanEmptyDateApp(INetDaemonScheduler scheduler, ILogger<NextTrashCanEmptyDateApp> logger, IHaContext haContext)
        {
            _entities = new Entities(haContext);
            _services = new Services(haContext);
            _logger = logger;
            try
            {
                CheckNextRenovationEmptyDate().Wait();
                scheduler.RunDaily(TimeSpan.Parse("01:00:00"), () => CheckNextRenovationEmptyDate().Wait());
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
            }
        }
        public async Task CheckNextRenovationEmptyDate()
        {
            //Fetch data from website
            var htmlDoc = new HtmlAgilityPack.HtmlWeb();
            var doc = await htmlDoc.LoadFromWebAsync(@"https://mitaffald.affaldvarme.dk/Adresse/VisAdresseInfo?address-search=Engelstoft%2C+8520+Lystrup&number-search=157&address-selected-vejkode=&address-selected-postnr=8520&address-selected-id=");
            var recycleContainer = doc.DocumentNode.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td[4]").InnerHtml.Split("/");
            //Parse data
            var res = doc.DocumentNode.SelectSingleNode("/html/body/div[4]/div/div/div[4]/div[1]/div[2]/div/div/div/table/tbody/tr/td[4]");
            var inner = res.InnerHtml.Split("/");
            var dt = new DateTime(DateTime.Now.Year, int.Parse(inner.Last()), int.Parse(inner.First()));
            var recycleDT = new DateTime(DateTime.Now.Year, int.Parse(recycleContainer.Last()), int.Parse(recycleContainer.First()));
            //var recycleContainer = doc.DocumentNode.SelectSingleNode("//*[@id="f3f8b497 - e7a4 - e611 - 80d7 - 0050569304b7"]/div/div/div/table/tbody/tr/td[4]");

            //Set my helper to show when the trash will be empited next!
            _services.InputDatetime.SetDatetime(ServiceTarget.FromEntity(_entities.InputDatetime.Skraldespand.EntityId), $"{dt.Date.Year}-{dt.Date.Month}-{dt.Date.Day}");
            _services.InputDatetime.SetDatetime(ServiceTarget.FromEntity(_entities.InputDatetime.Recycletrash.EntityId), $"{ recycleDT.Date.Year}-{recycleDT.Date.Month}-{recycleDT.Date.Day}");
            if (DateTime.Now.Date.Equals(dt.Date.AddDays(-1)))
            {
                _logger.LogInformation("Affald tømmes i morgen");
                _services.InputBoolean.TurnOn(ServiceTarget.FromEntity(_entities.InputBoolean.Trashcanemptytomorrow.EntityId));
            }
        }
    }
}
