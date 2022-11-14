using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeObjectos
{
    public class Dificultad
    {
        public string nombreDeLaDificultad;
        public Pregunta[] preguntas;

        public Dificultad()
        {
            preguntas = new Pregunta[5];
        }
    }
}