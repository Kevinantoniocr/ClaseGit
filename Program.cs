using System;

namespace VehiculoApp
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la reserva de vehiculo, el vehiculo que reserve fue:"); 
            // Instanciar un vehículo
            Vehiculo vehiculo = new Vehiculo
            {
                Modelo = "Toyota Corolla",
                Precio = 20000m
            };

            // Mostrar la información del vehículo
            vehiculo.MostrarInfo();

            // Aplicar un descuento del 10%
            decimal descuento = 10;
            decimal precioConDescuento = Vehiculo.Descuento.AplicarDescuento(vehiculo, descuento);
            Console.WriteLine($"\nPrecio con {descuento}% de descuento: {precioConDescuento:C}");

            // Calcular el costo de la reserva por 7 días
            int diasReserva = 7;
            decimal costoTotal = CalcularReserva.CalcularTotalReserva(vehiculo, diasReserva, descuento);
            Console.WriteLine($"\nCosto total de la reserva por {diasReserva} días: {costoTotal:C}");
        }
    }
}