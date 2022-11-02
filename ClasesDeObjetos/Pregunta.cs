using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeObjetos
{
    public class Pregunta
    {
        //Cadena de texto,
        public string enunciadoDeLaPregunta;

        //Un dato con [] significa que es un arreglo.
        //Respuesta[]= Arreglo de Respuesta.
        public Respuesta[] respuestasDeLaPregunta;

        // 003
        //Valor de la respuesta correcta.
        public int respuestaCorrecta;

        public Pregunta()
        {
            respuestasDeLaPregunta = new Respuesta[4];
        }
    }
}
