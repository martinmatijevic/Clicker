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
        public UserControl1 mis = new UserControl1();
        public bool misPokrenut = false;
        public UserControl1 gamepad = new UserControl1();
        public bool gamepadPokrenut = false;
        public UserControl1 robot = new UserControl1();
        public bool robotPokrenut = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mis.BringToFront();
            mis.ime = "Miš";
            mis.cijena = 10;
            mis.Dock = DockStyle.Top;
            splitContainer2.Panel1.Controls.Add(mis);
            //mis.Visible = false;
                        
            gamepad.BringToFront();
            gamepad.ime = "Gamepad";
            gamepad.cijena = 25;
            gamepad.Dock = DockStyle.Top;
            splitContainer2.Panel1.Controls.Add(gamepad);
            //gamepad.Visible = false;
                        
            robot.BringToFront();
            robot.ime = "Robot";
            robot.cijena = 50;
            robot.Dock = DockStyle.Top;
            splitContainer2.Panel1.Controls.Add(robot);
            //robot.Visible = false;

            DateTime localDate = DateTime.Now;
            textBox1.Text += string.Format("{0:HH:mm tt}", localDate) + " Igra pokrenuta!" + Environment.NewLine;
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
            mis.bodova = playerPoints;
            if (playerPoints >= 10 && !misPokrenut)
            {
                mis.Visible = true;
                misPokrenut = true;
            }
        }


    }
}
