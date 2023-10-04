namespace EJEMPLO_MOANSO
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtR.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N1, N2, R;
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            R = N1 + N2;
            txtR.Text = R.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
