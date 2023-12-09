using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PeliculaBE
    {
        public int peliculaID { get; set; }
        public string titulo { get; set; }
        public string director { get; set; }
        public int durMInutos { get; set; }
        public string clasificacion { get; set; }

        public PeliculaBE() { }

        public PeliculaBE(int peliculaID, string titulo, string director, int durMInutos, string clasificacion)
        {
            this.peliculaID = peliculaID;
            this.titulo = titulo;
            this.director = director;
            this.durMInutos = durMInutos;
            this.clasificacion = clasificacion;
        }

        public PeliculaBE(string titulo, string director, int durMInutos, string clasificacion)
        {
            this.titulo = titulo;
            this.director = director;
            this.durMInutos = durMInutos;
            this.clasificacion = clasificacion;
        }

    }
}
