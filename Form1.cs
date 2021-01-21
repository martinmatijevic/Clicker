using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        
        public int playerPoints = 0;
        public int upgrade = 0;
        public int timerCount = 0;

        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControl1 prvi = new UserControl1();
            prvi.BringToFront();
            prvi.ime = "marko";
            flowLayoutPanel1.Controls.Add(prvi);
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            playerPoints = 0;
            upgrade = 0;
            timerCount = 0;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerPoints += 1;
            label1.Text = playerPoints.ToString() + " points";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount += 1;
            playerPoints += upgrade;
            label1.Text = playerPoints.ToString() + " points";
        }

        
    }
}
