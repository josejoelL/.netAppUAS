using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    internal class Circulo {

        //atributos
        protected float aRadio;
        public Circulo()// por defecto
        {
            this.aRadio = 0.0f;
        }
        public Circulo(float aRadio)// parametrizado
        {
            this.aRadio = aRadio;
        }
        public float Radio {
         get { return this.aRadio; }
        set { this.aRadio = value; }
        }
        //metodos 

        public virtual double Area()
        {
            const float PI = 3.1416F;
            return PI * (this.aRadio * this.aRadio);
        }
        public virtual double Longitud()
        {
           
            return 2 * Math.PI *  this.aRadio;
        }

    }
    }
