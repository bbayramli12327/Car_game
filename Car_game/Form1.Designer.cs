
namespace Car_game
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel roadPanel;
        private System.Windows.Forms.PictureBox pictureCar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            roadPanel = new System.Windows.Forms.Panel();
            pictureCar = new System.Windows.Forms.PictureBox();
            btnStart = new System.Windows.Forms.Button();
            btnBreak = new System.Windows.Forms.Button();
            btnLeft = new System.Windows.Forms.Button();
            btnRight = new System.Windows.Forms.Button();
            btnDown = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);

            ((System.ComponentModel.ISupportInitialize)pictureCar).BeginInit();
            roadPanel.SuspendLayout();
            SuspendLayout();

            // Form
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 620);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Car Game";
            BackColor = System.Drawing.Color.WhiteSmoke;
            KeyPreview = true;

            // Yol
            roadPanel.BackColor = System.Drawing.Color.DimGray;
            roadPanel.Location = new System.Drawing.Point(10, 10);
            roadPanel.Name = "roadPanel";
            roadPanel.Size = new System.Drawing.Size(300, 590);

            // Yolun ag xetleri
            for (int i = 0; i < 7; i++)
            {
                System.Windows.Forms.Panel line =
                    new System.Windows.Forms.Panel();

                line.Name = "roadLine" + i;
                line.BackColor = System.Drawing.Color.White;
                line.Size = new System.Drawing.Size(16, 60);
                line.Location =
                    new System.Drawing.Point(142, 15 + i * 85);

                roadPanel.Controls.Add(line);
            }

            // Masin
            pictureCar.BackColor = System.Drawing.Color.Transparent;
            pictureCar.Location = new System.Drawing.Point(115, 450);
            pictureCar.Name = "pictureCar";
            pictureCar.Size = new System.Drawing.Size(65, 90);
            pictureCar.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureCar.TabStop = false;

            // Start
            btnStart.Location = new System.Drawing.Point(385, 140);
            btnStart.Size = new System.Drawing.Size(120, 45);
            btnStart.Name = "btnStart";
            btnStart.Text = "Start";
            btnStart.Click +=
                new System.EventHandler(btnStart_Click);

            // Break
            btnBreak.Location = new System.Drawing.Point(385, 205);
            btnBreak.Size = new System.Drawing.Size(120, 45);
            btnBreak.Name = "btnBreak";
            btnBreak.Text = "Break";
            btnBreak.Click +=
                new System.EventHandler(btnBreak_Click);

            // Sol
            btnLeft.Location = new System.Drawing.Point(345, 320);
            btnLeft.Size = new System.Drawing.Size(85, 65);
            btnLeft.Name = "btnLeft";
            btnLeft.Text = "←";
            btnLeft.Font = new System.Drawing.Font("Arial", 25F);
            btnLeft.Click +=
                new System.EventHandler(btnLeft_Click);

            // Sag
            btnRight.Location = new System.Drawing.Point(470, 320);
            btnRight.Size = new System.Drawing.Size(85, 65);
            btnRight.Name = "btnRight";
            btnRight.Text = "→";
            btnRight.Font = new System.Drawing.Font("Arial", 25F);
            btnRight.Click +=
                new System.EventHandler(btnRight_Click);

            // Asagi
            btnDown.Location = new System.Drawing.Point(407, 405);
            btnDown.Size = new System.Drawing.Size(85, 65);
            btnDown.Name = "btnDown";
            btnDown.Text = "↓";
            btnDown.Font = new System.Drawing.Font("Arial", 25F);
            btnDown.Click +=
                new System.EventHandler(btnDown_Click);

            // Exit
            btnExit.Location = new System.Drawing.Point(385, 510);
            btnExit.Size = new System.Drawing.Size(120, 45);
            btnExit.Name = "btnExit";
            btnExit.Text = "Exit";
            btnExit.Click +=
                new System.EventHandler(btnExit_Click);

            // Timer
            timer1.Interval = 30;
            timer1.Tick +=
                new System.EventHandler(timer1_Tick);

            // Kontroller
            roadPanel.Controls.Add(pictureCar);

            Controls.Add(roadPanel);
            Controls.Add(btnStart);
            Controls.Add(btnBreak);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(btnDown);
            Controls.Add(btnExit);

            roadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureCar).EndInit();
            ResumeLayout(false);
        }
    }
}
