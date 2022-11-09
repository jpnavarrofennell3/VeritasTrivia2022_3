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

            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿Cuando salio Apex?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2017";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2018";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2019";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "2020";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "¿Cual es un personaje que salio con el juego?";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Octane";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Wraith";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Wattson";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Valkyrie";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "¿Quien es el publisher de Apex";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Activision";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Ubisoft";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "EA";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Tencent";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "¿Cuantos mapas tenia Apex cuando salio?";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "3";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "4";

            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "¿Cual es el nombre del robot alegre de Apex?";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Glados";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "BT-7274";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Revenant";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Pathfinder";

            bancoDePreguntas[1].nombreDeLaDificultad = "Facil";

            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "¿Cual fue le personaje que tuvo el primer Heirloom?";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Pathfinder";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Octane";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Bloodhound";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "wraith";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Cual personaje puede revivir a aliados mientras sigue peleando?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Newcastle";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Loba";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Gibby";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Lifeline";

            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "¿Cual personaje puede escanear enemigos?";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Pathfinder";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Mirage";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Bloodhound";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Bangalore";

            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "¿Cuantos modos de juego permanente tiene Apex?";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "1";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5";

            bancoDePreguntas[1].preguntas[4].enunciadoDeLaPregunta = "¿Cual personaje habla español?";
            bancoDePreguntas[1].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Horizon";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Octane";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Caustic";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Vanguard";

            bancoDePreguntas[2].nombreDeLaDificultad = "Medio";

            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "¿Cual personaje tiene un miniagujero negro como habilidad?";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Ash";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Casutic";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Horizon";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "wraith";

            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "¿Cual personaje proviene del mismo planeta que Fuse?";
            bancoDePreguntas[2].preguntas[1].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "MadMaggie";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Seer";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Wattson";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Bloodhound";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿Cual persoanje es el mas viejo?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Pathfinder";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Revenant";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Horizon";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ash";

            bancoDePreguntas[2].preguntas[3].enunciadoDeLaPregunta = "¿Cual personaje tubo su clase/rol cambiado?";
            bancoDePreguntas[2].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Newcastle";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Vanguard";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Pathfinder";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Crypto";

            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "¿Cual fue el segundo mapa de Apex?";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Kings Cannon";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Worlds Edge";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Olympus";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "New Moon";

            bancoDePreguntas[2].nombreDeLaDificultad = "Dificil";

            bancoDePreguntas[3].preguntas[0].enunciadoDeLaPregunta = "¿Actualmente cuantos mapas tiene Apex en el modo BattleR Royale?";
            bancoDePreguntas[3].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "3";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "5";

            bancoDePreguntas[3].preguntas[1].enunciadoDeLaPregunta = "¿Cual estudio desarrollo Apex?";
            bancoDePreguntas[3].preguntas[1].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "BioWare";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "EA";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Dice";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Respawn";

            bancoDePreguntas[3].preguntas[2].enunciadoDeLaPregunta = "Apex esta basado en el mismo universo que:";
            bancoDePreguntas[3].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Halo";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Titanfall";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Gundam";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Mass Effect";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "¿Cual leyenda se deshizo de su competencia para poder entrar a los Apex Games?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Newcastle";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Loba";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Revenant";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ash";

            bancoDePreguntas[3].preguntas[4].enunciadoDeLaPregunta = "¿Cual es la ascendencia de Crypto?";
            bancoDePreguntas[3].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Korea";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "China";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Japon";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Thailandia";

            bancoDePreguntas[2].nombreDeLaDificultad = "Muy Dificil";

            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "¿Cual personaje no tiene genero?";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Bloodhound";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "MadMaggie";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Pathfinder";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Wraith";

            bancoDePreguntas[4].preguntas[1].enunciadoDeLaPregunta = "¿Cual personaje esta buscando a su hijo?";
            bancoDePreguntas[4].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Bangalore";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Fuse";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Horizon";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "MadMaggie";

            bancoDePreguntas[4].preguntas[2].enunciadoDeLaPregunta = "¿Cual personaje descendiente de un jefe del Titanfall 2?";
            bancoDePreguntas[4].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Valkyrie";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Ash";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Mirage";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Octane";

            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "¿Quien creo el anillo o la zona en el Battle Royale?";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Casutic";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Horizon";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Wattson";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ash";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "¿Cual es la relacion entre Octavio Silva y Octane?";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Hermanos";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Padre e Hijo";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Abuelo y Nieto";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Primos";


        }
    }
}
