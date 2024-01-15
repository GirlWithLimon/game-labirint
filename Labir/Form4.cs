using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labir
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            if (Bank.Sost == "3") { button1.Hide(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {  var m = new Form2();
            m.Show();  
            this.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form m;
            
            if (Bank.Sost == "1") { m = new Form5(); m.Show(); this.Close();}
            if (Bank.Sost == "2") { m = new Form6(); m.Show(); this.Close(); }
            
        }
    }
}
