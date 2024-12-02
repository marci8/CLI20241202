using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI20241202;

internal class Author
{
    public string Nev { get; set; }
    public Guid Guid { get; set; }

    public override string ToString() =>
        $"{Nev}\nEgyéni azonosító: ({Guid})";
    /// <summary>
    /// Egy szerző vezetéknevét és keresztnevét bekérő konstruktor
    /// </summary>
    /// <param name="veznev">A szerző vezetékneve</param>
    /// <param name="kernev">A szerző keresztneve</param>
    public Author(string veznev, string kernev)
    {
        if(veznev.Length > 2 && veznev.Length < 33 && 
            kernev.Length > 2 && kernev.Length < 33)
        {
            Nev = veznev + " " + kernev;
        }
        else
        {
            throw new Exception("a név részei egyenként minimum 3, maximum 32 karakter hosszúak lehetenek");
        }
        Guid = Guid.NewGuid();
    }
}
