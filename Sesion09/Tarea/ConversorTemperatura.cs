namespace Tarea
{
    public class ConversorTemperatura
    {
        public static double Convertir(double valor, string origen, string destino)
        {
            double celsius = origen switch
            {
                "°C" => valor,
                "°F" => (valor - 32) * 5 / 9,
                "K" => valor - 273.15,
                _ => throw new ArgumentException("Unidad de origen inválida.")
            };

            return destino switch
            {
                "°C" => celsius,
                "°F" => celsius * 9 / 5 + 32,
                "K" => celsius + 273.15,
                _ => throw new ArgumentException("Unidad de destino inválida.")
            };
        }
    }
}
