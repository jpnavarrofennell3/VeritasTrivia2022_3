using LogicaJuego;

namespace TriviaVeritas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccionDelUsuario = 0;

            // Gameloop
            while(seleccionDelUsuario != 3)
            {
                // desplegar la portada del juego
                MostrarPortada();

                //Desplegamos la lista de opciones, cada opcion es numerada
                MostrarOpciones();

                // se procede a capturar la decisión del usuario
                // guardo el dato
                seleccionDelUsuario = CapturarNumero();

                // si la persona escribio 1
                if (seleccionDelUsuario == 1)
                {
                    Console.WriteLine("Ha escogido iniciar el juego");
                    Console.ReadLine();
                }
                // si la persona escribio 2
                else if (seleccionDelUsuario == 2)
                {
                    // desplegar los créditos del juego
                    MostrarCreditos();
                }
                // si la persona escribio 3
                else if (seleccionDelUsuario == 3)
                {
                    Console.WriteLine("Ha escogido salir");
                    Console.ReadLine();
                }
            }
        }
         
        /// <summary>
        /// Esta funcion muestra la portada de trivia
        /// </summary>
        static public void MostrarPortada()
        {
            Console.Clear();
            Console.WriteLine("__ __|   _)       _)       \r\n   |  __| |\\ \\   / |  _` | \r\n   | |    | \\ \\ /  | (   | \r\n  _|_|   _|  \\_/  _|\\__,_| \r\n                           \r\n\\ \\     /        _) |              \r\n \\ \\   / _ \\  __| | __|  _` |  __| \r\n  \\ \\ /  __/ |    | |   (   |\\__ \\ \r\n   \\_/ \\___|_|   _|\\__|\\__,_|____/ ");
        }

        /// <summary>
        /// Esta función mustra los créditos de la trivia
        /// </summary>

        static public void MostrarCreditos()
        {

            Console.WriteLine("Creado por Juan Navarro.");
            Console.WriteLine("Estudiante: André Rodríguez Artavia ");
            Console.WriteLine("Estudiante: Jose Vargas");
            Console.WriteLine("Estudiante: Bernardo Hidalgo Castro");
            Console.WriteLine("Estudiante: Kevin Villalobos Rodríguez");
            Console.WriteLine("Estudiante: Mario Venegas Venegas(Rama Principal)");
            Console.WriteLine("Estudiante: Ariana Díaz Luna");
            Console.WriteLine("Arte ASCII por ascii-art-generator.org.");
            Console.ReadLine(); 

        }

        /// <summary>
        /// Función que arranca el juego de Trivia
        /// </summary>
        static public void IniciarJuego()
        {
            Juego juegoActual = new Juego();
        }
        
        /// <summary>
        /// Esta funcion transforma texto en numeros, si sucede un error regresa un -1
        /// </summary>
        /// <returns></returns>
        static public int CapturarNumero()
        {
            try
            {
                string textoEscritoPorElUsuario;
                textoEscritoPorElUsuario = Console.ReadLine();
                return int.Parse(textoEscritoPorElUsuario);
            }
            catch
            {
                Console.WriteLine("Error al escribir un número!");
                Console.WriteLine("Solo se aceptan números");
                Console.ReadLine();
                return -1;
            }
        }

        /// <summary>
        /// Imprime en la pantalla las opciones que el usuario tiene. 
        /// </summary>
        static public void MostrarOpciones() 
        {
            Console.WriteLine("1 - Iniciar Juego");
            Console.WriteLine("2 - Creditos");
            Console.WriteLine("3 - Salir");
            Console.Write("Digite su seleccion: ");
        }
    }
}
