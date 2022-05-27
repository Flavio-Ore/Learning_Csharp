using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protected_accesVCs
{
    public class Coche : Vehiculo
    {
        //fields
        private bool tablet;
        private string placa;

        //constructor
        public Coche (string modelo, int meses, string placa) : base(modelo, meses)
        {
            this.placa = placa;
        }
        
        //methods
        public void Conducir(int edad, bool licencia)
        {
            if ((edad > 18) && (licencia == true))
                Console.WriteLine($"Tengo {edad}, puedo conducir. Licencia: {licencia}");
            else Console.WriteLine($"Tengo {edad}, NO puedo conducir. Licencia: {licencia}");
        }

        //getters setters
        public override string InfoVehiculo 
        {get => $"Meses que tiene: {meses} | Modelo: {modelo} | Placa: {placa}";}
        public string Tablet
        {
            get => $"Este coche tiene tablet: {tablet}";
            set
            {
                if (value == "true")
                    tablet = true;
                else 
                    tablet = false;                
            }
        }

    }
}