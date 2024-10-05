using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoApp
{
    // Clase estática para calcular el costo total de una reserva
    public static class CalcularReserva
    {
        public static decimal CalcularTotalReserva(Vehiculo vehiculo, int dias, decimal descuento)
        {
            decimal precioConDescuento = Vehiculo.Descuento.AplicarDescuento(vehiculo, descuento);
            return precioConDescuento * dias;
        }
    }

    // Método de extensión para formatear y mostrar la información del vehículo
    public static class VehiculoExtensions
    {
        public static void MostrarInfo(this Vehiculo vehiculo)
        {
            Console.WriteLine($"Modelo: {vehiculo.Modelo}");
            Console.WriteLine($"Precio: {vehiculo.Precio:C}");
        }
    }
}
