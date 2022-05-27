using System;
//^MATRICES (ARRAYS, ARREGLOS) 
namespace  ArraysOne
{

class Progam
{
  static void Main(string[] args)
  {
    float[] datos_float; //inicialización

    datos_float = new float[10]; //declaración, se almacenan 10 valores int

    //!Si no especificas, coge el valor por defecto, en int cogen 0, en objects null, en strings null
    Console.WriteLine(datos_float[2]); //que muestre lo que haya almacenado en la posición 2

    int [] edad_aldea = new int[20]; //declaración e inicialización

    int[] valores_fijos = {15, 25, 35 , 45, 55, 65}; //valores fijos

//---------------------------------------------------------------------------

    int[] edades; //an empty array

    edades = new int[4]; //an array with 4 elements
    
    edades[0] = 15; //index 0
    edades[1] = 25; //index 1
    edades[2] = 45; //index 2
    edades[3] = 55; //index 3
    try //error por indice inexistente
    {
      edades[4] = 80; 
    }
    catch (IndexOutOfRangeException ex)
    {
      Console.WriteLine($"error por llamar una posición index que no existe. error: {ex}");
      
    }
    Console.WriteLine(edades[2]);
    
    //sintaxis simplificada al conocer la cantidad a almacenar
    int[] mas_edades = {71, 13, 34, 61}; //VALORES FIJOS IMPLICIT
    int[] edades_explicitas = new int[4] {513,123,54,12}; //estricta

    String[] strings = {"p","e"};
    
//---------------------------------------------------------------------------


  }

}

}