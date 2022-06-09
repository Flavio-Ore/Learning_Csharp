using System;
namespace DelegatesICs
{ 
  class program
  {
    //^Los delegados son funciones que delegan tareas en otras funciones
    //^delegate var Name(args); -> var MethodName(args)
    //El jefe delega tareas y a los empleos
    //!Los delegados son apuntadores (* pointers)
    //Muy utilizados en C# para llamar eventos
    //Se reduce el código al manejar diferentes escenarios
    //Código se vuelve muy reutilizable
    //!Podrá llamar solo a métodos con misma estructura
    //Es capaz de hacer referencia a un método ubicado en otra carpeta, clase, etc

    static void Main(string[] args)
    {
      //^Usando el método deleate para apuntar a los métodos en Msg.cs

      //creating an delegate object pointing to the class WelcomeMsg
      VoidDelObj ELDelegado = new VoidDelObj(WelcomeMsg.Greeting);

      //using the delegate to call the method Greeting
      ELDelegado();

      //delegating to point other class Method
      ELDelegado = new VoidDelObj(ByeMsg.Farewell);
      ELDelegado();

      //----------------------------------------------------------------

      //creating a delegate with args from the program Msg.cs
      StrDel OtroDelegado = new StrDel(ByeMsg.Args);
      OtroDelegado("Mensaje desde Main (ByeMsg.Args)");

      OtroDelegado = new StrDel(WelcomeMsg.Args);
      OtroDelegado("Mensaje de Bienvenida");

    }

    //^Este delegado va a APUNTAR (no llamar), referenciar a los métodos de tipo void
    //Si los métodos en la clase WelcomeMsg tienen parámetros, entonces este delegate no seria válido para hacer referencia al método WelcomeMsg and FarewellMsg
    delegate void VoidDelObj();
    //Con parámetros
    delegate string StrDel(string msg);
  }
}