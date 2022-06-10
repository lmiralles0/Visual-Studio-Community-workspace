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
            SetTitular(titular);
            SetCantidad(cantidad);
        }

        private void SetTitular(string titular)
        {
            if (!(string.IsNullOrEmpty(titular)) && EsString(titular))
                this.titular = titular;
        }

        public string GetTitular(Cuentas cuenta)
        { return titular; }


        private void SetCantidad(decimal cantidad)
        {
            if (cantidad > 0)
                this.cantidad = cantidad;
        }

        public decimal GetCantidad(Cuentas cuenta)
        { return cantidad; }


        public string Mostrar(Cuentas cuenta)
        {
            return $"Titular: {GetTitular(cuenta)}, Saldo: ${GetCantidad(cuenta).ToString()}";
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
