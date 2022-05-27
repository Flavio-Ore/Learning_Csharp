using System.Reflection.Metadata.Ecma335;
using System;
namespace Protected_accesVCs
{
    class Program
  {
    static void Main(string[] args)
    {
    //!VEHÍCULO
    Console.WriteLine("Vehiculo----------------------------------------------");
      Vehiculo bicicleta = new Vehiculo("triciclo", 0);

      Console.WriteLine(bicicleta.InfoVehiculo);

      bicicleta.ArrancarMotor(true);

      bicicleta.PararMotor(false);

      bicicleta.Conducir(2);
      bicicleta.Conducir(6); 
      bicicleta.Conducir(18);

      Console.WriteLine(Vehiculo.VehiculosDisponibles);

    //!COCHE
    Console.WriteLine("Coche-------------------------------------------------");

      Coche porshe = new Coche("Porshe", 2, "ASD-159");
      //información por default básica del objeto porshe
      Console.WriteLine(porshe.InfoVehiculo);

      porshe.Conducir(11, true);

      Console.WriteLine(porshe.InfoVehiculo);

      porshe.Conducir(2);
      porshe.Conducir(6);      
      porshe.Conducir(18);                  

      Console.WriteLine(porshe.Tablet);

      porshe.Tablet = "true";

      Console.WriteLine(porshe.Tablet);

    //!AVIÓN  
    Console.WriteLine("Avión-------------------------------------------------");

      //instanciando
      Avion latam = new Avion("Steven", 10);

      //información por default básica del objeto latam
      Console.WriteLine(latam.InfoVehiculo);

      //default GradoPiloto en cualquier objeto Avion
      Console.WriteLine(latam.GradoPiloto);

      //set: switch (value) = string latam.GradoPiloto
      latam.GradoPiloto = "Piloto Instrumental";

      //get: el cambio al introducir "Piloto Instrumental"
      Console.WriteLine(latam.GradoPiloto);

      //el parámetro del método conducir = "Comandante". Ese valor es tomado por el setter GradoPiloto y lo reemplaza en sus respecticas instrucciones
      latam.Conducir(16);

      //Grado es modificado de valor por el setter
      Console.WriteLine(latam.InfoVehiculo);

      //Conducir
      latam.Conducir(23); //if >= 22
      latam.Conducir(19); //if < 18
      latam.Conducir(11); //else no
      latam.Conducir(-2265);

      latam.ArrancarMotor(true);
      latam.PararMotor(false);
    }
  }
}