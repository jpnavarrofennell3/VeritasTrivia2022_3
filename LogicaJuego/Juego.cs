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
            bancoDePreguntas[1].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = " Goku (Dragon Ball)  ";
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
            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";
            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";
            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";
        }
    }
}
