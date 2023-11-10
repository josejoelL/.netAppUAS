using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace Figuras_Geometricas
{
	internal class Cilindro : Circulo
	{

		//atributos
		protected float aAltura;
		public Cilindro()// por defecto
		{
			this.aAltura = 0.0f;
		}
		public Cilindro(float pRadio,float pAltura) : base(pRadio)   // parametrizado
		{
			this.aAltura = pAltura;
		}
		public float Altura
		{
			get { return this.aAltura; }
			set { this.aAltura = value; }
		}
		//metodos 

		public virtual double Volumen()
		{
			
		}
		public override override double Area() //checha si es correcto el virtual
		{
			return 0;
		}
	}
}
