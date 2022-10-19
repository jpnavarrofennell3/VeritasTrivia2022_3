using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeObjetos
{
    public class Pregunta
    {
        public string enunciadoDeLaPregunta;
        public Respuesta[] respuestasDeLaPregunta;
        public int respuestaCorrecta;

        public Pregunta()
        {
            respuestasDeLaPregunta = new Respuesta[4];
        }
    }
}
