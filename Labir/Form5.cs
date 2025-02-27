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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private bool Per()
        {
            if (bird.Bounds.IntersectsWith(bottom.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox5.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox7.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox8.Bounds) ||
                bird.Bounds.IntersectsWith(pictureBox9.Bounds) ||
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
                bird.Bounds.IntersectsWith(pictureBox22.Bounds)||
                bird.Bounds.IntersectsWith(pictureBox23.Bounds)) return true;
            else return false;
        }
        int num = 1;
        private void hod(char nap)
        {
            if (nap == 'r')
            {
                if (num == 1) { bird.Image = Properties.Resources.D2; num = 2; }
                else if (num == 2) { bird.Image = Properties.Resources._1672267655_kalix_club_p_utka_piksel_art_instagram_1; num = 1; }
            }
            if (nap == 'l')
            {
                if (num == 1) { bird.Image = Properties.Resources.A1; num = 2; }
                else if (num == 2) { bird.Image = Properties.Resources.A2; num = 1; }
            }
        }
        private void Peres(int a, char s)
        {
            if (s == 'h') { bird.Top += a / 10; }
            else { bird.Left += a / 10; }
            if (Per())
            {
                if (s == 'h') { bird.Top -= a / 5; }
                else { bird.Left -= a / 5; }
                return;
            }
            else
            {
                if (s == 'h') { bird.Top += a - 1; }
                else { bird.Left += a - 1; }
            }
            if (Per())
            {
                a = a / 10;
            }
            while (Per() && (a != 0))
            {
                if (s == 'h') { bird.Top -= a; }
                else { bird.Left -= a; }
            }
            return;
        }
        int p = 0;
        char s;
        
        private void Batt()
        {
            if (bird.Bounds.IntersectsWith(buttom.Bounds)) {
                buttom.Image = Properties.Resources.зелёная_кнопка;
                buttom2.Image = Properties.Resources.красная_кнопка;
                s = 'o';
               timer1.Start(); 
            }
            if (bird.Bounds.IntersectsWith(buttom2.Bounds))
            {
                buttom2.Image = Properties.Resources.зелёная_кнопка;
                buttom.Image = Properties.Resources.красная_кнопка;
                s = 'c';
                timer1.Start();
            }
        }
        private void Key()
        {
            if (bird.Bounds.IntersectsWith(picturekey.Bounds))
            {
                ScoreText.Text = "X 1";
                picturekey.Hide();
                p = 1;
            }
        }

        private void Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) { Peres(-10, 'h'); }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) { Peres(10, 'h'); }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) { Peres(-10, 'l'); hod('l'); }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) { Peres(10, 'l'); hod('r'); }
            Key(); Batt();
            if (bird.Bounds.IntersectsWith(worota.Bounds) && p != 0 || e.KeyCode == Keys.V)
            {
                Bank.Sost = "2";
                Form f = new Form4();
                f.Show(); Close();
            };
        }

        int m=1,n=1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s=='o') 
            {
                if (bottom.Top >= 151) n = 0; else n = 1;
                if (pictureBox23.Left >= 597) m = 0; else m = 2;
                pictureBox23.Left+=m; 
                bottom.Top+=n; 
                if (bottom.Top >= 151&& pictureBox23.Left>=597) timer1.Stop();
            }
            if (s=='c') 
            {
                if (bottom.Top <=79) n = 0; else n = -1;
                if (pictureBox23.Left <=413) m = 0; else m = -2;
                pictureBox23.Left += m;
                bottom.Top += n;
                if (bottom.Top <= 79 && pictureBox23.Left <= 413) timer1.Stop();
            }
        }
    }
}
