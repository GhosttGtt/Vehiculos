using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        private double Kilometraje; 
        
        public double kilometraje
        {
            get { return Kilometraje; }
            set {
                if (value >= 0)
                {
                    Kilometraje = value;
                }
                else
                {
                    throw new ArgumentException("El kilometraje no puede ser negativo.");
                }
            }
        }

        public Vehiculo(string marca, string modelo, int anio, double kilometraje)
        { 
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Kilometraje = kilometraje;
        }

        public abstract void Encender();
        public abstract void Apagar();
        public abstract void Conducir(double km);

     }
 }
