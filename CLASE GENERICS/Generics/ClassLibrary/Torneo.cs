using System.Text;

namespace ClassLibrary
{
    public class Torneo <T> where T : Equipo 
    {
        private List<T> equipos;
        private string _nombre;

        public Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre): this()
        {
            this._nombre = nombre;
        }


        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos) 
            {
                if(item == equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if((torneo is not null && equipo is not null) && (torneo != equipo))
            {
                torneo.equipos.Add(equipo);
                return true;   
            }
            return false;
        }


        public string Mostrar(Torneo<T> torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo {_nombre}");
            
            foreach(T item in torneo.equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }


        private string CalcularPartido(T e1, T e2)
        {
            Random rm = new Random();
            StringBuilder sb = new StringBuilder();
            return sb.AppendLine($"[{e1.Nombre}][{rm.Next(0, 7)}] – [{rm.Next(0, 7)}][{e2.Nombre}] ").ToString();

        }

        public string JugarPartido
        {
            get 
            {
                Random rm = new Random();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[rm.Next(0, equipos.Count)];
                    equipo2 = equipos[rm.Next(0, equipos.Count)];


                } while (equipo1 == equipo2);



                return CalcularPartido(equipo1, equipo2);
            }
        }
 

    }
}
