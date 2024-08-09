using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    internal class Motocicleta : Vehiculo
    {
        public string TipoDeMoto { get; set; }

        public Motocicleta(string marca, string modelo, int anio, double kilometraje, string tipoDeMoto) : base(marca, modelo, anio, kilometraje)
        {
            TipoDeMoto = tipoDeMoto;
        }

        public override void Encender()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} tipo {TipoDeMoto} está encendido");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El motocicleta {Marca} {Modelo} tipo {TipoDeMoto} está apagado.");
        }
        public override void Conducir(double km)
        {
            kilometraje += km;
            Console.WriteLine($"La motocicleta {Marca} {Modelo} tipo {TipoDeMoto} ha conducido {km} Km. Kilometraje total: {kilometraje} km. ");
        }
    }
}
