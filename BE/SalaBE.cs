using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SalaBE
    {

        public int salaID { get; set; }
        public string nomSala { get; set; }
        public int capacidad { get; set; }

        public SalaBE() { }

        public SalaBE(int salaID, string nomSala, int capacidad)
        {
            this.salaID = salaID;
            this.nomSala = nomSala;
            this.capacidad = capacidad;
        }

        public SalaBE(string nomSala, int capacidad)
        {
            this.nomSala = nomSala;
            this.capacidad = capacidad;
        }

    }
}
