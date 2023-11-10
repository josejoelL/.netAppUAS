using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    private float aRadioInterno;
    internal class CilindroHueco : Cilindro
    {
        public CilindroHueco()
        {
            this.aRadioInterno = 0.0f;
        }
        public CilindroHueco(float pRadioInternopRadio, float pAltura,float pRadioInterno) base (){
            
    }
    public float RadioInterno
    {
        set { this.aRadioInterno = value; }
        get { return this.aRadioInterno; }
    }
    public override double Volumen()
    {
        return Math.PI * (Math.Pow(this.aRadio,2)-
        Math.Pow(this.aRadioInterno,2)) * this.aAltura;

    }
    public override double Longitud()
    {
        return 2 * math.PI * (Math.Pow(this.aRadio,2)- Math.Pow(this.aRadioInterno,2)) + 2 * Math.PI * this.aRadio * this.aAltura + 2 * Math.PI * this.aAltura * this.aRadioInterno
    }
}
