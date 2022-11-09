using System;
using System.Collections.Generic;
using System.Globalization;
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

        //Metodo que Retorna la dificultad actual
        public int ObtenerDificultadActual()
        {

            return nivelDeDificultad;   

        }

        // Método constructor
        public Juego()
        {
            //004
            bancoDePreguntas = new Dificultad[5];

            bancoDePreguntas[0] = new Dificultad();
            bancoDePreguntas[1] = new Dificultad();
            bancoDePreguntas[2] = new Dificultad();
            bancoDePreguntas[3] = new Dificultad();
            bancoDePreguntas[4] = new Dificultad();

            bancoDePreguntas[0].preguntas = new Pregunta[5];

            bancoDePreguntas[0].preguntas[0] = new Pregunta();
            bancoDePreguntas[0].preguntas[1] = new Pregunta();
            bancoDePreguntas[0].preguntas[2] = new Pregunta();
            bancoDePreguntas[0].preguntas[3] = new Pregunta();
            bancoDePreguntas[0].preguntas[4] = new Pregunta();

            bancoDePreguntas[1].preguntas = new Pregunta[5];

            bancoDePreguntas[1].preguntas[0] = new Pregunta();
            bancoDePreguntas[1].preguntas[1] = new Pregunta();
            bancoDePreguntas[1].preguntas[2] = new Pregunta();
            bancoDePreguntas[1].preguntas[3] = new Pregunta();
            bancoDePreguntas[1].preguntas[4] = new Pregunta();

            bancoDePreguntas[2].preguntas = new Pregunta[5];

            bancoDePreguntas[2].preguntas[0] = new Pregunta();
            bancoDePreguntas[2].preguntas[1] = new Pregunta();
            bancoDePreguntas[2].preguntas[2] = new Pregunta();
            bancoDePreguntas[2].preguntas[3] = new Pregunta();
            bancoDePreguntas[2].preguntas[4] = new Pregunta();

            bancoDePreguntas[3].preguntas = new Pregunta[5];

            bancoDePreguntas[3].preguntas[0] = new Pregunta();
            bancoDePreguntas[3].preguntas[1] = new Pregunta();
            bancoDePreguntas[3].preguntas[2] = new Pregunta();
            bancoDePreguntas[3].preguntas[3] = new Pregunta();
            bancoDePreguntas[3].preguntas[4] = new Pregunta();

            bancoDePreguntas[4].preguntas = new Pregunta[5];

            bancoDePreguntas[4].preguntas[0] = new Pregunta();
            bancoDePreguntas[4].preguntas[1] = new Pregunta();
            bancoDePreguntas[4].preguntas[2] = new Pregunta();
            bancoDePreguntas[4].preguntas[3] = new Pregunta();
            bancoDePreguntas[4].preguntas[4] = new Pregunta();

            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];

            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];

            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];

            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];

            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta = new Respuesta[4];
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta = new Respuesta[4];

            CargarDatos();
            nivelDeDificultad = 0;
            // creo el objeto que me da números aleatorios.
            generadorDeNumerosAleatorios = new Random();
            //021
            // según el manual, me entrega un numero int del 0 al 4 sin incluir el 5.
            numeroDePregunta = generadorDeNumerosAleatorios.Next(0, 5);
        }

        public void ProgresarJuego()
        {
            // 013
            nivelDeDificultad += 1; // nivelDeDificultad = nivelDeDificultad + 1;
            //021
            numeroDePregunta = generadorDeNumerosAleatorios.Next(0, 5);
        }

        public void PerderJuego()
        {
            //011
            nivelDeDificultad = 0;
            //021
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

                //012
                return true;
            else
                //011
                return false;


        }

        // Método que me da la respuesta de la pregunta actual en la dificultad actual
        //Public int devuelve un int esto funciona con cualquier otro tipo de variable. Ya sea FLOAT BOOL,STRING, etc.
       // public Respuesta[] ObtenerRespuestasPosibles()
        //{
        //    Respuesta[] respuestasPosiblesTemporal =
        //    bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestasDeLaPregunta;
        //    return respuestasPosiblesTemporal;    
       // }

        public string ObtenerRespuestasPosibles(int indice)
        {
            return bancoDePreguntas[nivelDeDificultad].preguntas[numeroDePregunta].respuestasDeLaPregunta[indice].EnunciadoDeLaRespuesta;

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
