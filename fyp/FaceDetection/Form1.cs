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
    public partial class Form1 : Form
    {
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            webBrowser1.ScriptErrorsSuppressed = true;


            webBrowser1.Navigate("https://www.express.com.pk/epaper/Index.aspx?Issue=NP_SUK");





        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            t++;

            if (t == 150)
            {
                webBrowser1.Document.Body.All[webBrowser1.Document.Body.All.Count - 1].ScrollIntoView(false);


            }
            else if (t == 300)
            {
                FaceDetection obj = new FaceDetection();
                obj.Show(); this.Hide();

            }
        }
    }
}
