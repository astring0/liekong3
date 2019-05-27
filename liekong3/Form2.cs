using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace liekong3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int stage = 0;
        private void lineShape1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1111");
        }
        public static bool Delay(int delayTime)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Milliseconds;
                Application.DoEvents();
            }
            while (s < delayTime);
            return true;
        }
        private void move(OvalShape os,int startlo,int endlo,int y2)
        {
            if(startlo<endlo)
            {
                for (int i = startlo; i <= endlo+15; i = i + 30)
                {
                    os.Location = new System.Drawing.Point(i, y2);
                    Delay(100);
                }
            }
            else
            {
                for (int i = startlo; i >= endlo - 15; i = i - 30)
                {
                    os.Location = new System.Drawing.Point(i, y2);
                    Delay(100);
                }
            }
        }
        private void BSA1_Click(object sender, EventArgs e)
        {
            if (stage != 0)
                return;
            Z1.Visible = true;
            Z1.BackColor = Color.Red;
            move(Z1, 70, 598, 150);
            Z1.Visible = false;
            JBD2.BackColor = Color.Yellow;
            Delay(500);
            Z1.Visible = true;
            Z1.BackColor = Color.Blue;
            move(Z1, 598, 70, 284);
            Z1.Visible = false;
            FBD1.BackColor = Color.Yellow;
            stage++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stage != 1)
                return;
            JBD2.BackColor = Color.Green;
            Z1.Visible = true;
            Z1.BackColor = Color.Red;
            move(Z1, 598, 70, 150);
            Z1.Visible = false;
            FBD1.BackColor = Color.Green;
            button3.Enabled = true;
            stage++;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1 = train.Location.X;
            train.Location = new System.Drawing.Point(x1 + 4, train.Location.Y);
            if(x1 > 623) { timer1.Stop(); timer1.Enabled = false; }
            if (x1 > 60 && CHU1.BackColor != Color.Red)
            {
                
                CHU1.BackColor = Color.Red;
            }
            if (x1 > 187 && FBD1.BackColor != Color.Red)
            {
                FBD1.BackColor = Color.Red;
                Z1.BackColor = Color.Red;
                Z1.Visible = true;
                ovmoveright.Enabled = true;
            }
            if(x1 > 389 && jing2.BackColor != Color.White)
            {
                jing2.BackColor = Color.White;
                FBD2.BackColor = Color.Red;
                JBD2.BackColor = Color.Red;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            train.Location = new System.Drawing.Point(3, 62);
            
        }

        private void ovmoveright_Tick(object sender, EventArgs e)
        {
            int x1 = Z1.Location.X;
            Z1.Location = new System.Drawing.Point(x1 + 20, Z1.Location.Y);
            if (x1 > 598) {
                ovmoveright.Stop();
                ovmoveright.Enabled = false;
                Z1.Visible = false;
                JBD2.BackColor = Color.Red;
                jing2.BackColor = Color.Green;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FBD2.BackColor = Control.DefaultBackColor;
            JBD2.BackColor = Control.DefaultBackColor;
            Z1.Visible = true;
            Z1.BackColor = Color.Blue;
            move(Z1, 598, 70, 284);
            Z1.Visible = false;
            FBD1.BackColor = Control.DefaultBackColor;
            CHU1.BackColor = Control.DefaultBackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            FBD1.BackColor = Control.DefaultBackColor;
            CHU1.BackColor = Control.DefaultBackColor;
            Z1.Visible = true;
            Z1.BackColor = Color.Blue;
            move(Z1, 70, 598, 284);
            Z1.Visible = false;
            JBD2.BackColor = Control.DefaultBackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CHU1.BackColor = Color.Green;
            button1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (new Form3().ShowDialog(this) == DialogResult.Yes)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                FBD1.BackColor = Control.DefaultBackColor;
                CHU1.BackColor = Control.DefaultBackColor;
                Z1.Visible = true;
                Z1.BackColor = Color.Blue;
                move(Z1, 70, 598, 284);
                Z1.Visible = false;
                JBD2.BackColor = Control.DefaultBackColor;
            }
            else
            {
                MessageBox.Show("请破铅封！");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (new Form3().ShowDialog(this) == DialogResult.Yes)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                JBD2.BackColor = Control.DefaultBackColor;
                FBD2.BackColor = Control.DefaultBackColor;
                Z1.Visible = true;
                Z1.BackColor = Color.Blue;
                move(Z1, 598, 70, 284);
                Z1.Visible = false;
                FBD1.BackColor = Control.DefaultBackColor;
                CHU1.BackColor = Control.DefaultBackColor;
                
            }
            else
            {
                MessageBox.Show("请破铅封！");
            }
        }
    }
}
