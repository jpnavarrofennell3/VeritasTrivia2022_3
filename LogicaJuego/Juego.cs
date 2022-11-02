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
            bancoDePreguntas = new Dificultad[5];
            CargarDatos();
            nivelDeDificultad = 0;
            // creo el objeto que me da números aleatorios.
            generadorDeNumerosAleatorios = new Random();
            // según el manual, me entrega un numero int del 0 al 4 sin incluir el 5.
            numeroDePregunta = generadorDeNumerosAleatorios.Next(0, 5);
        }

        public void ProgresarJuego()
        {
            // 013
            nivelDeDificultad += 1; // nivelDeDificultad = nivelDeDificultad + 1;
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

                return true;
            else
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

            
        }
    }
}
