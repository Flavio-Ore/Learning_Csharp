using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractICs
{
    public interface IMamiferosTerrestres
    {
        int CantidadPatas();
        int PatasSaltar();
    }
    public interface ISonidoMamifero
    {
        string SonidoMamifero();
    }
}