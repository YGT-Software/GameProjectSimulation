using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.GamerName, gamer.GamerLastName, gamer.DateOfBirth.Year);

            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
