<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleQ
{
    internal class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;


        private Estante(int capacidad)
        {
            this._productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos
        { get{ return this._productos; } }

        
        public static string MostarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicado en:  {e._ubicacionEstante}");
            for(int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] is not null)
                {
                    sb.AppendLine(Producto.MostrarProducto(e._productos[i]));
                }
            }
            return sb.ToString();
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {
            Estante aux = new Estante(e._productos.Length, e._ubicacionEstante);
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    continue;
                }
                aux._productos[i] = e._productos[i];
            }
            return aux;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool result = false;
<<<<<<< HEAD
            for (int i = 0; i < e._productos.Length; i++)
=======
            for(int i = 0; i <e._productos.Length;i++)
>>>>>>> a0b27b682e7dac9c48b4f1e2d3ce6c0dc2ff1471
            {
                if (e._productos[i] is not null)
                {
                    if (e._productos[i] == p)
                    {
                        result = false;
                        break;
                    }
                }
                else if (e._productos[i] is null)
                {
                    e._productos[i] = p;
                    result = true;
                    break;
                }

            }
            return result;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            for(int i = 0; i< e._productos.Length; i++)
            {
                if (e._productos[i] == p && e._productos[i] is null)
                    return true;
            }
            return false;
        }



    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleQ
{
    internal class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;


        private Estante(int capacidad)
        {
            this._productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos
        { get{ return this._productos; } }

        
        public static string MostarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicado en:  {e._ubicacionEstante}");
            for(int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] is not null)
                {
                    sb.AppendLine(Producto.MostrarProducto(e._productos[i]));
                }
            }
            return sb.ToString();
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {
            Estante aux = new Estante(e._productos.Length, e._ubicacionEstante);
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    continue;
                }
                aux._productos[i] = e._productos[i];
            }
            return aux;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool result = false;
<<<<<<< HEAD
            for (int i = 0; i < e._productos.Length; i++)
=======
            for(int i = 0; i <e._productos.Length;i++)
>>>>>>> a0b27b682e7dac9c48b4f1e2d3ce6c0dc2ff1471
            {
                if (e._productos[i] is not null)
                {
                    if (e._productos[i] == p)
                    {
                        result = false;
                        break;
                    }
                }
                else if (e._productos[i] is null)
                {
                    e._productos[i] = p;
                    result = true;
                    break;
                }

            }
            return result;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            for(int i = 0; i< e._productos.Length; i++)
            {
                if (e._productos[i] == p && e._productos[i] is null)
                    return true;
            }
            return false;
        }



    }
}
>>>>>>> 5b63a2e02c465abaafd091827697c2e99c3842c4
