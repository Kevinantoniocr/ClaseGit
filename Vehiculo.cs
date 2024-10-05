using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoApp
{
    // Clase Vehiculo con propiedades Modelo y Precio
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public decimal Precio { get; set; }

        // Clase interna Descuento
        public class Descuento
        {
            // Método estático para aplicar descuento
            public static decimal AplicarDescuento(Vehiculo vehiculo, decimal porcentajeDescuento)
            {
                return vehiculo.Precio - (vehiculo.Precio * porcentajeDescuento / 100);
            }
        }
    }
}
