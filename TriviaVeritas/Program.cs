using LogicaJuego;

namespace TriviaVeritasAndréRodríguez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SeleccionDelUsuario = 0;

            //uso de gameloop
            while (SeleccionDelUsuario != 4)
            {
                // se enseña la portada
                MostrarPortada();
                // se muestran las opciones en numeradas 
                MostrarOpciones();

                // se obtiene la decision del usurario y se guarda el dato de este
                SeleccionDelUsuario = CapturarNumero();

                //lo siguiente es lo que se hace cuando el usuario elige el numero 1
                if (SeleccionDelUsuario == 1)
                {
                    Console.WriteLine("_|    _|                                                                            _|        _|                _|            _|            _|                            _|                                          \r\n_|    _|    _|_|_|    _|_|_|        _|_|      _|_|_|    _|_|_|    _|_|      _|_|_|        _|_|_|    _|_|            _|_|_|          _|_|_|        _|_|_|  _|  _|_|            _|    _|    _|_|      _|_|_|    _|_|    \r\n_|_|_|_|  _|    _|  _|_|          _|_|_|_|  _|_|      _|        _|    _|  _|    _|  _|  _|    _|  _|    _|      _|  _|    _|  _|  _|        _|  _|    _|  _|_|            _|  _|    _|  _|_|_|_|  _|    _|  _|    _|  \r\n_|    _|  _|    _|      _|_|      _|            _|_|  _|        _|    _|  _|    _|  _|  _|    _|  _|    _|      _|  _|    _|  _|  _|        _|  _|    _|  _|              _|  _|    _|  _|        _|    _|  _|    _|  \r\n_|    _|    _|_|_|  _|_|_|          _|_|_|  _|_|_|      _|_|_|    _|_|      _|_|_|  _|    _|_|_|    _|_|        _|  _|    _|  _|    _|_|_|  _|    _|_|_|  _|              _|    _|_|_|    _|_|_|    _|_|_|    _|_|    \r\n                                                                                _|                                                                                        _|                            _|            \r\n                                                                            _|_|                                                                                        _|                          _|_|              \r\n");
                    Console.ReadLine();
                    IniciarJuego();
                }
                //Si el usuario elige el numero 2 sucede esto
                else if (SeleccionDelUsuario == 2)
                {
                    //muestra las instrucciones
                    MostrarInstrucciones();
                }
                // si el usario eligue el numero 3 sucede esto 
                else if (SeleccionDelUsuario == 3)
                {
                    //Muestra los creditos
                    MostrarCreditos();
                }
                // si el usuario elegue 4 sucede  esto
                else if (SeleccionDelUsuario == 4)
                {
                    Console.WriteLine("#     #                                                                                                      \r\n#     #   ##    ####     ######  ####   ####   ####   ####  # #####   ####      ####    ##   #      # #####  \r\n#     #  #  #  #         #      #      #    # #    # #    # # #    # #    #    #       #  #  #      # #    # \r\n####### #    #  ####     #####   ####  #      #    # #      # #    # #    #     ####  #    # #      # #    # \r\n#     # ######      #    #           # #      #    # #  ### # #    # #    #         # ###### #      # #####  \r\n#     # #    # #    #    #      #    # #    # #    # #    # # #    # #    #    #    # #    # #      # #   #  \r\n#     # #    #  ####     ######  ####   ####   ####   ####  # #####   ####      ####  #    # ###### # #    # ");
                    Console.ReadLine();
                }
            }
        }

        static public void MostrarInstrucciones()
        {
            //se muestra como jugar la trivia 
            Console.WriteLine(" Instruciones de la trivia");
            Console.WriteLine(" Se le mostrara una pregunta la cual empezara con un minimo nivel de dificultad y se le incrementara el nivel conforme vaya respondiende las preguntas");
            Console.WriteLine(" La cantidad maxima de preguntas seran 5");
            Console.WriteLine(" Para responder  las pregruntas, sus respuestas tendran un numero al lado izquierdo de la respuesta digitar ese numero para indicar que esa es la respuesta escogida");
            Console.WriteLine(" El juego le indicara si perdio o gano");
            Console.ReadLine();
        }
        //siguiente función muestra la portada de la trivia
        static public void MostrarPortada()
        {
            Console.Clear();
            Console.WriteLine(" _   _   _   _   _   _     _   _   _   _   _   _   _  \r\n / \\ / \\ / \\ / \\ / \\ / \\   / \\ / \\ / \\ / \\ / \\ / \\ / \\ \r\n( T | r | i | v | i | a ) ( V | e | r | i | t | a | s )\r\n \\_/ \\_/ \\_/ \\_/ \\_/ \\_/   \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ \\_/ ");
        }
        //siguiente función muestra de los creditos de la trivia
        static public void MostrarCreditos()
        {
            Console.WriteLine("Creados por juan Navarro");
            Console.WriteLine("estudiante: André Rodríguez Artavia");
        }
        //Funcion que hace iniciar el juego 
        static public void IniciarJuego()
        {
            int respuestadeljugador;
            juego juegoActual = new juego();
            Console.WriteLine("            __           __             __                              __         _            __     ______  _ \r\n  __  _______/ /____  ____/ /  ___  _____/ /_____ _   ___  ____     ___  / /  ____  (_)   _____  / /   _/_/ __ \\| |\r\n / / / / ___/ __/ _ \\/ __  /  / _ \\/ ___/ __/ __ `/  / _ \\/ __ \\   / _ \\/ /  / __ \\/ / | / / _ \\/ /  _/_// / / // /\r\n/ /_/ (__  ) /_/  __/ /_/ /  /  __(__  ) /_/ /_/ /  /  __/ / / /  /  __/ /  / / / / /| |/ /  __/ /  < < / /_/ /_>_>\r\n\\__,_/____/\\__/\\___/\\__,_/   \\___/____/\\__/\\__,_/   \\___/_/ /_/   \\___/_/  /_/ /_/_/ |___/\\___/_/   / / \\____//_/  \r\n                                                                                                    \\_\\     /_/ ", juegoActual.ObtenerDificultadActual());
            //variable que define cuantos niveles se juegan 
            int limite = 5;
            // en el siguiente se va a repetir el juego hasta llegar al limete 
            for (int b = 0; b < limite; b++)
            {
                //s enseña la pregunta
                Console.WriteLine(juegoActual.ObtenerPregunta());
                // se senseñan todas las posibles respuestas
                Console.WriteLine("0-" + juegoActual.ObtenerRespuestasPosibles(0));
                Console.WriteLine("1-" + juegoActual.ObtenerRespuestasPosibles(1));
                Console.WriteLine("2-" + juegoActual.ObtenerRespuestasPosibles(2));
                Console.WriteLine("3-" + juegoActual.ObtenerRespuestasPosibles(3));
                //se obtiene la respueta del jugador
                respuestadeljugador = CapturarNumero();
                // metodo para responder la pregunta con la respuesta del jugador
                juegoActual.ResponderPregunta(respuestadeljugador);
                //en el siguiente se evalua la respuesta 
                if (juegoActual.EvaluarRespuesta() == true)
                {
                    // cuando se gana
                    Console.WriteLine("#####                                                                                                                                        ### \r\n#     #  ####  #####  #####  ######  ####  #####  ####         #    #   ##    ####       ##    ####  ###### #####  #####   ##   #####   ####  ### \r\n#       #    # #    # #    # #      #    #   #   #    #        #    #  #  #  #          #  #  #    # #      #    #   #    #  #  #    # #    # ### \r\n#       #    # #    # #    # #####  #        #   #    #        ###### #    #  ####     #    # #      #####  #    #   #   #    # #    # #    #  #  \r\n#       #    # #####  #####  #      #        #   #    # ###    #    # ######      #    ###### #      #      #####    #   ###### #    # #    #     \r\n#     # #    # #   #  #   #  #      #    #   #   #    # ###    #    # #    # #    #    #    # #    # #      #   #    #   #    # #    # #    # ### \r\n #####   ####  #    # #    # ######  ####    #    ####   #     #    # #    #  ####     #    #  ####  ###### #    #   #   #    # #####   ####  ### ");
                    juegoActual.ProgresarJuego();
                }
                else
                {
                    //cuando se pierde
                    Console.WriteLine("#    #   ##    ####     #####  ###### #####  #####  # #####   ####  \r\n#    #  #  #  #         #    # #      #    # #    # # #    # #    # \r\n###### #    #  ####     #    # #####  #    # #    # # #    # #    # \r\n#    # ######      #    #####  #      #####  #    # # #    # #    # \r\n#    # #    # #    #    #      #      #   #  #    # # #    # #    # \r\n#    # #    #  ####     #      ###### #    # #####  # #####   ####  \r\n                                                                    ");
                    Console.ReadLine();

                    //rompe el ciclo

                    break;

                }
                Console.ReadLine();
            }
            // cuadno la dificultad esta al maximo y se supera todo el juego esto pasa
            if (juegoActual.ObtenerDificultadActual() == 5)
            {
                Console.WriteLine("  #     #                                                                                                                                                                                       ### \r\n   #     #   ##    ####      ####  #    # #####  ###### #####    ##   #####   ####     ###### #              # #    # ######  ####   ####     #####  ######    ##### #####  # #    # #   ##      ### \r\n   #     #  #  #  #         #      #    # #    # #      #    #  #  #  #    # #    #    #      #              # #    # #      #    # #    #    #    # #           #   #    # # #    # #  #  #     ### \r\n   ####### #    #  ####      ####  #    # #    # #####  #    # #    # #    # #    #    #####  #              # #    # #####  #      #    #    #    # #####       #   #    # # #    # # #    #     #  \r\n   #     # ######      #         # #    # #####  #      #####  ###### #    # #    #    #      #              # #    # #      #  ### #    #    #    # #           #   #####  # #    # # ######        \r\n   #     # #    # #    #    #    # #    # #      #      #   #  #    # #    # #    #    #      #         #    # #    # #      #    # #    #    #    # #           #   #   #  #  #  #  # #    #    ### \r\n   #     # #    #  ####      ####   ####  #      ###### #    # #    # #####   ####     ###### ######     ####   ####  ######  ####   ####     #####  ######      #   #    # #   ##   # #    #    ### \r\n                                                                                                                                                                                                     \r\n");
                Console.ReadLine();
            }
        }
        //función que transforma texto en numeros si hay un error regresa a -1
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
                Console.WriteLine("Error al escrbir");
                Console.WriteLine("solo se aceptan numeros del 1 al 4 ");
                Console.ReadLine();
                return -1;
            }
        }
        // muestra la pantalla y sus opciones 
        static public void MostrarOpciones()
        {
            //parte de la pantalla 
            Console.WriteLine("1- Iniciar Juego");
            Console.WriteLine("2- Instrciones del juego");
            Console.WriteLine("3- creditos");
            Console.WriteLine("4- Salir");
            Console.WriteLine("Digite su selección: ");
        }
    }
}

