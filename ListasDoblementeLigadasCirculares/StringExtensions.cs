namespace ListasDoblementeLigadasCirculares
{
    internal static class StringExtensions
    {
        public static bool EsNuloOEstaEnBlanco(this string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
