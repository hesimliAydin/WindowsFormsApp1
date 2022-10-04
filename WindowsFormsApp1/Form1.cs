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
        Timer timer=new Timer();
        public Form1()
        {

            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            titleLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor=Color.DeepPink;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label=new Label();
            label.Text = "I am second Label";
            label.Font = new Font("Comic Sans MS", 32, FontStyle.Italic);
            label.Location = new Point(20, 200);
            label.ForeColor = Color.DeepPink;
            label.AutoSize = true;

            this.Controls.Add(label);
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            titleLbl.Text=DateTime.Now.ToLongDateString();
        }

        private void clickBtn_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
                bt.Dispose();

                Button button=new Button();
                button.Font=new Font("Microsoft Sans Serif",16,FontStyle.Bold);
                button.Text = "Click Me";
                button.BackColor = Color.IndianRed;
                button.AutoSize = true;
                button.MouseEnter += clickBtn_MouseEnter;

                Random random = new Random();
                int randomX = random.Next(50, this.Size.Width-100);
                int randomY = random.Next(50, this.Size.Height-100);
                button.Location=new Point(randomY, randomX);                                    

                this.Controls.Add(button);

            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X + "  " + e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X : {e.X}   Y : {e.Y}";

            if (e.X>=0&&e.X<=200)
            {
                this.BackColor = Color.Purple;
            }
            else if (e.X >= 200 && e.X <= 400)
            {
                this.BackColor= Color.Red;
            }
            else if (e.X>=400&&e.X<=600)
            {
                this.BackColor = Color.Plum;
            }
            else if (e.X>=600&& e.X<=800)
            {
                this.BackColor = Color.Yellow;
            }
            

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.SpringGreen;
            }
        }

        private void titleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            titleLbl.ForeColor = Color.Red;
        }

        private void titleLbl_MouseUp(object sender, MouseEventArgs e)
        {
            titleLbl.ForeColor = Color.Black;
        }

        private void titleLbl_MouseEnter(object sender, EventArgs e)
        {
            clickBtn.Text="you are me";
            clickBtn.ForeColor = Color.Red;
        }

        private void titleLbl_MouseLeave(object sender, EventArgs e)
        {
            clickBtn.Text = "click me";
            clickBtn.ForeColor= Color.Black;
        }


    }
}
