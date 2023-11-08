namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRadio_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // definir objeto
            Circulo Objeto = new Circulo();

            Objeto.Radio = Convert.ToSingle(txtRadio.Text);
            this.txtArea.Text = Objeto.Area().ToString("F2");
           // this.txtLongitud.Text = Objeto.Longitud().ToString();

        }
    }
}