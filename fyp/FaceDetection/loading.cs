using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraCapture
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {


            tmr.Enabled = true;



            //starts the timer

            tmr.Start();
            //set time interval 3 sec

            tmr.Interval = 400;

            progressBar1.Maximum = 5;
            tmr.Tick += new EventHandler(tmr_Tick);
        
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 5)
            {
                progressBar1.Value++;
            }
            else
            {
                tmr.Stop();

                //display mainform

               FaceDetection mf = new FaceDetection();

                mf.Show();

                //hide this form

                this.Hide();
            }
           
        }
    }
}
