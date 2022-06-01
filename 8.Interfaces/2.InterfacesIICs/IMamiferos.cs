using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacesIICs
{
    //^INTERFACE: restricciones
    //No se permite definir campos (variables) en interfaces.
    //No se pueden definir constructores.
    //No se pueden definir destructores.
    //No se pueden especificar modificadores de acceso en métodos (todos son    public de forma implícita).
    //No se pueden anidar clases ni otro tipo de estructuras en las interfaces
    public interface IPatasMamiferos
    {
        //Estos métodos no se desarrollan, no hay código dentro del método de la interfaz. Estos métodos no llevan modificador de acceso.
        int NumeroPatas();
    }
    public interface IAnimalesDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();
    }
    public interface ISaltoCantidadPatas
    {
        int NumeroPatas(); //!mismo nombre de método que la otra interface
    }
}