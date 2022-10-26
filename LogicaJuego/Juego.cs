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

            bancoDePreguntas[0].preguntas[0].enunciadoDeLaPregunta = "¿Cuando salio Apex?";
            bancoDePreguntas[0].preguntas[0].respuestaCorrecta = 2;
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "2017";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "2018";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "2019";
            bancoDePreguntas[0].preguntas[0].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "2020";

            bancoDePreguntas[0].preguntas[1].enunciadoDeLaPregunta = "¿Cual es un personaje que salio con el juego?";
            bancoDePreguntas[0].preguntas[1].respuestaCorrecta = 1;
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Octane";
            bancoDePreguntas[0].preguntas[1].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "wraith";
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
            bancoDePreguntas[1].preguntas[3].respuestaCorrecta = 3;
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

            bancoDePreguntas[2].preguntas[1].enunciadoDeLaPregunta = "¿Cual personaje es amigo/a  de Fuse?";
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

            bancoDePreguntas[2].preguntas[4].enunciadoDeLaPregunta = "¿Cual personaje habla español?";
            bancoDePreguntas[2].preguntas[4].respuestaCorrecta = 1;
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[0].EnunciadoDeLaRespuesta = "Horizon";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[1].EnunciadoDeLaRespuesta = "Octane";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[2].EnunciadoDeLaRespuesta = "Caustic";
            bancoDePreguntas[2].preguntas[4].respuestasDeLaPregunta[3].EnunciadoDeLaRespuesta = "Vanguard";
        }
    }
}
