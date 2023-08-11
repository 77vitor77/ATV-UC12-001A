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

            Correntistas correntistas = new Correntistas(Convert.ToInt32(txtID.Text), txtnome.Text, Convert.ToInt32(txtcpf.Text), Convert.ToDateTime(datadenascimento.Value), Convert.ToDouble(txtrendamensal.Text));




            TimeSpan idadetext = DateTime.Now - datadenascimento.Value;

            MessageBox.Show (Convert.ToString(idadetext));

            if (Convert.ToInt32(idadetext) <= 17)
            {

                MessageBox.Show("idade invalida para cadastro");

            }








            txtcpf.Clear();
            
            txtnome.Clear();
            txtrendamensal.Clear();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}