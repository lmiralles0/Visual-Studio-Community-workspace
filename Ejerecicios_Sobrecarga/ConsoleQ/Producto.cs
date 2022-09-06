using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQ
{
    internal class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;


        public Producto(string marca, string codigo, float precio)
        {
            this._codigoDeBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        public string GetMarca
        { get { return _marca; } }

        public float GetPrecio
        { get { return _precio; } }


        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto marca {p.GetMarca}");
            sb.AppendLine($"Precio {p.GetPrecio}");
            sb.AppendLine($"Codigo Barra {(string)p}");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto p, Producto p2)
        {
            return !(p == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return (p.GetMarca == marca);
        }

        public static bool operator ==(Producto p, Producto p2)
        {               
            return ((p.GetMarca == p2.GetMarca) && (string)p == (string)p2);
        }
    }
}
