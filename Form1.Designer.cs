namespace Cannon_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grass = new System.Windows.Forms.PictureBox();
            this.Carriage = new System.Windows.Forms.PictureBox();
            this.Cannon = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carriage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cannon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent_Move);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::Cannon_Game.Properties.Resources.WoodenBox;
            this.pictureBox2.Location = new System.Drawing.Point(1011, 248);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Cannon_Game.Properties.Resources.CannonBall;
            this.pictureBox1.Location = new System.Drawing.Point(232, 296);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Grass
            // 
            this.Grass.BackColor = System.Drawing.Color.DarkGreen;
            this.Grass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Grass.ErrorImage = null;
            this.Grass.Location = new System.Drawing.Point(1, 330);
            this.Grass.Margin = new System.Windows.Forms.Padding(2);
            this.Grass.Name = "Grass";
            this.Grass.Size = new System.Drawing.Size(1220, 32);
            this.Grass.TabIndex = 3;
            this.Grass.TabStop = false;
            // 
            // Carriage
            // 
            this.Carriage.BackColor = System.Drawing.Color.Olive;
            this.Carriage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Carriage.ErrorImage = null;
            this.Carriage.Location = new System.Drawing.Point(32, 290);
            this.Carriage.Margin = new System.Windows.Forms.Padding(2);
            this.Carriage.Name = "Carriage";
            this.Carriage.Size = new System.Drawing.Size(132, 53);
            this.Carriage.TabIndex = 2;
            this.Carriage.TabStop = false;
            // 
            // Cannon
            // 
            this.Cannon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cannon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cannon.ErrorImage = null;
            this.Cannon.Image = global::Cannon_Game.Properties.Resources.Cannon2;
            this.Cannon.Location = new System.Drawing.Point(43, 202);
            this.Cannon.Margin = new System.Windows.Forms.Padding(2);
            this.Cannon.Name = "Cannon";
            this.Cannon.Size = new System.Drawing.Size(172, 122);
            this.Cannon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Cannon.TabIndex = 1;
            this.Cannon.TabStop = false;
            this.Cannon.Paint += new System.Windows.Forms.PaintEventHandler(this.Cannon_Paint);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ground.Location = new System.Drawing.Point(1, 330);
            this.Ground.Margin = new System.Windows.Forms.Padding(2);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1220, 102);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::Cannon_Game.Properties.Resources.WoodenBox;
            this.pictureBox3.Location = new System.Drawing.Point(1118, 248);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::Cannon_Game.Properties.Resources.WoodenBox;
            this.pictureBox4.Location = new System.Drawing.Point(1070, 149);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1232, 430);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Grass);
            this.Controls.Add(this.Carriage);
            this.Controls.Add(this.Cannon);
            this.Controls.Add(this.Ground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carriage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cannon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Cannon;
        private System.Windows.Forms.PictureBox Carriage;
        private System.Windows.Forms.PictureBox Grass;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

