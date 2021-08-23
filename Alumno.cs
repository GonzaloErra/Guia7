using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia7
{
    class Alumno
    {
        public int NroRegistro { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int MateriasAprobadas { get; set; }
        public int MateriasRestantes { get; set; }
        public float Promedio { get; set; }

        public Alumno()
        {

        }
        public Alumno(int Registro, string nombre, string apellido, int materiasAprobadas, int materiasRestantes, float promedios)
        {
            NroRegistro = Registro;
            Nombre = nombre;
            Apellido = apellido;
            MateriasAprobadas = materiasAprobadas;
            MateriasRestantes = materiasRestantes;
            Promedio = promedios;
        }
        public override string ToString()
        {
            return string.Format(
               "{0}-{1}-{2}-{3}-{4}-{5}",
               NroRegistro,
               Nombre,
               Apellido,
               MateriasAprobadas,
               MateriasRestantes,
               Promedio
               );
        }
        public string ToCSV()
        {
            return string.Format("{0};{1};{2};{3}", Nombre,
               Apellido,
               MateriasAprobadas,
               MateriasRestantes,
               Promedio);
        }


        public void AprobarMaterias()
        {
            MateriasAprobadas++;
            MateriasRestantes--;
        }


    }
}
    
