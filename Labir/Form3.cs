using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labir
{
    public partial class Form3 : Form
    {
       public Form3()
        {
            InitializeComponent();
        }
        private bool Per()
        {
            if (bird.Bounds.IntersectsWith(bottom.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox1.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox2.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox3.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox4.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox5.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox6.Bounds)  || 
                bird.Bounds.IntersectsWith(pictureBox7.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox8.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox9.Bounds)  ||
                bird.Bounds.IntersectsWith(pictureBox10.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox11.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox12.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox14.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox15.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox16.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox17.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox18.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox19.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox20.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox21.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox22.Bounds)) return true;
            else return false;
        }
        private void Peres(int a,char s) {
            if (s == 'h') { bird.Top += a/10; }
            else { bird.Left += a/10; }
            if (Per()){
                if (s == 'h') { bird.Top -= a / 5; }
                else { bird.Left -= a / 5; }
                return;
            }
            else {
                if (s == 'h') { bird.Top += a-1; }
                else { bird.Left += a-1; }
            }
            if (Per())
            {
             a = a/10;
            }
            while (Per()&&(a!=0))
            { 
                if (s == 'h') { bird.Top -= a; }
                else { bird.Left -= a; }
            }
            return;
        }
      
        int p=0;
       
       private void Key()
        {
            if (bird.Bounds.IntersectsWith(picturekey.Bounds)) 
            { ScoreText.Text = "X "+p.ToString(); 
            picturekey.Hide();
                p=1;
            }
        }

        private void Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) { Peres(-10,'h'); }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) { Peres(10, 'h'); }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) { Peres(-10, 'l'); }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) { Peres(10, 'l'); }
            Key();
            if (bird.Bounds.IntersectsWith(worota.Bounds)&&p!=0||e.KeyCode==Keys.V) {
                Bank.Sost = "1";
                Form m = new Form4();
                m.Show(); Close();
            }
        }

    }
}
