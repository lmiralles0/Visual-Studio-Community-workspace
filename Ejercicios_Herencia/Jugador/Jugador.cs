using System;
using System.Data.Common;
using System.Text;

namespace ConsoleQ
{
    public class Jugador
    {
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        private int _totalGoles;


        private Jugador()
        {
            _partidosJugados = 0;
            _totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            _dni = dni;
            _nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            _totalGoles = totalGoles;
            _partidosJugados = totalPartidos;
        }


        public float PromedioDeGoles 
        { 
            get 
            {
                return  (_partidosJugados / _totalGoles);  
            } 
        }

        public int PartidosJugados { get { return this._partidosJugados; } }

        public int TotalGoles { get { return this._totalGoles; } }

        public string Nombre { get => this._nombre; set => this._nombre = value;}

        public int Dni { get => this._dni; set => this._dni = value;}

        public string MostarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Jugador");
            sb.AppendLine($"Nombre: {this._nombre}");
            sb.AppendLine($"DNI: {this._dni}");
            sb.AppendLine($"Partidos: {this._partidosJugados}");
            sb.AppendLine($"Goles: {this._totalGoles}");
            sb.AppendLine($"Promedio: {this.PromedioDeGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1._dni == j2._dni);
        }



        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
