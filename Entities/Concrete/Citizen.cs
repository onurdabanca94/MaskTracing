using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Citizen
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public long NationalNumber { get; set; }
    public int BirthYear { get; set; }

    //public string ParentName { get; set; } --> test property
}
