using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matlab_CS_KDM
{
    public partial class FIRForm : Form
    {

        private double n = 1;
        private double cutOff = 1;

        public FIRForm()
        {
            InitializeComponent();
            playCreated.Enabled = false;
            //label7.Text = Application.StartupPath;
        }

        private void filterOrderBar_Scroll(object sender, EventArgs e)
        {
            n = filterOrderBar.Value;
            label1.Text = n.ToString();
        }

        private void cutoffFreqBar_Scroll(object sender, EventArgs e)
        {
            cutOff = cutoffFreqBar.Value;
            label3.Text = cutOff.ToString() + "Hz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatlabHandler matlabHandler = new MatlabHandler();
            int done = matlabHandler.CallFirFunction(n, cutOff);
            if (done == 0) playCreated.Enabled = true;
        }

        private void playOriginal_Click(object sender, EventArgs e)
        {
            SoundPlayer originalSignal = new SoundPlayer(MainForm.selectedFilePath);
            originalSignal.Play();
        }

        private void playCreated_Click(object sender, EventArgs e)
        {
            var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SoundPlayer createdSignal = new SoundPlayer(currentDirectory + @"\sygnal_filtrowany.wav");
            createdSignal.Play();
        }
    }
}
