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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            var m = new Form6();
            m.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new Form2();
            m.Show();
            this.Close();
        }
    }
}
