﻿using System;
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
    public partial class UserControl1 : UserControl
    {
        private string mputanja = string.Empty;
        private string mime = string.Empty;
        private int mkoliko = 0;
        private int mcijena = 0;
        private int mbodova = 0;

        public string putanja
        {
            set { mputanja = value; }
        }
        public string ime
        {
            get { return mime; }
            set { mime = value; }
        }
        public int koliko
        {
            get { return mkoliko; }
            set { mkoliko = value; }
        }
        public int cijena
        {
            get { return mcijena; }
            set { mcijena = value; }
        }
        public int bodova
        {
            set { mbodova = value; }
        }

        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void kupljeno(object sender, EventArgs e)
        {
            if (Form1.playerPoints >= cijena)
            {
                Form1.playerPoints -= cijena;
                koliko += 1;
                cijena *= 2;
                label2.Text = "Količina: " + koliko.ToString();
                label3.Text = "Cijena: " + cijena.ToString();
                DateTime localDate = DateTime.Now;
                Form1.newText += string.Format("{0:HH:mm tt}", localDate) + ime + " kupljen!" + Environment.NewLine;
            }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            label1.Text = ime;
            label2.Text = "Količina: " + koliko.ToString();
            label3.Text = "Cijena: " + cijena.ToString();
        }
    }
}
