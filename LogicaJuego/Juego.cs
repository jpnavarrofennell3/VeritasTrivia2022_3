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

            bancoDePreguntas[0] = new Dificultad();
            bancoDePreguntas[1] = new Dificultad();
            bancoDePreguntas[2] = new Dificultad();
            bancoDePreguntas[3] = new Dificultad();
            bancoDePreguntas[4] = new Dificultad();

            bancoDePreguntas[0].preguntas = new Pregunta[5];

            bancoDePreguntas[0].preguntas[0] = new Pregunta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[1] = new Pregunta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[2] = new Pregunta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[3] = new Pregunta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[0].preguntas[4] = new Pregunta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[0] = new Pregunta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[1] = new Pregunta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[2] = new Pregunta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[3] = new Pregunta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[1].preguntas[4] = new Pregunta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[0] = new Pregunta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[1] = new Pregunta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[2] = new Pregunta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[3] = new Pregunta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[2].preguntas[4] = new Pregunta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[0] = new Pregunta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[1] = new Pregunta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[2] = new Pregunta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[3] = new Pregunta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[3].preguntas[4] = new Pregunta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();







            bancoDePreguntas[4].preguntas[0] = new Pregunta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[1] = new Pregunta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[2] = new Pregunta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[3] = new Pregunta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3] = new Respuesta();

            bancoDePreguntas[4].preguntas[4] = new Pregunta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0] = new Respuesta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1] = new Respuesta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2] = new Respuesta();
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3] = new Respuesta();

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



            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";
            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "¿La mascota de Nintendo “Mario” realizó su debut en cual videojuego?";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Galaga";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Asteroids";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Donkey Kong";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Pac Man";




            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";
            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "¿Las series de videojuegos de “Uncharted” y “The Last of Us” fueron creadas por cuál desarrollador?";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Blizzard";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Naughty Dog";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "WB. Games Montreal";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Bungie";




            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";
            bancoDePreguntas[3].preguntas[0].enunciadoDeLaPregunta = "¿Cómo se llamaba el Nintendo Enterntainment System (NES) en Japón? ";
            bancoDePreguntas[3].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Family Computer Disk System";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Compact Game System";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Game Computer System";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Super Computer Disk System";




            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";
            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "Devil May Cry fue lanzado en 2001. Sin embargo, el juego fue creado “accidentalmente” ya que originalmente el juego era un prototipo del juego:";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Resident Evil 4";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Dead Rising";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Resident Evil 2";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Dead Rising 2";


        }

        // Método que retorna la dificultad actual
        public int ObtenerDificultadActual()
        {
            return nivelDeDificultad;
        }
    }
}
