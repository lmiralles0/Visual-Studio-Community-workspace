using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Equipo 
    {
        private string _nombre;
        private DateTime _fechaDeCreacion;

        public Equipo(string nombre, DateTime fecha) 
        {
            this._nombre = nombre;
            this._fechaDeCreacion = fecha;
        }

        public static bool operator ==(Equipo e1, Equipo e2) 
        {
            return e1._nombre == e2._nombre && e1._fechaDeCreacion == e2._fechaDeCreacion;
        }
        public static bool operator !=(Equipo e1, Equipo e2) 
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            return $"{_nombre} fundado el {_fechaDeCreacion.ToString("d")}";
        }

        public string Nombre { get => _nombre; }


    }
}
