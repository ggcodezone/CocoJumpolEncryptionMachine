namespace CocoEncryption
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonMethod1 = new System.Windows.Forms.Button();
            this.buttonMethod2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.musicStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMethod1
            // 
            this.buttonMethod1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMethod1.BackgroundImage = global::CocoEncryption.Properties.Resources.Gem;
            this.buttonMethod1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMethod1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMethod1.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMethod1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMethod1.Location = new System.Drawing.Point(412, 65);
            this.buttonMethod1.Name = "buttonMethod1";
            this.buttonMethod1.Size = new System.Drawing.Size(144, 126);
            this.buttonMethod1.TabIndex = 0;
            this.buttonMethod1.Text = "Encrypt Text";
            this.buttonMethod1.UseVisualStyleBackColor = false;
            this.buttonMethod1.Click += new System.EventHandler(this.buttonMethod1_Click);
            // 
            // buttonMethod2
            // 
            this.buttonMethod2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMethod2.BackgroundImage = global::CocoEncryption.Properties.Resources.Gem;
            this.buttonMethod2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMethod2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMethod2.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMethod2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMethod2.Location = new System.Drawing.Point(603, 65);
            this.buttonMethod2.Name = "buttonMethod2";
            this.buttonMethod2.Size = new System.Drawing.Size(144, 126);
            this.buttonMethod2.TabIndex = 1;
            this.buttonMethod2.Text = "Encrypt And Decrypt Text";
            this.buttonMethod2.UseVisualStyleBackColor = false;
            this.buttonMethod2.Click += new System.EventHandler(this.buttonMethod2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CocoEncryption.Properties.Resources.Coco_Jumbo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 408);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CocoEncryption.Properties.Resources.logo2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(347, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 162);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::CocoEncryption.Properties.Resources.key;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(40, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 194);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // musicStop
            // 
            this.musicStop.BackColor = System.Drawing.Color.CadetBlue;
            this.musicStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicStop.Location = new System.Drawing.Point(27, 414);
            this.musicStop.Name = "musicStop";
            this.musicStop.Size = new System.Drawing.Size(284, 24);
            this.musicStop.TabIndex = 5;
            this.musicStop.Text = "Stop music (but why would you want to?)";
            this.musicStop.UseVisualStyleBackColor = false;
            this.musicStop.Click += new System.EventHandler(this.musicStop_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::CocoEncryption.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.musicStop);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMethod2);
            this.Controls.Add(this.buttonMethod1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Coco Jumpol Encryption Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMethod1;
        private System.Windows.Forms.Button buttonMethod2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button musicStop;
    }
}

