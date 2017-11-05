using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
 
    public partial class Form1 : Form
    {
        double gravity = 0.05;
        double vspeed = 0;
        double hspeed = 0;
        double posx;
        double posy;
        double maxhor = 4;
        double maxver = 5;
        double xinc = 0.2;
        double horinc = 0.2;
        double wid = 32;
        Random aaa = new Random();
        double mrd = 3;
        double enemymax=4.5;
        double enemymin = 0.7;
        double health = 50;
        double pax = 0.5;
        double bpax = 2;
        double bossy;
        double bossysp;
        double bullysp;
        double bullgrav = 1;
        double bully;
        int mode = 0;
        int enemax = 6;
        PictureBox[] enemy = new PictureBox[10];
        double[] esp = new double[10];
        double[] elx = new double[10];

        private void make_enemy(int ii)
        {
            double o;
            o = (aaa.NextDouble() * mrd) - mrd/2; 
            elx[ii]-=esp[ii];
            esp[ii] += o;
            esp[ii] = -esp[ii];
            if (esp[ii] > enemymax) esp[ii] = enemymax;
            if (esp[ii] < -enemymax) esp[ii] = -enemymax;
            if ((esp[ii] > -enemymin) && (esp[ii]<0)) esp[ii] = -enemymin;
            if ((esp[ii] < enemymin) && (esp[ii]>0)) esp[ii] = enemymin;
          ;
        }
        public Form1()
        {
            InitializeComponent();
            enemy[1] = enemy1;
            enemy[2] = enemy2;
            enemy[3] = enemy3;
            enemy[4] = enemy4;
            enemy[5] = enemy5;
            enemy[6] = boss;
            bossy = boss.Location.Y;
            mode = 0;
            bullet.Visible = false;
            for (int i = 1; i <= enemax; i += 1)
            {
                esp[i] = 3.5;
                elx[i] = enemy[i].Location.X;
               make_enemy(i);
            }
            health = 50;
            time.Value = time.Maximum;
             MessageBox.Show(
                 "Игра «Убей Босса v1.2»!!  Создатель – Клименко Алексей, 503-09!!\n\nВы – Зелёный квадрат. Управление влево-вправо – 4 - 6 на цифровой клавиатуре. Для движения удерживать кнопку не обязательно.\n\nПрыжок – 8. Стрелять – 5.\n\nОстерегайтесь врагов – синих квадратов! Они будут отнимать жизнь. Жизнь указана в верхней полосе. Если она кончится – вы проиграли!\n\nВаша цель – сбить Босса – голубого квадратика. Стреляйте по нему красными квадратами, когда пролетаете над ним. Это увеличит вашу жизнь. Заполните полоску жизни до конца и победите!\n\nВремя игры ограничено. Если нижняя полоса истечёт, то это будет ваше поражение!\n"
                 );
             step.Enabled = true;
             bosser.Enabled = true;
             timer.Enabled = true;
             this.Text="Управление: 4,6,8,5 -- цифровая клавиатура!";
        }
        private void step_Tick(object sender, EventArgs e)
        {
            if (player.Location.Y < down.Location.Y)
            {
                vspeed += gravity;
            }
            else
            {
                if (vspeed > 0)
                {
                    vspeed = 0;
                    posy = down.Location.Y;
                    posx = player.Location.X;
                }
            }
            hspeed = Math.Max(-maxhor, Math.Min(maxhor, hspeed + horinc));
            if ((posx < left.Location.X) ||
                (posx > right.Location.X))
            {
                hspeed = -hspeed;
                horinc = -horinc;
            }
            posy += vspeed;
            posx += hspeed;
            player.Location = new Point((int)posx, (int)posy);
            keyer.Focus();
            for (int i = 1; i <= enemax; i += 1)
            { 
                if ((enemy[i].Location.X<left.Location.X)||
                    (enemy[i].Location.X > right.Location.X))
                {
                    make_enemy(i);
                }
                elx[i] += esp[i];
                enemy[i].Location = new Point((int)elx[i], enemy[i].Location.Y);
            }
            for (int i = 1; i <= enemax; i += 1)
            {
                if ((player.Location.X < wid+enemy[i].Location.X) &&
                    (player.Location.X > -wid+enemy[i].Location.X) &&
                    (player.Location.Y < wid+enemy[i].Location.Y) &&
                    (player.Location.Y > -wid+enemy[i].Location.Y))
                {
                    health -= pax;
                    if (health >= 0)
                    {
                        life.Value = (int)health;
                    }
                    else
                    {
                        life.Value = 0;
                        health = 0;
                        step.Enabled = false;
                        bosser.Enabled = false;
                        timer.Enabled = false;
                        MessageBox.Show("Вы проиграли! Армия Босса сразила вас.");
                        step.Enabled = true;
                        bosser.Enabled = true;
                        timer.Enabled = true;
                        health = 50;
                        time.Value = time.Maximum;
                    }
                }
            }
            bossy += (bossysp - bossy) / 40;
            boss.Location = new Point(boss.Location.X, (int) bossy);
            if (mode == 1)
            {
                for (int i = 1; i <= enemax; i += 1)
                {
                    if ((bullet.Location.X < wid + enemy[i].Location.X) &&
                      (bullet.Location.X > -wid + enemy[i].Location.X) &&
                      (bullet.Location.Y < wid + enemy[i].Location.Y) &&
                      (bullet.Location.Y > -wid + enemy[i].Location.Y))
                    {
                        if (enemy[i] == boss)
                        {
                            health += bpax;
                            if (health <= 100)
                            {
                                life.Value = (int)health;
                            }
                            else
                            {
                                life.Value = 100;
                                health = 100;
                                step.Enabled = false;
                                bosser.Enabled = false;
                                timer.Enabled = false;
                                MessageBox.Show("Вы победили! Босс повержен.");
                                step.Enabled = true;
                                bosser.Enabled = true;
                                timer.Enabled = true;
                                health = 50;
                                time.Value = time.Maximum;
                            }
                        }
                        else
                        {
                      mode = 0;
                        bullet.Visible = false;
                        }
                    }
                }
                bullysp += bullgrav;
                bully += bullysp;
                bullet.Location = new Point(bullet.Location.X, (int)bully);
                if (bully > down.Location.Y)
                {
                    mode = 0;
                    bullet.Visible = false;
                }
            }
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
                posx = player.Location.X;
                posy = player.Location.Y;
        }
         
        private void keyer_KeyDown(object sender, KeyEventArgs e)
        {
           switch (e.KeyData)
            {
       case Keys.NumPad8:
                if (player.Location.Y >= down.Location.Y - 2)
                {vspeed = -maxver;} 
                ; break;
       case Keys.NumPad4:
           horinc = -xinc;
           ; break;
       case Keys.NumPad6:
           horinc = +xinc;
           ; break;
       case Keys.NumPad5:
           if (mode == 0)
           {
               mode = 1;
               bullet.Location = player.Location;
               bully = bullet.Location.Y;
               bullysp = 0;
               bullet.Visible = true;
           }
           ; break;
            }
        }
        private void bosser_Tick(object sender, EventArgs e)
        {
            bossysp = up.Location.Y + aaa.NextDouble() * (down.Location.Y - up.Location.Y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Value -= 1;
            if (time.Value <= 0)
            {
                step.Enabled = false;
                bosser.Enabled = false;
                timer.Enabled = false;
                MessageBox.Show("Вы проиграли! Закончилось время");
                step.Enabled = true;
                bosser.Enabled = true;
                timer.Enabled = true;
                health = 50;
                time.Value = time.Maximum;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            step.Enabled = false;
            bosser.Enabled = false;
            timer.Enabled = false;
            MessageBox.Show("Вам понравилось?");
        }
    }
}
