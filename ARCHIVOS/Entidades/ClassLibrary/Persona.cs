namespace ClassLibrary
{
    public class Persona
    {
        private string nombre;

        public Persona()
        {
            nombre = string.Empty;
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }



        public string Name { get => this.nombre; set => this.nombre = value; }
    }

}
