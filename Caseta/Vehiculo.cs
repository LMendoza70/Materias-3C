using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias.Caseta
{
    internal class Vehiculo
    {
        protected string Placa;
        protected int Ejes;
        protected float Cuota;

        public string placa
        {
            get { return Placa; }
            set { Placa = value; }
        }

        public int ejes
        {
            get { return Ejes;}
            set { Ejes = value;}
        }

        public float cuota
        {
            get { return Cuota;}
            set
            {
                if (value <= 0)
                {
                    Cuota = 100;
                }
                else
                {
                    Cuota = value;
                }
            }
        }

        public Vehiculo()
        {
            Placa = "";
            Ejes = 0;
            Cuota = 0.0F;
        }

        public Vehiculo(string _placa, int _ejes, float _cuota)
        {
            Placa= _placa;
            Ejes= _ejes;
            Cuota= _cuota;
        }

        public virtual string PasoVehicular()
        {
            return "Vehiculo con placa : "+Placa +" Cruzando la caseta";
        }

        public float CalculoPeaje()
        {
            return Cuota * Ejes;
        }

    }
}
