using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeObjetos;

namespace LogicaJuego
{
    public class Juego
    {
        // propiedades ó variables
        private Dificultad[] bancoDePreguntas;
        private int nivelDeDificultad;
        private int numeroDePregunta;
        private Random generadorDeNumerosAleatorios;
        private int respuestaDelUsuario;

        // Método constructor
        public Juego()
        {
            // 004
            bancoDePreguntas = new Dificultad[5];

            CargarDatos();

            nivelDeDificultad = 0;
            // creo el objeto que me da números aleatorios.
            generadorDeNumerosAleatorios = new Random();
            // según el manual, me entrega un numero int del 0 al 4 sin incluir el 5.
            // 021
            numeroDePregunta = generadorDeNumerosAleatorios.Next(0, 5);
        }

        public void ProgresarJuego()
        {
            // 013
            nivelDeDificultad += 1; // nivelDeDificultad = nivelDeDificultad + 1;
            // 021
            numeroDePregunta = generadorDeNumerosAleatorios.Next(0, 5);
        }

        public void PerderJuego()
        {
            // 011
            nivelDeDificultad = 0;

            // 021
            numeroDePregunta = generadorDeNumerosAleatorios.Next(0, 5);
        }

        // Método que me entrega una pregunta del banco de pregunta en la dificultada
        // actual
        public string ObtenerPregunta()
        {
            return bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].enunciadoDeLaPregunta;
        }

        // Método que responde la pregunta actual en la dificultad actual.
        // Recibe un un valor que guarda en respuestaDelUsuario
        public void ReponderPregunta(int parametro)
        {

            respuestaDelUsuario = parametro;
        }

        // Método que me indica si el jugador acerto o falla la pregunta 
        // Si acertó, el método devuelve el valor TRUE
        // Caso contrario, devuelve false.
        public bool EvaluarRespuesta()
        {
            if ( respuestaDelUsuario ==  bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestaCorrecta )
                // 012
                return true;
            else
                // 011
                return false;

        }

        // Método que me da la respuesta de la pregunta actual en la dificultad actual
        //public Respuesta[] ObtenerRespuestasPosibles()
        //{
        //    Respuesta[] respuestasPosiblesTemporal = bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestasDeLaPregunta;
        //    return respuestasPosiblesTemporal;
        //}

        public string ObtenerRespuestasPosibles(int indice) // indice es de 0-3
        {
            return
                bancoDePreguntas[nivelDeDificultad].    // 2
                    preguntas[numeroDePregunta].        // 0
                        respuestasDeLaPregunta[indice]. // 3
                            EnunciadoDeLaRespuesta;     // YuGiOh
        }

        public int DarRespuestaCorrecta(int indice)
        {
            return bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestaCorrecta;
        }

