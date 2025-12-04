// Creando una lista de postres navideños

namespace ListasDoblementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listas listas = new Listas();

            listas.Agregar("Buñuelos");
            listas.Agregar("Galletas");
            listas.Agregar("Rollo de calabaza");
            listas.Agregar("Carlota de limon");

            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Postres Navideños");
                Console.WriteLine("Elige una opción: ");
                Console.WriteLine("1. Agregar postre");
                Console.WriteLine("2. Mostrar lista de postres actuales: ");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Eliminar postre");
                Console.WriteLine("5. Salir");
                Console.WriteLine("6. Opcion extra: Mostrar en reversa");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del postre: ");
                        string postre = Console.ReadLine();
                        listas.Agregar(postre);
                        Console.WriteLine($"'{postre}' agregado con exito. Presiona cualquier tecla para continuar...");
                        break;
                    case 2:
                        Console.WriteLine("Lista de postres actuales:");
                        Console.WriteLine(listas.ObtenerDatos());
                        break;

                    case 3:
                        Console.Write("Nombre del postre a buscar: ");
                        string postreBuscar = Console.ReadLine();
                        var encontrado = listas.Buscar(postreBuscar);

                        if (encontrado != null)
                            Console.WriteLine($"Postre '{postreBuscar}' encontrado en la lista.");
                        else
                            Console.WriteLine($"Postre '{postreBuscar}' no encontrado en la lista.");

                        break;
                    case 4:
                        Console.Write("Ingrese el nombre del postre a eliminar: ");
                        string postreEliminar = Console.ReadLine();
                        bool resultado = listas.Eliminar(postreEliminar);

                        if (resultado)
                            Console.WriteLine($"Postre '{postreEliminar}' eliminado con éxito.");
                        else
                            Console.WriteLine($"Postre '{postreEliminar}' no encontrado en la lista.");

                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa. ¡Felices fiestas!");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Lista de postres en reversa:\n");
                        Console.WriteLine(listas.ObtenerValoresInversos());
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor intenta de nuevo.");
                        break;
                }
            } while (opcion != 5);
        }
    }
}
