using System;
using System.Collections.Generic;


namespace EjercicioEntrega
{
    public class Program
    {
        //Propiedades
        public static object Add { get; set; }
        public string nombre { get; set; }
        public string nivel { get; set; }


        static void Main(string[] args)
        {
            //Aviso al usuario de que presione enter para iniciar juego
            Dibujo();

            //Declaración de la lista
            List<Personaje> lista = new List<Personaje>();

            //Personajes almacenados por defecto
            Personaje Vegetta = new Personaje("Vegetta", "Expert");
            Personaje SonGhoku = new Personaje("SonGhoku", "Super Saian");
            Personaje Krilin = new Personaje("Krilin", "Medium");

            //Personajes añadidos a la lista
            lista.Add(Vegetta);
            lista.Add(SonGhoku);
            lista.Add(Krilin);

            //opciones del menu
            int opcion = 0;

            //Menu del programa
            do
            {
                iniciarGame();
                mostrarMenu();

                //Leer el input del usuario
                Console.Write("Introduzca Opción:");
                opcion = Convert.ToInt32(Console.ReadLine());


                //Creo switch
                switch (opcion)
                {
                    case 1:
                        //1.-Añado nombre de nuevo personaje
                        string nombre;
                        Console.Write("ingresar nombre para nuevo personaje: ");
                        nombre = (Console.ReadLine());
                        Console.Write("su nombre es:");
                        Console.WriteLine(nombre);

                        //1.-Añado nivel de nuevo personaje
                        string nivel;
                        Console.Write("ingresar nivel para nuevo personaje: ");
                        nivel = (Console.ReadLine());
                        Console.Write("su nivel es: ");
                        Console.WriteLine(nivel);

                        //Creo el Personaje con estos datos
                        Console.Write("Presione la tecla ENTER para guardar");
                        Personaje NewPlayer = new Personaje(nombre, nivel);
                        Console.Write($"Personaje Añadido: { nombre }, nivel { nivel }");

                        //Añado el personaje a lista2 junto con los personajes ya existentes
                        lista.Add(NewPlayer);

                        //Guardo en un array de Personajes to2 los datos
                        Personaje[] Personaje = { NewPlayer };
                        Console.WriteLine(NewPlayer);

                        break;

                    case 2:
                        //2.-Busco un personaje de la lista
                        mostrarPersonajes(lista);
                        break;


                    case 3://3.-Elimino un personaje de la lista
                        eliminarPersonajes(lista);
                        break;

                    case 4:
                        //4.-Muestro todos los personajes del juego 
                        Console.WriteLine($"Top: {lista},{Vegetta},{SonGhoku},{Krilin} ");
                        break;



                    default:
                        break;

                }

            } while (opcion != 5);

        }


        public static void List(string v)
        {
            System.Console.WriteLine();
        }


        public static void Dibujo()
        {
            Console.WriteLine("------ooO - (_) - Ooo------");
            Console.WriteLine("Presione tres veces la tecla ENTER para iniciar el juego");
        }

        public static void iniciarGame()
        {

            Console.WriteLine("---- START GAME ----");


        }


        public static void mostrarMenu()
        {

            Console.WriteLine("1. Crear Personaje");
            Console.WriteLine("2. Buscar Personaje");
            Console.WriteLine("3. Borrar Personaje");
            Console.WriteLine("4. Ver Personajes");
            Console.WriteLine("5. Salir");

        }


        public static void mostrarPersonajes(List<Personaje> lista)
        {

            string nombre = "";
            Console.WriteLine("Busca tu personaje: ");
            nombre = Console.ReadLine();

            foreach (Personaje personaje in lista)
            {
                if (personaje.getNombre().Equals(nombre))
                {
                    Console.WriteLine(personaje.ToString());
                }
                else
                {
                    Console.WriteLine("Personaje no encontrado");
                }

            }
        }

        public static void eliminarPersonajes(List<Personaje> lista)
        {

            string nombre = "";
            Console.WriteLine("Busca tu personaje: ");
            nombre = Console.ReadLine();

            foreach (Personaje personaje in lista)
            {
                if (personaje.getNombre().Equals(nombre))
                {
                    System.IO.File.Delete(personaje.ToString());
                    Console.WriteLine("Personaje eliminado");
                }

            }
        }

        public class SavePersonaje
        {
            public SavePersonaje() { }
            public string Add { get; set; }
        }


    }


}
