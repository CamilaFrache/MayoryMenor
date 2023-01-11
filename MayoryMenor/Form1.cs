namespace MayoryMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(textBox1.Text);
            int numero2 = Int32.Parse(textBox2.Text);
            int numero3 = Int32.Parse(textBox3.Text);

            int mayor = numero1;

            if (numero2 > numero1)
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor = numero3;
            }

            MessageBox.Show("El numero mas grande es " + mayor);

            int menor = numero1;
           
            
            if (numero2 < numero1)
            {
                menor = numero2;
            }

            if (numero3 < menor)
            {
                menor = numero3;
            }

            MessageBox.Show("El numero mas chico es " + menor);

        }
    }
}