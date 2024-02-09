using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttService : ISupplierService
{
    private IApplicantService _applicantService;
    public PttService(IApplicantService applicantService) //Constructor main sınıf newlendiğinde çalışır.
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Citizen citizen)
    {
        if (_applicantService.CheckCitizen(citizen))
        {
            Console.WriteLine(citizen.Firstname + " maskenizi aldınız!");
        }
        else
        {
            Console.WriteLine(citizen.Firstname + " maske verilemedi!");
        }
    }
}
