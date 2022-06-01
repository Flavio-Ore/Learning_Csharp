using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgInterfacesIIICs
{
    public interface IUserLocation
    {
        string Location(string region, string city, string country);
    }
}