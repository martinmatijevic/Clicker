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
            if (bodova >= cijena)
            {
                koliko = koliko + 1;
                cijena = Convert.ToInt32(cijena * 1.15);
                MessageBox.Show(cijena + " " + koliko);
            }
            
        }

    }
}
