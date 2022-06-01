using System;

namespace Sealed_CLasses_Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      Adolescente ado = new Adolescente();
      Console.WriteLine(ado.NoSealedPensar);
      Console.WriteLine(ado.SealedPensar);
    }
  }
//--------------------------------------------------------------------------
  //^Sealed Methods
  //?'member' cannot be sealed because it is not an override. Sealed was used on a member that was not also marked with override. For more information, see Inheritance
  //EL MÉTODO EN CUESTION DEBE SER VIRTUAL
  class Mamifero 
  {
    public virtual string SealedPensar() => "Pensamiento mamifero SELLADO";
    public virtual string NoSealedPensar() => "Pensamiento mamifero NO SELLADO";
  }
  class Humano : Mamifero 
  {
    public sealed override string SealedPensar() => "Pienso y luego existo SELLADO";
    public override string NoSealedPensar() => "Pienso y luego existo NO SELLADO";
  }
  class Adolescente : Humano //Esta clase no puede utilizar ese método
  {
    //public override string SealedPensar() => "Pienso y luego existo INVÁLIDO";
    public override string NoSealedPensar() => "Mis hormonas no me dejan pensar bien";
  }
//--------------------------------------------------------------------------
  //^Sealed Class
  //sealing
  sealed class Sealed {}
  //!class CantLegacy : Sealed {}

  //inheriting
  class NoSealed {}
  class LegacySealed : NoSealed {}
//--------------------------------------------------------------------------  
}