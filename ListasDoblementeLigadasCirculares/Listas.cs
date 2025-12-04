namespace ListasDoblementeLigadasCirculares
{
    internal class Listas
    {
        private Nodo _nodoInicial;

        public Listas()
        {
            _nodoInicial = new Nodo();

            _nodoInicial.Siguiente = _nodoInicial;
            _nodoInicial.Anterior = _nodoInicial;
        }

        public void Agregar(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            Nodo? ultimo = _nodoInicial.Anterior;

            if (ultimo != null)
            {
                nuevoNodo.Siguiente = _nodoInicial;
                nuevoNodo.Anterior = ultimo;

                ultimo.Siguiente = nuevoNodo;
                _nodoInicial.Anterior = nuevoNodo;
            }
        }
        public string ObtenerDatos()
        {
            string datos = "";
            Nodo? actual = _nodoInicial.Siguiente;
            while (actual != null && actual != _nodoInicial)
            {
                datos += actual.Valor + Environment.NewLine;
                actual = actual.Siguiente;
            }
            return datos;
        }

        public Nodo? Buscar(string valor)
        {
            Nodo? actual = _nodoInicial.Siguiente;
            while (actual != null && actual != _nodoInicial)
            {
                if (actual.Valor == valor)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        private Nodo? BuscarAnterior(string valor)
        {
            Nodo actual = _nodoInicial;
            while (actual.Siguiente != _nodoInicial)
            {
                if (actual.Siguiente!.Valor == valor)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public bool Eliminar(string valor)
        {
            Nodo? nodoAnterior = BuscarAnterior(valor);
            if (nodoAnterior != null)
            {
                Nodo nodoEliminar = nodoAnterior.Siguiente!;
                nodoAnterior.Siguiente = nodoEliminar.Siguiente;
                nodoEliminar.Siguiente!.Anterior = nodoAnterior;
                return true;
            }
            return false;
        }

        public string ObtenerValoresInversos()
        {
            string datos = string.Empty;
            Nodo? actual = _nodoInicial.Anterior;
            while (actual != null && actual != _nodoInicial)
            {
                datos += actual.Valor + Environment.NewLine;
                actual = actual.Anterior;
            }
            return datos;
        }
    }
}
