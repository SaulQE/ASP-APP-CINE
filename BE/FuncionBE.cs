using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FuncionBE
    {
        public int funcionID { get; set; }
        public int peliculaID { get; set; }
        public int salaID { get; set; }
        public DateTime fechaHora { get; set; }

        public FuncionBE() {}

        public FuncionBE(int funcionID, int peliculaID, int salaID, DateTime fechaHora)
        {
            this.funcionID = funcionID;
            this.peliculaID = peliculaID;
            this.salaID = salaID;
            this.fechaHora = fechaHora;
        }

        public FuncionBE(int peliculaID, int salaID, DateTime fechaHora)
        {
            this.peliculaID = peliculaID;
            this.salaID = salaID;
            this.fechaHora = fechaHora;
        }

    }
}
