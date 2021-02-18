using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOmework._18
{
    public partial class Form1 : Form
    {
        int x = 20, y=20, r=30;
        SolidBrush br = new SolidBrush(Color.Aqua);
        Timer timer = new Timer();
        bool down = true, up = false, draw = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            draw = true;
            splitContainer1.Panel1.Invalidate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            x = 20;
            y = 20;
            draw = false;
            splitContainer1.Panel1.Invalidate();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (draw)
            {
                Graphics g = e.Graphics;
                SolidBrush brush = new SolidBrush(Color.Aqua);
                g.FillEllipse(brush, x, y, r, r);
            }
        }

        private void Alive_Click(object sender, EventArgs e)
        {
            timer1.Start();
            splitContainer1.Panel1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(down)
            {
                x += 5;
                y += 5;
            }
            if ((y+30) >= splitContainer1.Panel1.Height)
            {
                up = true;
                down = false;
            }
            if((y)<=0)
            {
                up = false;
                down = true;
            }
            if (up)
                y -= 5;
            if ((x + 15) >= splitContainer1.Panel1.Width)
            {
                x = 0;
                y = 0;
                down = true;
            }
            splitContainer1.Panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
