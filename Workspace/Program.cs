using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workspace;

public class Program
{
    public static void Main(string[] args)
    {
        SayHello("Onur");
        SayHello();

        int total = Sum(6, 60);

        //Arrays

        //string[] students (sol taraf) --> Stack'te tutulur, new string[3] --> Heap'te yer açar ve students için tanımlanan değişkenleri tutar.

        string[] students = new string[3];
        students[0] = "Ömür";
        students[1] = "Kömür";
        students[2] = "Zamir";


        //students = new string[4] yapınca stack üzerindeki dizi Heap'te ilk üç değişkeni almaz ve 4.değere ilkeri yazar diğerlerini garbage collector ile silinir.
        students = new string[4];
        students[3] = "İlker";

        for (int std = 0; std < students.Length; std++)
        {
            Console.WriteLine(students[std]);
        }

        //Reference Types
        string[] citiesFirst = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] citiesSecond = new[] { "Aydın", "Manisa", "Muğla" };

        citiesSecond = citiesFirst;
        citiesFirst[1] = "Adana";
        Console.WriteLine(citiesSecond[1]); //Adana


        //Value Types
        //int numFirst = 10;
        //int numSecond = 20;
        //numSecond = numFirst;
        //numFirst = 30; //Değer tiplerde ilk olarak ne atandıysa onu baz alır ve 30 değerini almaz.
        //Console.WriteLine(numSecond); //10


        //alttaki iki alana da bellekte ayrı ayrı yer açılmış oldu.
        Citizen citizenFirst = new();
        citizenFirst.Firstname = "ONUR";
        citizenFirst.Lastname = "DABANCA";
        citizenFirst.BirthYear = 1994;
        citizenFirst.NationalNumber = 12345678910;

        Citizen citizenSecond = new();
        citizenSecond.Firstname = "Delly";

        foreach (string city in citiesFirst)
        {
            Console.WriteLine(city);
        }


        //MyList şeklinde bir collection oluşturmak.(Eğer List<> collection olmasaydı senaryosu.)
        List<string> newCities = new List<string> { "Ankara 1","İstanbul 1","İzmir 1"};
        newCities.Add("Bursa 1");
        foreach (string cities in newCities)
        {
            Console.WriteLine(cities);
        }

        PttService pttService = new(new CitizenService());
        pttService.GiveMask(citizenFirst);
    }

    public static void SayHello(string name = "nameless")
    {
        Console.WriteLine("Selamlar " + name);
    }

    public static int Sum(int numFirst = 5, int numSecond = 10)
    {
        int total = numFirst + numSecond;
        Console.WriteLine("Toplam : " + total);
        return total;
    }
}