using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    internal class Camion : Vehiculo
    {
        public double CapacidadDeCarga { get; set; }

        public Camion(string marca, string modelo, int anio, double kilometraje, double capacidadDeCarga) : base(marca, modelo, anio, kilometraje)
        {
            CapacidadDeCarga = capacidadDeCarga;
        }

        public override void Encender()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} está encendido y lleva una carga de {CapacidadDeCarga} toneladas");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} está apagado.");
        }
        public override void Conducir(double km)
        {
            kilometraje += km;
            Console.WriteLine($"El camnión {Marca} {Modelo} con un peso de carga de {CapacidadDeCarga} toneladas, ha conducido {km} Km. Kilometraje total: {kilometraje} km. ");
        }
    }
}
