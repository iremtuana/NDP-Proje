using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korona_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formbutton_Click(object sender, EventArgs e)
        {
            hastaform ekle = new hastaform();
            ekle.ShowDialog();
        }

        private void hastabutton_Click(object sender, EventArgs e)
        {
            neyapmalı ekle = new neyapmalı();
            ekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ekleform ekle = new ekleform();
            ekle.ShowDialog();
        }
    }
}
