using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chahmati_na_odnogo
{
    public partial class Form1 : Form
    {
        Point point1, UP, Right, Left, Down, Right_UP, Right_Down, Left_UP, Left_Down, Winn;
        Color color1, color2;
        int r1, r2, q;
        bool click = false;
        bool going = false;
        int[] mas1 = new int[3];
        int[] mas2 = new int[15];
        string str, r;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        bool b;
        bool tru;
        List<Color> rgb = new List<Color>();
        Color red = Color.DarkBlue;
        Color yel = Color.Yellow;
        Color oreg = Color.DarkOrange;
        public Button prevbut;

        public Form1()
        {
            InitializeComponent();
            panel27.BackColor = red;
            panel28.BackColor = yel;
            panel29.BackColor = oreg;
        }

        private void button3_MouseClick_1(object sender, MouseEventArgs e)
        {
            tru = false;
            if (prevbut != null)
            {
                color2 = prevbut.BackColor;
                
            }
            Button pressbut = (Button)sender;
            if (pressbut.BackColor == Color.White)
            {
                going = true;
                if (pressbut.Location == UP || pressbut.Location == Left || pressbut.Location == Right || pressbut.Location == Down || pressbut.Location == Right_UP || pressbut.Location == Right_Down || pressbut.Location == Left_UP || pressbut.Location == Left_Down) 
                    tru = true;
            }
            if (prevbut != null && pressbut.BackColor == Color.White&tru)
            {
                prevbut.BackColor = Color.White;
                pressbut.BackColor = color2;
                click = false;
                prevbut = null;
                pressbut = null;
            }
            if (!going)
            {
                click = true;
                point1 = pressbut.Location;
                prevbut = pressbut;
                coordinate();


            }
            going = false;
            if (button3.BackColor == panel27.BackColor&& button4.BackColor == panel27.BackColor&& button5.BackColor == panel27.BackColor && button6.BackColor == panel27.BackColor && button7.BackColor == panel27.BackColor &&button3.BackColor == panel27.BackColor&& button4.BackColor == panel27.BackColor&& button5.BackColor == panel27.BackColor && button6.BackColor == panel27.BackColor && button7.BackColor == panel27.BackColor && button13.BackColor == panel28.BackColor && button14.BackColor == panel28.BackColor && button15.BackColor == panel28.BackColor && button16.BackColor == panel28.BackColor && button17.BackColor == panel28.BackColor && button23.BackColor == panel29.BackColor&& button24.BackColor == panel29.BackColor&& button25.BackColor == panel29.BackColor && button26.BackColor == panel29.BackColor && button27.BackColor == panel29.BackColor) 
                MessageBox.Show("Вы решили головоломку :)");
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            rasbros1();
            rasbros2();
        }
        void rasbros1()
        {
            rgb.Add(red);
            rgb.Add(yel);
            rgb.Add(oreg);
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            for (int i = 0; i < 3;)
            {
                b = false;
                r1 = rnd1.Next(0, 3);
                r = r1.ToString();
                for (int h = 0; h < i; h++)
                {
                    if (mas1[h] == r1)
                    {
                        b = true;
                    }
                }
                if (!b)
                {
                    mas1[i] = r1;
                    switch (i)
                    {
                        case 0:
                            panel27.BackColor = rgb[mas1[i]];
                            break;
                        case 1:
                            panel28.BackColor = rgb[mas1[i]];
                            break;
                        case 2:
                            panel29.BackColor = rgb[mas1[i]];
                            break;
                    }
                    i++;
                }
            }
        }
        void rasbros2()
        {
            int draw;
            int r = 0;
            int y = 0;
            int o = 0;
            bool red = false; bool yel = false; bool oran = false;
            Random rnd = new Random();
            List<int> mas = new List<int>() { 1, 2, 3 };
            int[] mas1 = new int[15];
            for (int i = 0; i < 15;)
            {
                draw = rnd.Next(0, 3);
                if (draw == 0 & !red)
                {
                    r++;
                    mas1[i] = draw;
                    i++;
                }
                if (draw == 1 & !yel)
                {
                    y++;
                    mas1[i] = draw;
                    i++;
                }
                if (draw == 2 & !oran)
                {
                    o++;
                    mas1[i] = draw;
                    i++;
                }
                // -----------------------------------------------------------
                if (r == 5 & !red)
                {
                    red = true;
                    mas.Clear();
                    mas.Add(2);
                    mas.Add(3);
                }
                if (y == 5 & !yel)
                {
                    yel = true;
                    mas.Clear();
                    mas.Add(1);
                    mas.Add(3);
                }
                if (o == 5 & !oran)
                {
                    oran = true;
                    mas.Clear();
                    mas.Add(1);
                    mas.Add(2);
                }
            }
            button3.BackColor = rgb[mas1[0]];
            button4.BackColor = rgb[mas1[1]];
            button5.BackColor = rgb[mas1[2]];
            button6.BackColor = rgb[mas1[3]];
            button7.BackColor = rgb[mas1[4]];
            button15.BackColor = rgb[mas1[5]];
            button16.BackColor = rgb[mas1[6]];
            button13.BackColor = rgb[mas1[7]];
            button14.BackColor = rgb[mas1[8]];
            button17.BackColor = rgb[mas1[9]];
            button23.BackColor = rgb[mas1[10]];
            button24.BackColor = rgb[mas1[11]];
            button25.BackColor = rgb[mas1[12]];
            button26.BackColor = rgb[mas1[13]];
            button27.BackColor = rgb[mas1[14]];
        }
        void coordinate()
        {
            Right = new Point(prevbut.Location.X + 50, prevbut.Location.Y);
            Left = new Point(prevbut.Location.X - 50, prevbut.Location.Y);
            UP = new Point(prevbut.Location.X, prevbut.Location.Y - 54);
            Down = new Point(prevbut.Location.X, prevbut.Location.Y + 54);
            Right_UP = new Point(prevbut.Location.X + 50, prevbut.Location.Y - 54);
            Right_Down = new Point(prevbut.Location.X + 50, prevbut.Location.Y + 54);
            Left_UP = new Point(prevbut.Location.X - 50, prevbut.Location.Y - 54);
            Left_Down = new Point(prevbut.Location.X - 50, prevbut.Location.Y + 54);
        }
    }
}
