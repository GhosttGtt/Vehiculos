using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    internal class Auto : Vehiculo
    {
        public int NumeroDePuertas { get; set; }

        public Auto(string marca, string modelo, int anio, double kilometraje, int numeroDePuertas) : base(marca, modelo, anio, kilometraje)
        {
            NumeroDePuertas = numeroDePuertas;
        }

        public override void Encender()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} está encendido");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} está apagado.");
        }
        public override void Conducir(double km)
        {
            kilometraje += km;
            Console.WriteLine($"El auto {Marca} {Modelo} ha conducido {km} Km. Kilometraje total: {kilometraje} km. ");
        }
    }
}
