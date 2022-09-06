using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return ((this.notaPrimerParcial + this.notaSegundoParcial) / 2);
        }

        public double CalcularNotaFinal()
        {
            double aux;
            float aux1 = CalcularPromedio();
            if (aux1 >= 4)
            {
                aux = random.Next(6,11);
            }
            else
            {
                aux = random.Next(-1, 10);
            }

            return aux;
        }


        public string Mostrar()
        {
            StringBuilder a = new StringBuilder();

            a.AppendFormat("{0} {1} {2}\n", this.nombre, this.apellido, this.legajo);
            a.AppendFormat("PP: {0} SP: {1} \n", this.notaPrimerParcial, this.notaSegundoParcial);
            a.AppendFormat("PROMEDIO: {0}\n", this.CalcularPromedio());
            a.AppendFormat("Nota FINAL: {0}", this.CalcularNotaFinal());

            return a.ToString();
        }


    }
}
