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

            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿Como se llama el anime cuyo personaje principal se llama ash ketchum ?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Overlord ";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = " My hero academia";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Pokémon ";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Death note ";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "¿Cuál es el nombre del personaje principal de Dragon ball?";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Krilin";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Gohan";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Goku";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Golu";

            bancoDePreguntas[0].preguntas[2].enunciadoDeLaPregunta = "¿Cuál es el nombre del anime cuya particularidad es el tiempo que dura haciendo cierta actividad?";
            bancoDePreguntas[0].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Yu-gi-oh!";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Inazuma eleven";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Pro evolution soccer";
            bancoDePreguntas[0].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Super campeones ";

            bancoDePreguntas[0].preguntas[3].enunciadoDeLaPregunta = "¿Cuál es el anime que es reconocido por que su personaje principal es un detective?";
            bancoDePreguntas[0].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Parasyte";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Detetive conan";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "kuruko no basket";
            bancoDePreguntas[0].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Golden time ";

            bancoDePreguntas[0].preguntas[4].enunciadoDeLaPregunta = "¿Cuál es el nombre del personaje principal de yu-gi-oh!? ";
            bancoDePreguntas[0].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Tristán Taylor";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Téa Gardner";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Yugi Muto";
            bancoDePreguntas[0].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = " Joey Wheeler ";

            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";

            bancoDePreguntas[1].preguntas[0].enunciadoDeLaPregunta = "¿De los siguientes personajes de anime ¿Cuál es el más reconocido del mundo en la actualidad?";
            bancoDePreguntas[1].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Rei Ayanami (Neon Genesis Evangelion) ";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Ligth Yagami (Death Note) ";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Alucard (Hellsing)";
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = " Goku (Dragon Ball)";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿En qué anime la fuente de poder de los personajes es por medio de su cosmos?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Darling in the Franxx ";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Caballeros del zodiaco";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Another";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Super campeones";

            bancoDePreguntas[1].preguntas[2].enunciadoDeLaPregunta = "¿Cómo se llama el personaje principal de super campeones?";
            bancoDePreguntas[1].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Steve Hyuga";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Tom Misaki";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Benji";
            bancoDePreguntas[1].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Oliver Atom";

            bancoDePreguntas[1].preguntas[3].enunciadoDeLaPregunta = "¿Cuál es el anime que representa los pecados capitales?";
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Jojo ́s Bizarre Adventure";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "The Seven Deadly Sins ";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Plastic Memories";
            bancoDePreguntas[1].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Orange";

            bancoDePreguntas[1].preguntas[4].enunciadoDeLaPregunta = "¿Cuál es el anime cuyo nombre de ciertos personajes tienen que ver con los signos del zodiaco?";
            bancoDePreguntas[1].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Dragon ball";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Darling in the Franxx";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Caballeros del zodiaco";
            bancoDePreguntas[1].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Haikyuu!!";

            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";

            bancoDePreguntas[2].preguntas[0].enunciadoDeLaPregunta = "¿Cuál es el anime más visto del mundo?";
            bancoDePreguntas[2].preguntas[0].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Dragon ball";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Shingeki no kyiojin";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Death Note";
            bancoDePreguntas[2].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "My Hero Academia";

            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "¿Cuál es el anime más popular del mundo?";
            bancoDePreguntas[2].preguntas[1].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Naruto";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "One piece";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Pokémon";
            bancoDePreguntas[2].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Dragon Ball";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿Cuál anime es considerado uno de los más influyentes para las personas ?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Berserker";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Hunter x Hunter";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Fullmetal Alchemist: Brotherhood";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Code Geas";

            bancoDePreguntas[2].preguntas[3].enunciadoDeLaPregunta = " ¿Cuál es el género más visto del anime?";
            bancoDePreguntas[2].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Shonen";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = " Romance";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Gore";
            bancoDePreguntas[2].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Comedia";


            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "De los siguientes animes ¿Cual está dentro del género shonen? ";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Plastic Memories";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Dragon Ball";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Golden time";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = " Your Name";

            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";

            bancoDePreguntas[3].preguntas[0].enunciadoDeLaPregunta = "De los siguientes animes ¿Cuál es el anime más longevo desde el lanzamiento se su primer capítulo?";
            bancoDePreguntas[3].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Hellsing";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Pokemon";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Sailor moon";
            bancoDePreguntas[3].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Super campeones";

            bancoDePreguntas[3].preguntas[1].enunciadoDeLaPregunta = "De los siguientes animes románticos, ¿Cuál es el más reconocido?";
            bancoDePreguntas[3].preguntas[1].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Kaguya-sama: love is war";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Golden time";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Violet Gareden";
            bancoDePreguntas[3].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "orange";

            bancoDePreguntas[3].preguntas[2].enunciadoDeLaPregunta = "¿Cuál anime uno de sus personajes principales tiene como apellido itadori?";
            bancoDePreguntas[3].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "One Piece";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Hunter x Hunter";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Jujutsu kaisen";
            bancoDePreguntas[3].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Plastic Memories";




            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "¿Cuál es el anime más famoso en búsquedas?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "One Piece";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "My Hero Academia";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Jujutsu kaisen";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Naruto";


            bancoDePreguntas[3].preguntas[4].enunciadoDeLaPregunta = "¿Cuál es el anime cuyo Final tuvo mucho revuelo en su audiencia?";
            bancoDePreguntas[3].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = " Dragón Ball";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Naruto";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "One Piece";
            bancoDePreguntas[3].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Super campeone";

            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";

            bancoDePreguntas[4].preguntas[0].enunciadoDeLaPregunta = "¿Cuántas categorías importantes de animes son? ";
            bancoDePreguntas[4].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "4";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "6";
            bancoDePreguntas[4].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "3";

            bancoDePreguntas[4].preguntas[1].enunciadoDeLaPregunta = " ¿En cuál anime el Komugi no logra salir derrotado por Meruem en el juego de gungi? ";
            bancoDePreguntas[4].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "One piece ";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Hunter x hunter";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Demon Slayer";
            bancoDePreguntas[4].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Naruto";

            bancoDePreguntas[4].preguntas[2].enunciadoDeLaPregunta = " ¿Cuál es el anime con mejor audiencia en la plataforma de Netflix? ";
            bancoDePreguntas[4].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Naruto ";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Baki";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Jojo ́s bizarre adventure";
            bancoDePreguntas[4].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Naruto";

            bancoDePreguntas[4].preguntas[3].enunciadoDeLaPregunta = "¿Cuál tiene como personaje principal al que al final es considerado como villano?";
            bancoDePreguntas[4].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Death note ";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = " My hero academia";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Golden time";
            bancoDePreguntas[4].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = " Seven Deadly sins ";


            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = " ¿Cuál es el anime cuya fuente de poder son diferentes técnicas usando espadas para derrotar enemigos? ";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Demon Slayer  ";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "One piece ";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Hunter x hunter ";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = " Jujutsu kaisen";
