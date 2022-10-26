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
        Dificultad[] bancoDePreguntas;

        public Juego()
        {
            bancoDePreguntas = new Dificultad[5];
        }




        public void IniciarJuego() 
        { }

        public void PerderJuego()
        { }

        public void ObtenerPregunta()
        { }

        public void ObtenerRespuesta()
        { }

        public void EvaluarRespuesta()
        { }

        public void ProgresarJuego()
        { }

        public void FinJuego()
        { }

        public void CargarDatos()
        {
            //Esta funcion funciona como FileExplorer de Windows. 
            //Por ejemplo: bancoDePreguntas 0/Pregunta 0/enunciadoDeLaPregunta/ 'Pregunta'.

            // Nivel muy fácil
            bancoDePreguntas[0].nombreDeLaDificultad = "Muy Fácil";

            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿Cuál es el primer planeta del sistema solar?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Venus";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Mercurio";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Tierra";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Marte";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "¿Cuál es el satélite que rodea la tierra?";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Phobos";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Titán";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Luna";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Europa";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "";
            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "";
            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "";

            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";
            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";
            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";
            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";
        }
    }
}
