using System;
using System.CodeDom;
using System.Collections.Generic;

namespace ClassRoom
{
    public class KlasseRum
    {
        public KlasseRum()
        {
        }

        public List<Studerende> klasseliste
        { get;  } = new List<Studerende>();


        public String  KlasseNavn { get; set; }

        public DateTime Semesterstart { get; set; }


    }
}