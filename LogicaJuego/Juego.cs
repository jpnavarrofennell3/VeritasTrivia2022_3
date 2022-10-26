﻿using System;
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

            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿Cuál es la capital de Japón?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 0;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Tokio";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "San Jose";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Koala";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Surulandia";





            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿A qué ciudad se refiere la frase “todos los caminos llevan a Roma”?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Los Angeles";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "San Jose";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Roma";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ciudad de Panamá";

            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿En cual ciudad esta el canal de Panamá?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 3;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Kiev";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Berlín";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Londres";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ciudad de Panamá";

            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿En qué ciudad cayó el muro de Berlín?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "París";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Berlin";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "New York";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Carambola";






            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿En cuál ciudad se encuentra la torre Eiffel?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Ciudad de México";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Bogota";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "París";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Cartago";







            bancoDePreguntas[1].nombreDeLaDificultad = "Fácil";

            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Cuál de estas ciudades no es de estados unidos?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "San Francisco";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "New York";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Tokio";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Los Ángeles";


            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿En qué ciudad está basada Los Santos o la ciudad de GTA V?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Los Ángeles";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Pekín";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Mumbai";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ciudad de Panamá";



            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Cuál de estas ciudades es verdadera?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Zanahorio";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "New York";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Huevolandia";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "carambola";



            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Cuál de estas ciudades es la capital de Inglaterra?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 2;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Berlín";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Bogotá";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Londres";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Rio de janeiro";



            bancoDePreguntas[1].preguntas[1].enunciadoDeLaPregunta = "¿Cuál de estas ciudades está en Brasil?";
            bancoDePreguntas[1].preguntas[1].respuestaCorrecta = 0;
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Rio de janeiro";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Beijín";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Sapporo";
            bancoDePreguntas[1].preguntas[1].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Nagasaki";


            bancoDePreguntas[2].nombreDeLaDificultad = "Normal";


            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿En cuál de estas ciudades se supone que inicio el COVID-19?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Tokio";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Wuhan";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Houston";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Madrid";


            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿En cuál de estas ciudades callo una bomba nuclear en la segunda guerra mundial?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Sídney";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Budapest";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Valencia";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Hiroshima";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿Cuál de estas ciudades es conocida como la ciudad del amor o de la luz?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 2;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Heredia";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Denver";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "París";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Busan";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿En cuál de estas ciudades se encuentra Hollywood?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 3;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Atlanta";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Cancún";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Lyon";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Los Ángeles";

            bancoDePreguntas[2].preguntas[2].enunciadoDeLaPregunta = "¿En qué ciudad se dio el ataque a las torres gemelas o (9-11)?";
            bancoDePreguntas[2].preguntas[2].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "San Diego";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "New York";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Montreal";
            bancoDePreguntas[2].preguntas[2].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Zaragoza";


            bancoDePreguntas[3].nombreDeLaDificultad = "Difícil";




            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "¿Cuál es la capital del país nombrado en referencia a la línea del Ecuador?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 1;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Santa Clara";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Quito";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Pendragon";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Zaragoza";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "¿Cuál de estas ciudades está localizada a la par de las pirámides egipcias o a sus alrededores?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 3;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Santa Clara";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Dublín";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Motevideo";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Cairo";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "¿Cuál de estas ciudades fue conocida en el pasado como Constantinopla?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 0;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Estambul";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Roma";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Nigeria";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Atenas";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "Este es el nombre verdadero de una de estas ciudades, cual es ¿“El pueblo de Nuestra Señora La Reina de los Ángeles de Porciúncula”?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Medellín";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Bogotá";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Los Ángeles";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Santa Clara";

            bancoDePreguntas[3].preguntas[3].enunciadoDeLaPregunta = "¿Cuál de estas ciudades es donde se ubica la torre (ej. Torre de observación) más alta del mundo?";
            bancoDePreguntas[3].preguntas[3].respuestaCorrecta = 2;
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Palma de Málaga";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Berlín";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Tokio";
            bancoDePreguntas[3].preguntas[3].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Toronto";




            bancoDePreguntas[4].nombreDeLaDificultad = "Muy Difícil";


            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "¿Cuál es el nombre de la ciudad azteca llamada Tenochtitlan en tiempos modernos?";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Florencia";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Praga";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Laos";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Ciudad de México";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "¿Cuál de estas ciudades construyo el primer rascacielos en el mundo?";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Chicago";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "New York";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Tokio";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Beijín";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "De entre estas ciudades ¿Cual es considerada la ciudad de la música? ";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 3;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Barcelona";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "París";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Yakarta";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Viena";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "¿Cuál de estas ciudades logra reciclar la mayor parte de su agua eficientemente? ";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 0;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Las Vegas";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Cairo";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Jerusalén";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Madrid";

            bancoDePreguntas[4].preguntas[4].enunciadoDeLaPregunta = "¿Una de estas ciudades fue la capital del antiguo imperio chino y cerca de la misma se encontró el ejército de terracota, ¿Cuál es";
            bancoDePreguntas[4].preguntas[4].respuestaCorrecta = 2;
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Wuhan";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Seúl";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Xian";
            bancoDePreguntas[4].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Guangzhou";
        }
    }
}
