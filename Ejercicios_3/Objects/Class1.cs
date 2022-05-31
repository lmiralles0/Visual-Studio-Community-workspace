using System;


namespace Objects
{
    public class Cuentas
    {
        public string titular;
        private float cantidad;



        public Cuentas(string titular, float cantidad)
        {
            this.SetTitular(titular);
            this.SetCantidad(cantidad);
        }

        private void SetTitular(string titular)
        {
            if (!(string.IsNullOrEmpty(titular)) || EsString(titular))
                this.titular = titular;
        }

        private void SetCantidad(float cantidad)
        {
            if (cantidad > 0)
                this.cantidad = cantidad;
        }

        private static bool EsString(string buffer)
        {
            bool respuesta = false;
            if(!(string.IsNullOrEmpty(buffer)))
            {
                respuesta = true;
                foreach(char c in buffer)
                {
                    if (c >= '0' && c <= '9')
                        respuesta = false;
                }
            }
            return respuesta;
        }

    }
}
