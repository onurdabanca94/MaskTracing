using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete;

public class CitizenService : IApplicantService
{
    //Encapsulation - Değişkenlerin Ciziten nesnesinin içerisinde kullanıldığı için
    public void ApplyForMask(Citizen citizen)
    {

    }

    public List<Citizen> GetList()
    {
        return null;
    }

    public bool CheckCitizen(Citizen citizen)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(
                    citizen.NationalNumber,citizen.Firstname,citizen.Lastname,citizen.BirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }




    //public void OtherMethod()
    //{
    //    ApplyForMask(new());

    //}
}
