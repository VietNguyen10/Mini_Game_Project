using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cannon_Game
{
    public partial class Form1 : Form
    {
        bool tilt_up, tilt_down;
        Image CannonImage = Properties.Resources.Cannon2;
        Image CannonBall = Properties.Resources.CannonBall;
        PictureBox cannonBallPictureBox;
        float rotationAngle = 0.5f;
        int gravity = 5;
        int cannon_ball_speed = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerEvent_Move(object sender, EventArgs e)
        {   
            if(cannonBallPictureBox != null)
            {
                cannonBallPictureBox.Top += gravity;
                cannonBallPictureBox.Left += cannon_ball_speed;
            }
            if(tilt_up)
            {
                rotationAngle += 2f;
                Cannon.Invalidate();
            }

            if(tilt_down)
            {
                rotationAngle -= 2f;
                Cannon.Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    tilt_up = true;
                    break;
                case Keys.Down:
                    tilt_down = true;
                    break;
                case Keys.Space:
                    SpawnCannonBall();
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    tilt_up = false;
                    break;
                case Keys.Down:
                    tilt_down = false;
                    break;
            }
        }
        private void SpawnCannonBall()
        {
            cannonBallPictureBox = new PictureBox();
            // Set PictureBox properties
            cannonBallPictureBox.BackColor = Color.Transparent; // Set the background color if needed
            cannonBallPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cannonBallPictureBox.Image = CannonBall;
            cannonBallPictureBox.Size = new Size(30, 30); // Set the size to match the size of the image
            cannonBallPictureBox.Location = new Point(100, 100); // Set the initial location of the PictureBox

            // Add PictureBox to the form's controls collection
            this.Controls.Add(cannonBallPictureBox);
        }

        private void Cannon_Paint(object sender, PaintEventArgs e)
        {
            // Create a new graphics object from the PictureBox
            Graphics g = e.Graphics;

            // Clear the graphics surface
            g.Clear(Cannon.BackColor);

            // Translate and rotate the graphics object
            g.TranslateTransform(Cannon.Width / 2, Cannon.Height / 2); // Move the origin to the center
            g.RotateTransform(rotationAngle); // Rotate the graphics object

            // Draw the rotated image
            g.DrawImage(CannonImage, -CannonImage.Width / 2, -CannonImage.Height / 2);

            // Reset the graphics object to its default state
            g.ResetTransform();
        }
    }
}
