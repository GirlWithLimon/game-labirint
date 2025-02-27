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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int napravlenie2 = 10, napravlenie1=10,lp=0; char s1='l';
        private bool Per(PictureBox telo)
        {
            if (telo.Bounds.IntersectsWith(ground.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox5.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox7.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox8.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox9.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox10.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox11.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox12.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox14.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox15.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox16.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox17.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox18.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox19.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox20.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox21.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox22.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox23.Bounds) ||
                telo.Bounds.IntersectsWith(pictureBox24.Bounds)) return true;
            else return false;
        }
        private void Peres(int a, char s,PictureBox telo)
        {
            int b=0;
            if (s == 'h') { telo.Top += a / 10; }
            else { telo.Left += a / 10; }
            if (Per(telo))
            {
                if (s == 'h') { telo.Top -= a /5; }
                else { telo.Left -= a / 5; }
                return;
            }
            else
            {
                if (s == 'h') { telo.Top += a; }
                else { telo.Left += a; }
            }
            if (Per(telo))
            {
                b = 1;
                a = a / 10;
            }
            while (Per(telo))
            {
                if (s == 'h') { telo.Top -= a; }
                else { telo.Left -= a; }
            }
            if (b == 1)
            {
                if (telo == ticva2) napravlenie2 = -napravlenie2;
                if (telo == ticva)
                {
                    if (s1 == 'h')
                    {
                        if (napravlenie1 > 0) napravlenie1 = -napravlenie1;
                        else if (napravlenie1 < 0) { s1 = 'l'; if (lp == 1) napravlenie1 = -10; else napravlenie1 = 10;lp = 0; }
                    }
                    else if (s1 == 'l') {
                         if (napravlenie1 > 0) { lp = 1; s1 = 'h'; napravlenie1 = 10; }
                        else if(napravlenie1<0) {s1 = 'h';napravlenie1 = 10; }
                    }
                }
            }
            return;
        }
        int p = 0;
        char de;

        private void Batt(PictureBox telo)
        {
            if (telo.Bounds.IntersectsWith(buttom.Bounds))
            {
                buttom.Image = Properties.Resources.зелёная_кнопка;
                buttom2.Image = Properties.Resources.красная_кнопка;
                de = 'o';
                timer1.Start();
            }
            if (telo.Bounds.IntersectsWith(buttom2.Bounds))
            {
                buttom2.Image = Properties.Resources.зелёная_кнопка;
                buttom.Image = Properties.Resources.красная_кнопка;
                de = 'c';
                timer1.Start();
            }
        }
        private void Eat()
        {
          if(  bird.Bounds.IntersectsWith(ticva.Bounds) ||
               bird.Bounds.IntersectsWith(ticva2.Bounds))
            {
               
                Form m = new Form7();
                m.Show(); Close();
            }
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
        private void Key()
        {
            if (bird.Bounds.IntersectsWith(picturekey.Bounds))
            {
                ScoreText.Text = "X 1";
                picturekey.Hide();
                p = 1;
            }
        }
     
        int m = 1, n = 1;

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) { Peres(-10, 'h',bird); }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) { Peres(10, 'h', bird); }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) { Peres(-10, 'l', bird); hod('l'); }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) { Peres(10, 'l', bird); hod('r'); }
            Key(); Batt(bird); Eat();
            if (bird.Bounds.IntersectsWith(worota.Bounds) && p != 0 || e.KeyCode == Keys.V)
            {
                Bank.Sost = "3";
                Form m = new Form4();
                m.Show(); Close();
            };
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           Peres(napravlenie2, 'h', ticva2); Eat();
        }

        private void timerticov_Tick(object sender, EventArgs e)
        {
            Peres(napravlenie1, s1, ticva);
            Batt(ticva); Eat();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (de == 'o')
            {
                if(pictureBox21.Top<632) pictureBox21.Top++;
                if (pictureBox17.Left < 135) pictureBox17.Left++;
                if (pictureBox21.Top >=632 && pictureBox17.Left >= 135) timer1.Stop();
            }
            if (de == 'c')
            {
                if (pictureBox21.Top > 576) pictureBox21.Top--;
                if (pictureBox17.Left > 40) pictureBox17.Left--;
                if (pictureBox21.Top < 576 && pictureBox17.Left <= 40) timer1.Stop();
            }
        }
    }
}
