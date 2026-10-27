
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Car_game
{
    public partial class Form1 : Form
    {
        private bool gameStarted = false;
        private int speed = 10;

        public Form1()
        {
            InitializeComponent();

            pictureCar.Image = CreateCarImage();
            pictureCar.BringToFront();

            timer1.Interval = 30;
            timer1.Stop();
        }

        private Bitmap CreateCarImage()
        {
            Bitmap bmp = new Bitmap(65, 90);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Tekərlər
                using (SolidBrush black = new SolidBrush(Color.Black))
                {
                    g.FillRectangle(black, 2, 18, 12, 23);
                    g.FillRectangle(black, 51, 18, 12, 23);
                    g.FillRectangle(black, 2, 55, 12, 23);
                    g.FillRectangle(black, 51, 55, 12, 23);
                }

                // Masinin govdesi
                using (SolidBrush blue =
                    new SolidBrush(Color.DodgerBlue))
                {
                    g.FillRectangle(blue, 11, 8, 43, 74);
                    g.FillEllipse(blue, 11, 3, 43, 25);
                    g.FillEllipse(blue, 11, 65, 43, 22);
                }

                // On ve arxa suseler
                using (SolidBrush glass =
                    new SolidBrush(Color.LightCyan))
                {
                    g.FillRectangle(glass, 19, 18, 27, 15);
                    g.FillRectangle(glass, 19, 57, 27, 13);
                }

                // Faralar
                using (SolidBrush yellow =
                    new SolidBrush(Color.Yellow))
                {
                    g.FillRectangle(yellow, 15, 5, 10, 5);
                    g.FillRectangle(yellow, 41, 5, 10, 5);
                }

                // Arxa isiq
                using (SolidBrush red =
                    new SolidBrush(Color.Red))
                {
                    g.FillRectangle(red, 15, 78, 10, 5);
                    g.FillRectangle(red, 41, 78, 10, 5);
                }
            }

            return bmp;
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            gameStarted = true;
            timer1.Start();
            this.ActiveControl = null;
        }

        private void btnBreak_Click(object? sender, EventArgs e)
        {
            gameStarted = false;
            timer1.Stop();
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnLeft_Click(object? sender, EventArgs e)
        {
            if (gameStarted)
                MoveCar(-speed, 0);
        }

        private void btnRight_Click(object? sender, EventArgs e)
        {
            if (gameStarted)
                MoveCar(speed, 0);
        }

        private void btnDown_Click(object? sender, EventArgs e)
        {
            if (gameStarted)
                MoveCar(0, speed);
        }

        protected override bool ProcessCmdKey(
            ref Message msg, Keys keyData)
        {
            if (gameStarted)
            {
                if (keyData == Keys.Left)
                {
                    MoveCar(-speed, 0);
                    return true;
                }

                if (keyData == Keys.Right)
                {
                    MoveCar(speed, 0);
                    return true;
                }

                if (keyData == Keys.Up)
                {
                    MoveCar(0, -speed);
                    return true;
                }

                if (keyData == Keys.Down)
                {
                    MoveCar(0, speed);
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MoveCar(int dx, int dy)
        {
            int maxX = roadPanel.ClientSize.Width - pictureCar.Width;
            int maxY = roadPanel.ClientSize.Height - pictureCar.Height;

            int x = pictureCar.Left + dx;
            int y = pictureCar.Top + dy;

            x = Math.Max(0, Math.Min(x, maxX));
            y = Math.Max(0, Math.Min(y, maxY));

            pictureCar.Location = new Point(x, y);
            pictureCar.BringToFront();
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            foreach (Control control in roadPanel.Controls)
            {
                if (control.Name.StartsWith("roadLine"))
                {
                    control.Top += 5;

                    if (control.Top >= roadPanel.ClientSize.Height)
                    {
                        control.Top = -control.Height;
                    }
                }
            }

            pictureCar.BringToFront();
        }
    }
}
