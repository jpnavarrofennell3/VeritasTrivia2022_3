using LogicaJuego;

namespace TriviaVeritas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccionDelUsuario = 0;

            // Gameloop
            while(seleccionDelUsuario != 4)
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
                    IniciarJuego();
                }
                // si la persona escribio 2
                else if (seleccionDelUsuario == 2)
                {
                    // desplegar los créditos del juego
                    MostarInstrucciones();
                }

                // si la persona escribio 3
                else if (seleccionDelUsuario == 3)
                {
                    // desplegar los créditos del juego
                    MostrarCreditos();
                }
                // si la persona escribio 4
                else if (seleccionDelUsuario == 4)
                {
                    Console.WriteLine("Ha escogido salir");
                    Console.ReadLine();
                }
            }
        }

        static public void MostarInstrucciones()
        {
            // Todo juego que desarrollemos debe mostrar
            // o explicar como se juega
            Console.WriteLine("Instrucciones del juego");
            Console.ReadLine();
        }
         
        /// <summary>
        /// Esta funcion muestra la portada de trivia
        /// </summary>
        static public void MostrarPortada()
        {
            // 006
            // 015
            Console.Clear();
            Console.WriteLine("__ __|   _)       _)       \r\n   |  __| |\\ \\   / |  _` | \r\n   | |    | \\ \\ /  | (   | \r\n  _|_|   _|  \\_/  _|\\__,_| \r\n                           \r\n\\ \\     /        _) |              \r\n \\ \\   / _ \\  __| | __|  _` |  __| \r\n  \\ \\ /  __/ |    | |   (   |\\__ \\ \r\n   \\_/ \\___|_|   _|\\__|\\__,_|____/ ");
        }

        /// <summary>
        /// Esta función mustra los créditos de la trivia
        /// </summary>


        static public void MostrarCreditos()
        {
            // 019
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
            int respuestaDelJugador;
            Juego juegoActual = new Juego();
            Console.WriteLine( "Usted esta en nivel {0}", juegoActual.ObtenerDificultadActual());

            // Defino una variable que me dice cuantos niveles vamos a jugar como límite
            int limite = 5;

            // necesitamos repetir el proceso de juego hasta el número
            // que nos diga el límite
            for (int b =0; b < limite; b++)
            {
                // 010
                // Desplegamos la pregunta
                Console.WriteLine(juegoActual.ObtenerPregunta());

                // 010
                // Desplegar posibles respuestas
                Console.WriteLine("0 - " + juegoActual.ObtenerRespuestasPosibles(0));
                Console.WriteLine("1 - " + juegoActual.ObtenerRespuestasPosibles(1));
                Console.WriteLine("2 - " + juegoActual.ObtenerRespuestasPosibles(2));
                Console.WriteLine("3 - " + juegoActual.ObtenerRespuestasPosibles(3));

                // Capturo la respuesta del jugador
                respuestaDelJugador = CapturarNumero();

                // LLamo al método ResponderPRegunta con el número que escribió el jugador
                juegoActual.ReponderPregunta(respuestaDelJugador);

                // Evaluar la respuesta del jugador
                if (juegoActual.EvaluarRespuesta() == true)
                {
                    // 012
                    // Ejecutar condición de gane
                    Console.WriteLine("¡Correcto, has acertado!");

                    // 013
                    // Repetición del problema con mayor dificultad.
                    juegoActual.ProgresarJuego();
                }
                else
                {
                    // 011
                    // Ejecutar condición de perdida si el jugador no acerto
                    Console.WriteLine("¡No has acertado!");
                    Console.WriteLine("¡Juego Terminado!");

                    juegoActual.PerderJuego();

                    Console.ReadLine();

                    // romper el ciclo for
                    break;
                }
                Console.ReadLine();
            }

            // Como me doy cuenta que el jugador completo todos los niveles?
            // si el nivel de dificultad llega al valor 5 el jugador superó todo
            // el juego
            if ( juegoActual.ObtenerDificultadActual() == 5)
            {
                // Cominicarle al jugador que ha superado el juego
                Console.WriteLine("¡Has superado el juego de trivia!");
                Console.ReadLine();
            }
        }
        
        /// <summary>
        /// Esta funcion transforma texto en números, si sucede un error regresa un -1
        /// </summary>
        /// <returns></returns>
        static public int CapturarNumero()
        {
            // Principio DRY: Dont repeat yourself
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
            // 006 - parte de la portada
            Console.WriteLine("1 - Iniciar Juego");
            Console.WriteLine("2 - Instrucciones");
            Console.WriteLine("3 - Creditos");
            Console.WriteLine("4 - Salir");
            Console.Write("Digite su seleccion: ");
        }
    }
}
