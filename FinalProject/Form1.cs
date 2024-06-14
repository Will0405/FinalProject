using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 start = new Form2();
            start.Show();
            this.Hide();
        }

        private void closeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
