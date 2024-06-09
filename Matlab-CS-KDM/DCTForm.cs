using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matlab_CS_KDM
{
    public partial class DCTForm : Form
    {
        private double treshold;
        private double blockSize;
        public DCTForm()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            treshold = (double)(trackBar1.Value / 1000.0);
            label1.Text = treshold.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatlabHandler matlabHandler = new MatlabHandler();
            matlabHandler.callDCTFunction(treshold,blockSize);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            blockSize = trackBar2.Value;
            label4.Text = blockSize.ToString();
        }
    }
}
