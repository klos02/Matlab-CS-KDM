namespace Matlab_CS_KDM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DCTForm dct = new DCTForm();
            dct.Show();
        }
    }
}
