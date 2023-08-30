namespace Biblioteca
{
    public static class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
        
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float tempKelvin;
            tempKelvin = temperaturaCelsius + ceroAbsoluto;

            return tempKelvin;
        }
    }
}