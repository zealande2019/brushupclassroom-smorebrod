using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasserum = new KlasseRum();

            klasserum.KlasseNavn = "3B";

            klasserum.Semesterstart = new DateTime(2018,4,9);

            Studerende studerende1 = new Studerende("Alexander", 03, 12);

            klasserum.klasseliste.Add(studerende1);

            foreach (var studerende in klasserum.klasseliste)
            {
                Console.WriteLine(studerende.Navn);
            }

            
        
         
                
            

            Console.ReadLine();
        }
    }
}
