using GameDemo.Abstract;
using GameDemo.Entites;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapter
{
    internal class GamerCheckManager : IGamerCheckService
    {
        public bool ChechIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = kPSPublicSoapClient.TCKimlikNoDogrulaAsync(
                Convert.ToInt64(gamer.NationalityNo),
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),
                gamer.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}