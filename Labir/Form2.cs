using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labir
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form a = new Form3();
            a.Show();this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form a = Application.OpenForms[0];
            a.Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new Form5();
            a.Show(); this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form a = new Form6();
            a.Show(); this.Close();
        }
    }
}
