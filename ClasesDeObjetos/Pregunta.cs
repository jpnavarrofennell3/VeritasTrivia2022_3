using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeObjectos
{
    public class Pregunta
    {
        // cadena
        public string enunciadoDeLaPregunta;
        //arreglo
        public Respuesta[] respuestasDeLaPregunta;
        public int respuestaCorrecta;

        public Pregunta()
        {
            respuestasDeLaPregunta = new Respuesta[4];
        }
    }
}