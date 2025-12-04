namespace ListasDoblementeLigadasCirculares
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo? Siguiente { get; set; }
        public Nodo? Anterior { get; set; }
        public Nodo()
        {
            Valor = string.Empty;
            Siguiente = null;
            Anterior = null;
        }

        public Nodo(string valor)
        {
            Valor = valor;
            Siguiente = null;
            Anterior = null;
        }

    }
}
