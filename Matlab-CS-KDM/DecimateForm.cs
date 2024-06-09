using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matlab_CS_KDM
{
    public partial class DecimateForm : Form
    {
        private double order = 1;
        private double cutOff = 1;
        private double newSampling = 100;
        public DecimateForm()
        {
            InitializeComponent();
            playCreated.Enabled = false;
            decimatedSignalPlayButton.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            cutOff = trackBar1.Value;
            label1.Text = cutOff.ToString() + "Hz";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            order = trackBar2.Value;
            label4.Text = order.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Value = (int)Math.Round(trackBar3.Value / 100.0) * 100;
            newSampling = trackBar3.Value;
            label5.Text = newSampling.ToString() + "Hz";
        }

        private void playOriginal_Click(object sender, EventArgs e)
        {
            SoundPlayer originalSignal = new SoundPlayer(MainForm.selectedFilePath);
            originalSignal.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatlabHandler matlabHandler = new MatlabHandler();
            int done = matlabHandler.CallDecimateFunction(order, cutOff, newSampling);
            if (done == 0)
            {
                playCreated.Enabled = true;
                decimatedSignalPlayButton.Enabled = true;
            }
        }

        private void playCreated_Click(object sender, EventArgs e)
        {
            var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SoundPlayer createdSignal = new SoundPlayer(currentDirectory + @"\przefiltrowany_butter.wav");
            createdSignal.Play();
        }

        private void decimatedSignalPlayButton_Click(object sender, EventArgs e)
        {
            var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SoundPlayer decimatedSignal = new SoundPlayer(currentDirectory + @"\decymowany.wav");
            decimatedSignal.Play();
        }

        private void DecimateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
