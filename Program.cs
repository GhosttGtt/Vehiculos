using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vehiculo
{
    internal class Program
    {
        static void Main()
        {
            Auto Changan = new Auto("Changan", "CS35 Plus", 2023, 12000, 4);
            Camion Hino = new Camion("Hino", "Strong", 2020, 135000, 200);
            Motocicleta Harley = new Motocicleta("Harley", "Air", 2021, 23500, "Cruiser");


            Changan.Encender();
            Changan.Conducir(40);
            Changan.Apagar();

            Hino.Encender();
            Hino.Conducir(20);
            Hino.Apagar();

            Harley.Encender();
            Harley.Conducir(80);
            Harley.Apagar();
        }
    }
}