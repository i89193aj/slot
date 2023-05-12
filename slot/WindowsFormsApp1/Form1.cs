using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] p = new PictureBox[4];
        int t;
        int[] num = new int[4];


        private void Form1_Load(object sender, EventArgs e)
        {
            lb2.Text = "目前金額：";
            lb3.Text = "投注金額：";
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PicBtn.Image = new Bitmap("up.jpg");
            PicBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            p[1] = pic1;
            p[2] = pic2;
            p[3] = pic3;

            for (int i = 1; i <= p.GetUpperBound(0); i++)
            {
                p[i].Image = new Bitmap("0.jpg");
                p[i].SizeMode = PictureBoxSizeMode.Zoom;
            }

            timer1.Interval = 100;
            txt1.Text = "100";
            numqty.Maximum = 100000000;
        }

        private void PicBtn_Click(object sender, EventArgs e)
        {
            if (numqty.Value <= Convert.ToInt32(txt1.Text) && numqty.Value > 0 )
            {
                
                timer1.Enabled = true;
                txt1.Text = Convert.ToString(Convert.ToInt32(txt1.Text) - numqty.Value);
                numqty.Enabled = false;
                PicBtn.Image = new Bitmap("down.jpg");
                PicBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("金額不符");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            for (int i = 1; i <= p.GetUpperBound(0); i++)
            {
                num[i] = r.Next(0, 4);
                p[i].Image = new Bitmap(Convert.ToString(num[i]) + ".jpg");
            }
            t += 1;
            if (t == 20)
            {
                timer1.Enabled = false;
                numqty.Enabled = true;
                PicBtn.Enabled = true;
                if (num[1] == 0 && num[2] == 0 && num[3] == 0)
                {
                    txt1.Text = (Convert.ToInt32(txt1.Text) + (numqty.Value * 5)).ToString();
                    MessageBox.Show("恭喜你!獲得投注金額*5");
                }
                else if (num[1] == 1 && num[2] == 1 && num[3] == 1)
                {
                    txt1.Text = (Convert.ToInt32(txt1.Text) + (numqty.Value * 10)).ToString();
                    MessageBox.Show("恭喜你!獲得投注金額*10");
                }
                else if (num[1] == 2 && num[2] == 2 && num[3] == 2)
                {
                    txt1.Text = (Convert.ToInt32(txt1.Text) + (numqty.Value * 15)).ToString();
                    MessageBox.Show("恭喜你!獲得投注金額*15");
                }
                else if (num[1] == 3 && num[2] == 3 && num[3] == 3)
                {
                    txt1.Text = (Convert.ToInt32(txt1.Text) + (numqty.Value * 20)).ToString();
                    MessageBox.Show("恭喜你!獲得投注金額*20");
                }
                PicBtn.Image = new Bitmap("up.jpg");
                t = 0;
            }
        }
    } 
}
