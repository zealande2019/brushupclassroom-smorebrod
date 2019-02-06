using System.Runtime.InteropServices;

namespace ClassRoom
{
    public class Studerende
    {

        public string Navn { get; set; }

        public int fødselmåned { get; set; }

        public  int fødselsdag { get; set; }

        public Studerende(string navn, int fødselmåned, int fødselsdag)
        {
            Navn = navn;
            this.fødselmåned = fødselmåned;
            this.fødselsdag = fødselsdag;
        }

        public string Årstiderne()
        {
            if (fødselmåned == 12 || fødselmåned == 1 || fødselmåned == 2)
            {
                return "Vinter";
            }

            if (fødselmåned == 3 || fødselmåned == 4 || fødselmåned == 5)
            {
                return "forår";
            }

            if (fødselmåned == 6 || fødselmåned == 7 || fødselmåned == 8)
            {
                return "sommer";
            }

            if (fødselmåned == 9 ||fødselmåned == 10||fødselmåned == 11 )
            {
                return "Efterår";
            }

            return null;
        }



    }

}