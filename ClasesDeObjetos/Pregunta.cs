using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeObjetos
{
    public class Pregunta
    {
        // cadena de texto
        public string enunciadoDeLaPregunta;

        // arreglo de respuesta
        public Respuesta[] respuestasDeLaPregunta;

        // 003
        public int respuestaCorrecta;

        public Pregunta()
        {
            respuestasDeLaPregunta = new Respuesta[4];
        }
    }
}
