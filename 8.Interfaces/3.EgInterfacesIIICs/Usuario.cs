using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgInterfacesIIICs
{
    public class Usuario
    {
        //field
        protected string name;
        protected int id;

        //constructor
        public Usuario(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        //methods
        public virtual string UserInfo{get => $"Usuario: {this.name} | Id: {this.id}";}


        //getter setter
        public string Name {get=> this.name;}
        int Id() => this.id;
    }
    public class Moderador: 
        Usuario, IUserLocation
    {
        private string rolname;
        public Moderador(string nameMod, int idMod, string rolName):
            base(nameMod, idMod)
        {
            this.rolname = rolName;
        }
        
        //^Using IUserLocation
        //al usar la erramieta de implementación de interfaz, por defecto aparecen dentro del método de la interfaz: throw new NotImplementedException();
        public string Location(string region, string city, string location) => $"Region: {region} , City: {city} , Location: {location}";
        public override string UserInfo{get => $"Usuario: {this.name} | Id: {this.id} | rol: {this.rolname}";}
  }

    public class Baneado : Usuario
    {
        private int banTimeHours;
        public Baneado(string nameBan, int idBan, int banTimeHours):
            base(nameBan, idBan)
        {
            this.banTimeHours = banTimeHours;
        }

        public override string UserInfo{get => $"Usuario: {this.name} | Id: {this.id} | Tiempo ban: {this.banTimeHours} horas";}
    }
}