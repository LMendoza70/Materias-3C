using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Materias.Cafeteria
{
    internal class BebidaCaliente:Bebidas
    {
        //atributos
        private float Temperatura;

        //propiedades
        public float tempetarura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }

        public BebidaCaliente(string _nombre,string _tamaño, float _precio, float _temperatura):base(_nombre,_tamaño,_precio)
        {
            Temperatura= _temperatura;
        }

        public override string Preparar()
        {
            return "Preparando un : "+Nombre+ " de  tamaño : "+Tamaño+" con temperatura "+Temperatura;
        }
    }
}
