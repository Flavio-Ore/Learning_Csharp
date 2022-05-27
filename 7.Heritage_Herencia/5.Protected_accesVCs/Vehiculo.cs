using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protected_accesVCs
{
    public class Vehiculo
    {   
        //fields
        protected string modelo;
        protected int meses;

        //Constructor
        public Vehiculo (string modelo, int meses)
        {
            this.modelo = modelo;
            this.meses = meses;
        }

        //methods
        public static string VehiculosDisponibles
        {   
            get => "Coche (edad, licencia). Avión (edad, licencia, grado).";
        }

        public void ArrancarMotor(bool on)
        {
            if (on == true)
                Console.WriteLine("El motor está encendido");                
            else Console.WriteLine("El motor está apagado");
        }
        public void PararMotor(bool stop)
        {
            if (stop == true)
                Console.WriteLine("Se detuvo el motor");
            else Console.WriteLine("El motor continua");
        }
        public virtual void Conducir(int edad)
        {
            if (edad > 17)
                Console.WriteLine("Soy capaz de conducir");

            else if ((edad < 18) && (edad > 4))                
                Console.WriteLine("No puedo conducir vehículos que pidan licencia");

            else 
                Console.WriteLine("No puedo conducir");
        }

        //getters
        public virtual string InfoVehiculo 
        {get => $"Meses que tiene: {meses} | Modelo: {modelo}";}
        
    }

}