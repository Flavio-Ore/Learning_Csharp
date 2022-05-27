using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_set_this_partial
{
    public class Getter_Setter_2022
    {
    //campo de clase
    private int edad;
    private string nombre;
  
    //getter, setter
    public string Nombre
    {
      get => nombre;
      set
      {
        if (value == "")
        {
          nombre = "TBD";
        }
        else
        {
          value = nombre;
        }
      }
    }
    public int Edad
    {
      get => edad;
      set 
      {
        if (value < 18)
        {
          edad = 18;
        }
      }
    }
    }
}
//! To be used as
/*  
?   var samuel = new Empleado();

?   samuel.Nombre = "";
?   samuel.Edad = 12;
  
?   Console.WriteLine(samuel.Nombre);
?   Console.WriteLine(samuel.Edad);
*/