        public void CargarDatos()
        {
            //Esta funcion funciona como FileExplorer de Windows. 
            //Por ejemplo: bancoDePreguntas 0/Pregunta 0/enunciadoDeLaPregunta/ 'Pregunta'.

            // Nivel muy fácil
            bancoDePreguntas[0].nombreDeLaDificultad = "Muy Fácil";
            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿Cómo se llama el dinosaurio verde que acompaña a Mario en sus aventuras?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Birdo";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Yoshi";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Toad";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Toadette";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "¿Cuál compañía fabricó la familia de consolas Xbox?";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Apple";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Sony";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Microsoft";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Samsung";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "¿Cómo se llamaba la primera consola portátil de Nintendo?";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Star boy";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Go boy";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Super boy";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Game boy";



            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "¿Cómo se llama la franquicia de videojuegos de fútbol más famosa del mundo?";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "FIFA";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Super Soccer";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Football plus";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "eFootbal";


            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "La ocupación de Mario (Super Mario Bros.) es:";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Carpintero";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Bombero";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Constructor";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Plomero";


            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";
            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "¿La mascota de Nintendo “Mario” realizó su debut en cual videojuego?";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Galaga";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Asteroids";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Donkey Kong";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Pac Man";


            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "La mascota de SEGA, Sonic, es:";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Un equidna";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Un ornitorrinco";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Un conejo";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Un erizo";


            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "En la franquicia de videojuegos “La Leyenda de Zelda”, el héroe se llama Link. ¿Como se llama el villano principal?";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Bowser";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Ganondorf";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Kind DeDeDe";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "King K. Rool";


            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "¿Qué hace el hongo verde en Super Mario Bros.?";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Le da un sombrero verde a Mario";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Hace que Mario crezca";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Vuelve a Mario invencible";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Le da una vida extra a Mario";


            bancoDePreguntas[1].preguntas[4].enunciadoDeLaPregunta = "¿Como se llama la protagonista de la franquicia de juegos “Tomb Raider”?";
            bancoDePreguntas[1].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Lara Cruz";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Claire Redfield";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Lara Croft";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ellie Williams";

            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";
            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "¿Las series de videojuegos de “Uncharted” y “The Last of Us” fueron creadas por cuál desarrollador?";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Blizzard";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Naughty Dog";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "WB. Games Montreal";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Bungie";


            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "¿Cuál ha sido la consola de videojuegos más vendida de toda la historia?";
            bancoDePreguntas[2].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Nintendo Wii";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "PlayStation 2";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Nintendo DS";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "PlayStation 4";


            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿Cuál es actualmente el videojuego más vendido del mundo?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Tetris";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Grand Theft Auto 5";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Minecraft";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "PlayStation 4";

            bancoDePreguntas[2].preguntas[3].enunciadoDeLaPregunta = "¿Como se llama la última entrega en la ultima entrega de la saga de juegos Batman: Arkham?";
            bancoDePreguntas[2].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Arkham Origins";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Arkham City";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Arkham Asylum";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Arkham Knight";

            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "¿De qué país es el creador de Minecraft? ";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Suecia";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Suiza";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Noruega";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Finlandia";

            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";
            bancoDePreguntas[3].preguntas[0].enunciadoDeLaPregunta = "¿Cómo se llamaba el Nintendo Enterntainment System (NES) en Japón? ";
            bancoDePreguntas[3].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Family Computer Disk System";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Compact Game System";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Game Computer System";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Super Computer Disk System";

            bancoDePreguntas[3].preguntas[1].enunciadoDeLaPregunta = "El actual gigante de videojuegos Nintendo, fue fundada en el año:";
            bancoDePreguntas[3].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1989";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1975";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "1889";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "1905";

            bancoDePreguntas[3].preguntas[2].enunciadoDeLaPregunta = "Grand Theft Auto 5 está situada en una ciudad ficticia inspirada por Los Ángeles. ¿Cuál es el nombre de esta ciudad?";
            bancoDePreguntas[3].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Vice City";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Los Santos";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "New Vegas";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "New Angeles";


            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "A inicios de los 90’s, Nintendo estaba planeando crear el sucesor del Super Nintendo con un lector CD-ROM. ¿Con cuál compañía Nintendo brevemente se alió para crear prototipos de esta consola?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Sony";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Sega";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Microsoft";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Apple";

            bancoDePreguntas[3].preguntas[4].enunciadoDeLaPregunta = "¿Cuál es el nombre de la ciudad bajo el agua existente en el videojuego BioShock?";
            bancoDePreguntas[3].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Columbia";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Alexandria";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Atlantis";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Rapture";



            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";
            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "Devil May Cry fue lanzado en 2001. Sin embargo, el juego fue creado “accidentalmente” ya que originalmente el juego era un prototipo del juego:";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Resident Evil 4";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Dead Rising";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Resident Evil 2";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Dead Rising 2";


            bancoDePreguntas[4].preguntas[1].enunciadoDeLaPregunta = "¿Cuál es el nombre del fantasma color naranja de Pac-Man?";
            bancoDePreguntas[4].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Pinky";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Inky";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Clyde";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Blinky";


            bancoDePreguntas[4].preguntas[2].enunciadoDeLaPregunta = "En los Game Awards 2016, ¿cuál videojuego ganó el premio de Game of the Year?";
            bancoDePreguntas[4].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Doom (2016)";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Overwatch";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Uncharted 4: A Thief's End";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Titanfall 2";


            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "¿Cuál fue el primer Pokémon diseñado por los desarrolladores?";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Mew";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Rhydon";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Pikachu";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Bulbasaur";


            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "¿Cuál famoso actor interpreto a Cave Johnson en Portal 2?";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Willem Dafoe";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Denzel Washington";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Robert DeNiro";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "J.K. Simmons";

        }
    }
}
