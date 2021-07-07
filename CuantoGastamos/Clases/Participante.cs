using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuantoGastamos.Clases
{
    public class Participante
    {
        public Participante(string nombre, double monto)
        {
            Nombre = nombre;
            Monto = monto;
        }

        public Participante()
        {

        }

        [Required(ErrorMessage = "Se debe ingresar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se debe ingresar un monto")]
        public double Monto { get; set; }

    }
}
