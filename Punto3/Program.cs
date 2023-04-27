using System;
using System.Collections.Generic;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja;
            List<Caja> cajas = new List<Caja>();
            Ferrocarril ferrocarril = new Ferrocarril();
            Vagon vagon = new Vagon { LongitudMts = 15.4M, LongitudConAcoplesMts = 17.1M, AlturaMts = 3, CapacidadM3 = 141, PesoNetoTon = 29 };

            ferrocarril.Vagones.Add(vagon);
            ferrocarril.Vagones.Add(vagon);
            ferrocarril.Vagones.Add(vagon);

            Console.Write("Punto Nro 3:");
            Console.WriteLine("Ingrese las dimensiones de la caja");
            Console.Out.NewLine = "\r\n\r\n";
            do
            {
                caja = new Caja();
                Console.Write("Largo (m):");
                caja.Largo = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Ancho (m):");
                caja.Ancho = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Profunidad (m):");
                caja.Profundidad = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();

                cajas.Add(caja);

                ferrocarril.AsignarCaja(caja);

            } while (!caja.EstaVacia());


            if (ferrocarril.VagonesLlenos)
                Console.Write("A: No es Factible la carga de cajas");
            else
                Console.WriteLine("A: Es Factible la carga de cajas");

            Console.WriteLine("B: La cantidad estimada de cajas por vagon es: " + ferrocarril.CantidadDeCajasPorVagon().ToString());

        }

    }
}
