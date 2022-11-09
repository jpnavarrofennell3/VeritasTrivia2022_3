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
        Dificultad[] bancoDePreguntas;
        int nivelDeDificultad;
        int numeroDePregunta;
        Random generadorDeNumerosAleatorios;

        // Método constructor
        public Juego()
        {
            bancoDePreguntas = new Dificultad[5];
            CargarDatos();
            nivelDeDificultad = 0;
            // creo el objeto que me da números aleatorios.
            generadorDeNumerosAleatorios = new Random();
            // según el manual, me entrega un numero int del 1 al 5 sin incluir el 5.
            numeroDePregunta = generadorDeNumerosAleatorios.Next(0, 5);
        }



        // Método que inicia el juego
        public void IniciarJuego() 
        { }

        // Método que se ejecuta al perder el juego
        public void PerderJuego()
        { }

        // Método que me entrega una pregunta del banco de pregunta en la dificultada
        // actual
        public void ObtenerPregunta()
        { }

        // Método que responde la pregunta actual en la dificultad actual.
        public void ReponderPregunta()
        {

        }

        // Método que me da la respuesta de la pregunta actual en la dificultad actual
        public void ObtenerRespuesta()
        { }

        public void EvaluarRespuesta()
        { }

        public void ProgresarJuego()
        {
            nivelDeDificultad += 1; // nivelDeDificultad = nivelDeDificultad + 1;
        }

        public void FinJuego()
        { }

        public void CargarDatos()
        {
            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿De que color es el pelo de Natsu?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Verde";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Rojo";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Violeta";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Rosado";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "¿Que accesorio usa Simon de  Tengen Toppa Gurren-Lagann?";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Amteojos";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Una Flor";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Casco";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Mascara";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "¿Cual es la comida favorita de Ania Forger de Spy Family?";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Chocolates";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Palomitas de maíz";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Manís";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Galletas";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "¿Como se llama el primer Jojo's?";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Josep Joestar";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Jonathan Joestar";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Jesus Joestar";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Jotaro Kujo";


            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "¿Como tiene el pelo Gon de Hunter X Hunter?";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Lacio";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Picudo";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Calvo";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Curly";

            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";

            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "¿De que arma salió el supremo kaiosama de Dragon ball?";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Hacha";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Arco";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Espada";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Daga";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Cual es el arma Yoko de Tengen Toppa Gurren-Lagann?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Una Metralleta";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Espada";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Robot";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Francotirador";

            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "¿Cual es el Herramienta favorito de Gon de Hunter  X Hunter?";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Caña de Pescar";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Espada";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Hacha";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Martillo";

            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "¿Como se llama el dragón Slayer de Metal en Fairy Tail?";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Laxus";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Lucy";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Natsu";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Gajeel";

            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";
            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";
            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";
            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";

        }
    }
}
