using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgGenericsIIICs.models
{
    //la clase genérica es capaz de almacenar CUALQUIER tipo de objeto, para ello, colocaremos restricciones
    //esta clase solo será capaz de manejar objetos de diferente tipo, pero luego esos objetos están obligados a implementar la interfaz
    public class AlmacenEmpleados<T> where T: IToEmployees //objetos donde en la que están obligados a tener la interfaz IToEmployees
    {
        //fields
        private int _i = 0;
        private T[] _datosEmpleados;
        
        //constructor
        public AlmacenEmpleados(int z)
        {
            _datosEmpleados = new T[z];
        }

        //method
        public void AgregarEmpleadosSalario(T obj)
        {
            _datosEmpleados[_i] = obj;
            _i++;
        }
        public T GetEmployeeClassByIndex(int i) => _datosEmpleados[i];
        public void GetAllSalario()
        {
            for (int i = 0; i < _datosEmpleados.Length; i++)
                Console.WriteLine(_datosEmpleados[i].SalarioEmpleado);
        }
    }
}