using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias.Ejemplo1
{
    public class Materia
    {

        //Ambito de variables 
        //public -> lo puede ver cualquiera 
        //rotected -> explicacion pendiente para cuando toquemos herencia 
        //private-> solo se puede utilizar dentro de la clase contenedora 
        //definimos los atributos(variables) que vamos a utilizar
        private float parcial1;
        private float parcial2;
        private float parcial3;
        private string nombreMateria;

        //definimos las propiedades de nuestro ejemplo
        public float Parcial1
        {
            get { return parcial1; }
            set { if (value >= 0 && value <= 10)
                {
                    parcial1= value;
                }
                else
                {
                    parcial1 = -1;
                }
            }
        }

        public float Parcial2
        {
            get { return parcial2; }
            set
            {
                if(value>=0 && value <= 10)
                {
                    parcial2=value;
                }
                else
                {
                    parcial2 = -1;
                }
            }
        }

        public float Parcial3
        {
            get { return parcial3; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    parcial3 = value;
                }
                else
                {
                    parcial3 = -1;
                }
            }
        }

        public string NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }

        //definimos el/los metodos  utilizar en nuestro ejercicio
        public float CalculaPromedio()
        {
            float resultado = 0f;
            resultado = (parcial1 + parcial2 + parcial3) / 3;
            return resultado;
        }
    }
}
