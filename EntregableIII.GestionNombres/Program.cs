using System;
using System.Collections.Generic;

namespace EntregableIII.GestionNombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> teamMembers = new List<string>();
            bool seguirEjecutando = true;

            while (seguirEjecutando)
            {
                MostrarMenu();

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine() ?? "";

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        AgregarNombre(teamMembers);
                        break;

                    case "2":
                        EliminarNombre(teamMembers);
                        break;

                    case "3":
                        BuscarNombre(teamMembers);
                        break;

                    case "4":
                        MostrarNombresOrdenados(teamMembers);
                        break;

                    case "0":
                        seguirEjecutando = false;
                        Console.WriteLine("Cerrando... Gracias :)");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. :/");
                        break;
                }

                if (seguirEjecutando)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       GESTIÓN DE TEAM MEMBERS          ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Agregar nombre");
            Console.WriteLine("2. Eliminar nombre");
            Console.WriteLine("3. Buscar nombre");
            Console.WriteLine("4. Mostrar nombres ordenados alfabéticamnte");
            Console.WriteLine("0. Salir");
            Console.WriteLine("========================================");
        }

        static void AgregarNombre(List<string> teamMembers)
        {
            Console.Write("Ingrese el nombre del Team Member: ");
            string nombre = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío. :(");
                return;
            }

            teamMembers.Add(nombre.Trim());

            Console.WriteLine("El nombre fue agregado correctamente. :)");
        }

        static void EliminarNombre(List<string> teamMembers)
        {
            if (teamMembers.Count == 0)
            {
                Console.WriteLine("No hay Team Members registrados. :/");
                return;
            }

            Console.Write("Ingrese el nombre que desea eliminar: ");
            string nombre = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío. :(");
                return;
            }

            bool eliminado = teamMembers.Remove(nombre.Trim());

            if (eliminado)
            {
                Console.WriteLine("El nombre fue eliminado correctamente. :)");
            }
            else
            {
                Console.WriteLine("El nombre no se encuentra en la lista. :/");
            }
        }

        static void BuscarNombre(List<string> teamMembers)
        {
            if (teamMembers.Count == 0)
            {
                Console.WriteLine("No hay Team Members registrados. :/");
                return;
            }

            Console.Write("Ingrese el nombre que desea buscar: ");
            string nombre = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío. :(");
                return;
            }

            bool encontrado = teamMembers.Contains(nombre.Trim());

            if (encontrado)
            {
                Console.WriteLine("El nombre fue encontrado en la lista. :)");
            }
            else
            {
                Console.WriteLine("El nombre no se encuentra en la lista. :/");
            }
        }

        static void MostrarNombresOrdenados(List<string> teamMembers)
        {
            if (teamMembers.Count == 0)
            {
                Console.WriteLine("No hay Team Members registrados. :/");
                return;
            }

            List<string> nombresOrdenados = new List<string>(teamMembers);

            nombresOrdenados.Sort();

            Console.WriteLine("======TEAM MEMBERS ORDENADOS======");

            foreach (string nombre in nombresOrdenados)
            {
                Console.WriteLine($"- {nombre}");
            }
        }
    }
}