using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_E1_Ariketa_8_Download_Simulator
{
    /**
     * Fitxategia klasea: izena eta tamainak gordeko ditu.
     */
    internal class Fitxategia
    {
        // Propietateak.
        public string Izena { get; set; }
        public int Tamaina { get; set; }

        // Konstruktorea.
        public Fitxategia(string izena, int tamaina)
        {
            this.Izena = izena;
            this.Tamaina = tamaina;
        }
    }
}
