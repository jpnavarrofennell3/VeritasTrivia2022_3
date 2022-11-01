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
        int respuestaDelUsuario;

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
        public void ObtenerRespuestasPosibles()
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

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "¿Cuántos planetas hay en el Sistema Solar?";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "8";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "9";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "7";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "10";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "¿Cuál es el planeta más grande del Sistema Solar?";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Saturno";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Urano";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Neptuno";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Júpiter";

            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "¿A cuál planeta se le llama 'Planeta Rojo'?";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Venus";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Mercurio";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Marte";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Júpiter";



            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";

            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "¿Cómo se llama la capa que filtra los rayos ultravioleta";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Ozono";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Litósfera";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Termósfera";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Atmósfera";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Qué tipo de galaxia es la Vía Láctea?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Quásar";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Espiral";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Irregular";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Elíptica";

            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "¿Entre qué planetas se encuentra el cinturón de asteroides del Sistema Solar?";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "La Tierra y Marte";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Júpiter y Saturno";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Marte y Júpiter";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "El Sol y Mercurio";

            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "¿El siguiente es un satélite de Marte?";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Fobos";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Titania";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Europa";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Pandora";

            bancoDePreguntas[1].preguntas[4].enunciadoDeLaPregunta = "¿Cómo se llama el cinturón de asteroides externo del Sistema Solar?";
            bancoDePreguntas[1].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Kepler";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Magallanes";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Oort";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Kuiper";



            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";

            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "¿En qué brazo de la Vía Láctea se encuentra el Sistema Solar?";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Sagitario";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Perseo";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Orión";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Norma";

            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "¿Cuántos grados de inclinación tiene el eje terrestre?";
            bancoDePreguntas[2].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "45.3°";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "23.5°";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "3°";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "90°";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿Qué científico desarrolló la teoría gravitacional del Universo?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Nicolás Copérnico";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Galileo Galilei";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Johannes Kepler";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Isaac Newton";

            bancoDePreguntas[2].preguntas[3].enunciadoDeLaPregunta = "¿Bajo qué cultura se nombraban las constelaciones?";
            bancoDePreguntas[2].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Mesopotámica";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Grecolatina";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Azteca";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Maya";

            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "¿Cuál es considerado el primer observatorio espacial?";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "James Webb";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Estación Espacial Internacional";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Cosmos 215";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Telescopio Espacial Hubble";

            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";

            bancoDePreguntas[3].preguntas[0].enunciadoDeLaPregunta = "¿Cómo se llama el agujero negro que se encuentra en el centro de la Vía Láctea?";
            bancoDePreguntas[3].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Messier 87";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Hércules A";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Cygnus A";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Sagitario A";

            bancoDePreguntas[3].preguntas[1].enunciadoDeLaPregunta = "Materia hipotética que no interactúa con campos electromagnéticos";
            bancoDePreguntas[3].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Materia gris";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Materia negra";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Gravedad";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Magnetismo molecular";

            bancoDePreguntas[3].preguntas[2].enunciadoDeLaPregunta = "Concentración de flujo gaseoso que se eleva desde la fotósfera solar hasta la cromósfera";
            bancoDePreguntas[3].preguntas[2].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Espícula";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Llamarada solar";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Corona";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Prominencia solar";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "Si se pasa este límite en un agujero negro, nada puede salir del mismo";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Disco de acreción";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Agujero de gusano";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Singularidad";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Horizonte de sucesos";

            bancoDePreguntas[3].preguntas[4].enunciadoDeLaPregunta = "¿Cuánto es aproximadamente la velocidad de la luz en el vacío?";
            bancoDePreguntas[3].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "3·10⁸ m/s";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2·10⁸ m/s";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "343 m/s";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "9.8·10⁸ m/s";


            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";

            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "¿Cómo se llama la colisión de dos estrellas de neutrones?";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Supernova";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Hypernova";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Kilonova";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Quásares";

            bancoDePreguntas[4].preguntas[1].enunciadoDeLaPregunta = "¿Cuál es la estrella más grande en cuanto a diámetro que se conoce?";
            bancoDePreguntas[4].preguntas[1].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Betelgueuse";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "UY Scuti";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "R136a1";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Stephenson 2-18";

            bancoDePreguntas[4].preguntas[2].enunciadoDeLaPregunta = "Teoría que asume que las partículas on estados vibracionales de un filamento.";
            bancoDePreguntas[4].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Mecánica cuántica";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Teoría de las cuerdas";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Teoría de la relatividad";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Teoría de Fermi";

            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "¿Qué tipo de estrella tiene un mayor tiempo de vida?";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Enana roja";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Supergigantes";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Gigante roja";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Enana marrón";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "Si la masa inicial de una estrella es de 8 a 20 masas solares, cuando muere se convierte en...";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Un agujero negro";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Una estrella de neutrones";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Una gigante roja";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Una enana blanca";


        }
    }
}
