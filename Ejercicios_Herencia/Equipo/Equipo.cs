using System;
using System.Collections.Generic;

namespace ConsoleQ
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string _nombre;


        private Equipo()
        {
            jugadores = new List<Jugador>(_cantidadDeJugadores);
        }

        public Equipo(short cantidadDeJugadores,string nombre) : this()
        {
            _cantidadDeJugadores = cantidadDeJugadores;
            _nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool answer = false;
            if(e != null && j != null && e.jugadores.Count < e._cantidadDeJugadores)
            {
                if(!(e.jugadores.Contains(j)))
                {
                    e.jugadores.Add(j);
                    answer = true;
                }
            }
            return answer;
        }

    }
}
