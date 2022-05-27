using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protected_accesVCs
{
    public class Avion : Vehiculo
    {
        //fields
        private string gradoPiloto = "SIN RANGO, NO PUEDE CONDUCIR";

        //constructor
        public Avion(string modelo, int meses) : base(modelo, meses)
        {}
        
        //methods
        public override void Conducir(int edad)
        {
            if ((edad > 0) && (edad < 99))
            {
                if (edad >= 22)
                    Console.WriteLine("Me he graduado, tengo licencia y soy capaz de conducir un avión");

                else if (edad < 18)        
                    Console.WriteLine("Soy menor de edad, no puedo conducir un avión");

                else 
                    Console.WriteLine("Soy capaz de aprender a conducir un avión");
            }
            else Console.WriteLine("Error, edad menor a cero");
        }
        
        //getters setters
        public string GradoPiloto
        {
            get => gradoPiloto;
            set 
            {
                switch (value)
                {
                case "Alumno Piloto":
                    gradoPiloto = $"Grado: {value}. Es alumno piloto al entrar en Aviaco.";
                    break;

                case "Piloto Instrumental":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 30 horas";
                    break;

                case "Segundo Oficial":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 50 horas.";
                    break;

                case "Primer oficial":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 80 horas";
                    break;

                case "Tercer Capitán":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 100 horas";
                    break;

                case "Capitán":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 200 horas";
                    break;

                case "Tercer Comandante":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 300 horas";
                    break;

                case "Segundo Comandante":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 400 horas";
                    break;

                case "Comandante":
                    gradoPiloto = $"Grado: {value}. Se alcanza esta titulación al volar 500 horas";
                    break;

                default:
                    gradoPiloto = "SIN RANGO, NO PUEDE CONDUCIR EL AVIÓN";
                    break;         
                }
            }
        }
        public override string InfoVehiculo 
        {get => $"Meses que tiene: {meses} | Modelo: {modelo} | {gradoPiloto}";}
        
    }
    
}