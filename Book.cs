using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI20241202;

internal class Book
{
    public long Isbn { get; set; }
    public string Szerzo { get; set; }
    public string Cim { get; set; }
    public int Kiadasiev { get; set; }
    public string Nyelv { get; set; }
    public int Keszlet { get; set; }
    public int Ar { get; set; }

    public override string ToString() =>
        $"({Isbn}) {Szerzo} {Cim} {Kiadasiev} {Nyelv} {Keszlet} {Ar}";

    public Book(long isbn, string szerzo, string cim, int kiadasiev, string nyelv, int keszlet, int ar)
    {
        Isbn = isbn;
        Szerzo = szerzo;
        if (cim.Length > 2 && cim.Length < 65)
        {
            Cim = cim;
        }
        else
        {
            throw new Exception("minimum 3, maximum 64 karakter hosszú");
        }
        if (kiadasiev > 2006 && kiadasiev < 2025)
        {
            Kiadasiev = kiadasiev;
        }
        else
        {
            throw new Exception("Csak 2007 és 2024 közötti egész számot lehet írni");
        }
        if (nyelv.ToUpper() == "MAGYAR" || nyelv.ToUpper() == "ANGOL" ||
            nyelv.ToUpper() == "NÉMET")
        {
            Nyelv = nyelv;
        }
        else
        {
            throw new Exception("Csak magya, angol vagy német lehet");
        }
        if(keszlet >= 0)
        {
            Keszlet = keszlet;
        }
        else
        {
            throw new Exception("Minimum 0");
        }
        if(ar >=1000 && ar<=10000 && ar%100 == 0)
        {
            Ar = ar;
        }
        else
        {
            throw new Exception("1000 és 10000 közötti, kerek kettő nulára végződő szám");
        }
    }
    
    public Book(string cim, string szerzo)
    {
        Random rnd = new Random();
        if(cim.Length > 2 && cim.Length < 65)
        {
            Cim = cim;
        }
        else
        {
            throw new Exception("minimum 3, maximum 64 karakter hosszú");
        }
        Szerzo = szerzo;
        Keszlet = 0;
        Nyelv = "magyar";
        Ar = 4500;
        Kiadasiev = 2024;
        Isbn = 0;
    }
}
