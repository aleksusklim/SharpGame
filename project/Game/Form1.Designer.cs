namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.step = new System.Windows.Forms.Timer(this.components);
            this.keyer = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.life = new System.Windows.Forms.ProgressBar();
            this.boss = new System.Windows.Forms.PictureBox();
            this.bosser = new System.Windows.Forms.Timer(this.components);
            this.up = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(21, 199);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 32);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // step
            // 
            this.step.Interval = 10;
            this.step.Tick += new System.EventHandler(this.step_Tick);
            // 
            // keyer
            // 
            this.keyer.Location = new System.Drawing.Point(613, 313);
            this.keyer.Name = "keyer";
            this.keyer.Size = new System.Drawing.Size(10, 14);
            this.keyer.TabIndex = 3;
            this.keyer.Text = "keyer";
            this.keyer.UseVisualStyleBackColor = true;
            this.keyer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyer_KeyDown);
            // 
            // left
            // 
            this.left.Image = ((System.Drawing.Image)(resources.GetObject("left.Image")));
            this.left.Location = new System.Drawing.Point(0, 51);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(32, 32);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left.TabIndex = 6;
            this.left.TabStop = false;
            this.left.Visible = false;
            // 
            // right
            // 
            this.right.Image = ((System.Drawing.Image)(resources.GetObject("right.Image")));
            this.right.Location = new System.Drawing.Point(602, 255);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(32, 32);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.right.TabIndex = 7;
            this.right.TabStop = false;
            this.right.Visible = false;
            // 
            // down
            // 
            this.down.Image = ((System.Drawing.Image)(resources.GetObject("down.Image")));
            this.down.Location = new System.Drawing.Point(0, 275);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(32, 32);
            this.down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.down.TabIndex = 8;
            this.down.TabStop = false;
            this.down.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(501, 272);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(32, 32);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 9;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(287, 228);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(32, 32);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 10;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(138, 185);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(32, 32);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 10;
            this.enemy3.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(370, 141);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(32, 32);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 10;
            this.enemy4.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.Image = ((System.Drawing.Image)(resources.GetObject("enemy5.Image")));
            this.enemy5.Location = new System.Drawing.Point(470, 96);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(32, 32);
            this.enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy5.TabIndex = 10;
            this.enemy5.TabStop = false;
            // 
            // life
            // 
            this.life.Location = new System.Drawing.Point(7, 6);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(623, 17);
            this.life.Step = 1;
            this.life.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.life.TabIndex = 11;
            this.life.Value = 50;
            // 
            // boss
            // 
            this.boss.Image = ((System.Drawing.Image)(resources.GetObject("boss.Image")));
            this.boss.Location = new System.Drawing.Point(181, 51);
            this.boss.Name = "boss";
            this.boss.Size = new System.Drawing.Size(32, 32);
            this.boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss.TabIndex = 12;
            this.boss.TabStop = false;
            // 
            // bosser
            // 
            this.bosser.Interval = 1000;
            this.bosser.Tick += new System.EventHandler(this.bosser_Tick);
            // 
            // up
            // 
            this.up.Image = ((System.Drawing.Image)(resources.GetObject("up.Image")));
            this.up.Location = new System.Drawing.Point(602, 40);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(32, 32);
            this.up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.up.TabIndex = 13;
            this.up.TabStop = false;
            this.up.Visible = false;
            // 
            // bullet
            // 
            this.bullet.Image = ((System.Drawing.Image)(resources.GetObject("bullet.Image")));
            this.bullet.Location = new System.Drawing.Point(287, 96);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(32, 32);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 14;
            this.bullet.TabStop = false;
            // 
            // time
            // 
            this.time.Enabled = false;
            this.time.Location = new System.Drawing.Point(4, 313);
            this.time.Maximum = 80;
            this.time.Name = "time";
            this.time.RightToLeftLayout = true;
            this.time.Size = new System.Drawing.Size(626, 17);
            this.time.Step = 1;
            this.time.TabIndex = 15;
            this.time.Value = 10;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.player);
            this.Controls.Add(this.up);
            this.Controls.Add(this.boss);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.life);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.time);
            this.Controls.Add(this.keyer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer step;
        private System.Windows.Forms.Button keyer;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox down;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.ProgressBar life;
        private System.Windows.Forms.PictureBox boss;
        private System.Windows.Forms.Timer bosser;
        private System.Windows.Forms.PictureBox up;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.ProgressBar time;
        private System.Windows.Forms.Timer timer;
    }
}

