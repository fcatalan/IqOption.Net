using System;
using System.Threading.Tasks;
using IqOptionApi.Models;
using IqOptionApi.Models.DigitalOptions;

namespace IqOptionApi.Samples.SampleRunners
{
    public class PlaceDigitalOptionSample : SampleRunner
    {
        public override async Task RunSample()
        {
            if (await IqClientApi.ConnectAsync())
            {
                var position = await IqClientApi.WsClient.PlaceDigitalOptions(ActivePair.EURUSD_OTC, OrderDirection.Call, DigitalExpiryDuration.M1, 1);

                Console.WriteLine(position.Id);
            }
        }
    }
}