using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matlab_CS_KDM
{
    public partial class DCTForm : Form
    {
        private double treshold = 0.01;
        private double blockSize = 1;
        public DCTForm()
        {
            InitializeComponent();
            playCreated.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            treshold = (double)(trackBar1.Value / 1000.0);
            label1.Text = treshold.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatlabHandler matlabHandler = new MatlabHandler();
            int done = matlabHandler.CallDCTFunction(treshold, blockSize);
            if (done == 0) playCreated.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            blockSize = trackBar2.Value;
            label4.Text = blockSize.ToString();
        }

        private void playOriginal_Click(object sender, EventArgs e)
        {

            SoundPlayer originalSignal = new SoundPlayer(MainForm.selectedFilePath);
            originalSignal.Play();
        }

        private void playCreated_Click(object sender, EventArgs e)
        {
            var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SoundPlayer createdSignal = new SoundPlayer(currentDirectory + @"\sygnal_DCT.wav");
            createdSignal.Play();
        }
    }
}
