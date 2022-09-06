using System;


namespace Objects
{
    public class Cuentas
    {
        private string titular;
        private decimal cantidad;



        public Cuentas()
        {
            titular = "";
            cantidad = 0;
        }

        public Cuentas(string titular, decimal cantidad): this()
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular(Cuentas cuenta)
        { return this.titular; }


        public decimal GetCantidad(Cuentas cuenta)
        { return this.cantidad; }


        public string Mostrar(Cuentas cuenta)
        {
            return $"Titular: {GetTitular(cuenta)}, Saldo: ${GetCantidad(cuenta)}";
        }

        public void Ingresar(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad -= cantidad; 
            }
        }
           


        #region Validador

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

        #endregion


    }
}
