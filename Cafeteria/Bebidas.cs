using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias.Cafeteria
{
    internal class Bebidas
    {
        protected string Nombre;
        protected float Precio;
        protected string Tamaño;

        public string nombre
        {
            get {  return Nombre; }
            set { Nombre = value; }
        }

        public string tamaño
        {
            get { return Tamaño; }
            set { Tamaño = value; }
        }

        public float precio
        {
            get { return Precio; }
            set
            {
                if (Precio > 0)
                {
                    Precio = value;
                }
                else
                {
                    Precio = -1;
                }
            }
        }

        //Constructor
        public Bebidas()
        {
            Precio = 0;
            Nombre = "";
            Tamaño = "";
        }
        //contructor parametrizado
        public Bebidas(string _nombre, string _tamaño, float _precio)
        {
            this.Nombre = _nombre;
            Precio=_precio;
            Tamaño = _tamaño;
        }
        //////////////
        //metodo preparar
        public virtual string Preparar()
        {
            return "Estamos preparando un : "+Nombre +" de tamaño "+Tamaño;
        }

        public void Descuento(float descuento)
        {
            Precio = Precio * (1 - (descuento / 100));
        }
    }
}
