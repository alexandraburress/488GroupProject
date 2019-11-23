namespace Test003
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.newGameBtn = new System.Windows.Forms.Button();
            this.loadGameBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creditsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.Violet;
            this.newGameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newGameBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Location = new System.Drawing.Point(322, 248);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(152, 45);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // loadGameBtn
            // 
            this.loadGameBtn.BackColor = System.Drawing.Color.Violet;
            this.loadGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadGameBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.loadGameBtn.Location = new System.Drawing.Point(322, 318);
            this.loadGameBtn.Name = "loadGameBtn";
            this.loadGameBtn.Size = new System.Drawing.Size(152, 45);
            this.loadGameBtn.TabIndex = 1;
            this.loadGameBtn.Text = "Load Game";
            this.loadGameBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // creditsBtn
            // 
            this.creditsBtn.BackColor = System.Drawing.Color.Violet;
            this.creditsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.creditsBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.creditsBtn.Location = new System.Drawing.Point(322, 384);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(152, 45);
            this.creditsBtn.TabIndex = 3;
            this.creditsBtn.Text = "Credits";
            this.creditsBtn.UseVisualStyleBackColor = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.creditsBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadGameBtn);
            this.Controls.Add(this.newGameBtn);
            this.Name = "StartPage";
            this.Text = "Magic School Dress Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button loadGameBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button creditsBtn;
    }
}