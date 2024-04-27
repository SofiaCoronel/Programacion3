namespace FormateoFecha
{
    public class FechaFormateada
    {
        public static string FormatearFecha(DateTime fecha)
        {
            string diaSemana = fecha.ToString("dddd"); // Obtiene el nombre del día de la semana
            string dia = fecha.Day.ToString();
            string mes = fecha.ToString("MMMM");
            string año = fecha.Year.ToString();

            return $"Mi cumple es el {diaSemana} {dia} de {mes} de {año}";
        }

    }
}
