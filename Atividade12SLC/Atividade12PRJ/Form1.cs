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
            try
            {

                lbldatadenascimento.Text = { }

            }
            catch (Exception)
            {

                throw;
            }



                Correntistas correntistas = new Correntistas(Convert.ToInt32(lblidmostrar.Text), txtnome.Text, Convert.ToInt32(txtcpf.Text), Convert.ToDateTime(txtdatadenascimento.Text), Convert.ToInt32(txtrendamensal));







                txtcpf.Clear();
                txtdatadenascimento.Clear();
                txtnome.Clear();
                txtrendamensal.Clear();

           
        }
    }
}