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
            bancoDePreguntas[0].nombreDeLaDificultad = "Muy Fácil";
            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿Como se llama el hermano de Luffy de One Piece?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Ace";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Garou";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Jiraiya";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Zoro";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "¿Cual es el Poder de Izuku Midoriya de Boku no Hero Academia?";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Manos de Fuego";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Flotar";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Invisibilidad";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "One For All";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "¿Que numero de hokage es naruto?";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Séptimo";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Primero";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Octavo";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Quinto";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "¿Cuál es la materia de la fruta de Luffy en el anime?";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Diamante";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Goma";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Fuego";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Papel";

            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "¿De que color son los ojos de Goku en Super Saiyayin?";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Rojo";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Verde";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Negro";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Azul";
            ///

            ///
            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";
            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "¿De que color es el pelo de Natsu?";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Verde";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Rojo";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Violeta";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Rosado";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Que accesorio usa Simon de  Tengen Toppa Gurren-Lagann?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Anteojos";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Una Flor";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Casco";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Mascara";

            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "¿Cual es la comida favorita de Ania Forger de Spy Family?";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Chocolates";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Palomitas de maíz";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Manís";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Galletas";

            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "¿Como se llama el primer Jojo's?";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Josep Joestar";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Jonathan Joestar";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Jesus Joestar";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Jotaro Kujo";


            bancoDePreguntas[1].preguntas[4].enunciadoDeLaPregunta = "¿Como tiene el pelo Gon de Hunter X Hunter?";
            bancoDePreguntas[1].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Lacio";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Picudo";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Calvo";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Curly";
            ///
            
            ///
            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";
            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "¿De que arma salió el supremo kaiosama de Dragon ball?";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Hacha";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Arco";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Espada";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Daga";

            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "¿Cual es el arma Yoko de Tengen Toppa Gurren-Lagann?";
            bancoDePreguntas[2].preguntas[1].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Una Metralleta";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Espada";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Robot";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Francotirador";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿Cual es el Herramienta favorito de Gon de Hunter  X Hunter?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Caña de Pescar";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Espada";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Hacha";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Martillo";

            bancoDePreguntas[2].preguntas[3].enunciadoDeLaPregunta = "¿Como se llama el dragón Slayer de Metal en Fairy Tail?";
            bancoDePreguntas[2].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Laxus";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Lucy";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Natsu";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Gajeel";

            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "¿De que color son los ojos de Law de One Piece?";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Verdes";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Azul";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Gris";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Morado";
            ///

            ///
            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";
            bancoDePreguntas[3].preguntas[0].enunciadoDeLaPregunta = "¿Como se llama el dragón de la tormenta de Tensei Shitara Slime Datta Ken?";
            bancoDePreguntas[3].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Shiro Tempest";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Rimuru Tempest";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Kuro Tempest";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Verudora Tempest";

            bancoDePreguntas[3].preguntas[1].enunciadoDeLaPregunta = "¿Cuantas temporadas tiene Shingeki no Kyojin?";
            bancoDePreguntas[3].preguntas[1].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "3";

            bancoDePreguntas[3].preguntas[2].enunciadoDeLaPregunta = "¿Cuantas temporadas tiene JoJo's Bizarre Adventure?";
            bancoDePreguntas[3].preguntas[2].respuestaCorrecta = 5;
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "3";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "5";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "8";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "¿Como se llama el creador de “ONE PIECE?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Chuck Norris";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Yoshihiro Togashi";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Eiichiro Oda";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Doctor Dusfermin";

            bancoDePreguntas[3].preguntas[4].enunciadoDeLaPregunta = "¿Cual fue el quinto Tripulante de One piece?";
            bancoDePreguntas[3].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Sanji";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Zoro";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Chopper";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Brook";
            ///

            ///
            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";

            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "¿Actris de Voz de luffy?";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Mayumi Tanaka";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Rie Takahashi";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Hiroshi Kamiya";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Inori Minase";

            bancoDePreguntas[4].preguntas[1].enunciadoDeLaPregunta = "¿Cuales animes son los 3 grandes?";
            bancoDePreguntas[4].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Dragon Ball, One Piece, Naruto";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "One Piece, Bleach, Naruto";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Bleach, Fairy Tail, Naruto";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Naruto, Dragon Ball, Bleach";

            bancoDePreguntas[4].preguntas[2].enunciadoDeLaPregunta = "¿Cuantos capítulos tiene Detective Conan en su adaptación anime?";
            bancoDePreguntas[4].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1060";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1020";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "512";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "1200";

            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "¿En que año se empezó a trasmitir One piece?";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1980";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "1998";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2001";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "1999";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "¿Cual es el anime con mas capítulos?";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "One Piece";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Detective Conan";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Sazae-san";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Naruto";
        }

        // Método que retorna la dificultad actual
        public int ObtenerDificultadActual()
        {
            return nivelDeDificultad;
        }
    }
}
