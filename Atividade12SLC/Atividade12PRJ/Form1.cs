using System.ComponentModel.Design.Serialization;

namespace Atividade12PRJ
{

    public partial class Form1 : Form
    {
        Correntistas correntistas1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {          

            Correntistas correntistas = new Correntistas( txtnome.Text, txtcpf.Text, Convert.ToDateTime(datadenascimento.Value), Convert.ToDouble(txtrendamensal.Text));

            if (correntistas.Ehmaior() == false)
            {

                MessageBox.Show("idade invalida para cadastro");


            }
            else if (0 > correntistas.RendaMensal)
            {

                MessageBox.Show("renda ivalida por ser negativa");

            }
            
            
            
            
            
            else
            {

                MessageBox.Show(correntistas.mensagendebemvindo());

            }

            txtcpf.Clear();
            txtnome.Clear();
            txtrendamensal.Clear();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}