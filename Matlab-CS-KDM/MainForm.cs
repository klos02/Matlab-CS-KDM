namespace Matlab_CS_KDM
{
    public partial class MainForm : Form
    {

        public static string? selectedFilePath;

        public MainForm()
        {
            InitializeComponent();
            DisableControls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisableControls()
        {

            foreach (Control control in this.Controls)
            {
                if (control != button2)
                {
                    control.Enabled = false;
                }
            }
        }

        private void EnableControls()
        {

            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DCTForm dct = new DCTForm();
            dct.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik";
            openFileDialog.Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog.FileName;
                string filename = openFileDialog.SafeFileName;
                selectedFilePath = filePath;
                label2.Text = filename;
                EnableControls();



            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void filtracjaLiniowaButton_Click(object sender, EventArgs e)
        {
            FIRForm firForm = new FIRForm();
            firForm.Show();

        }
    }
}
