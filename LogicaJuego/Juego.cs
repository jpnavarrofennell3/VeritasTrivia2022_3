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
            //Esta funcion funciona como FileExplorer de Windows. 
            //Por ejemplo: bancoDePreguntas 0/Pregunta 0/enunciadoDeLaPregunta/ 'Pregunta'.

            // Nivel muy fácil
            bancoDePreguntas[0].nombreDeLaDificultad = "Muy Fácil";


        }
    }
}
