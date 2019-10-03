namespace Test003
{
    partial class Map
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
            this.mapPanel = new System.Windows.Forms.Panel();
            this.aUniversityPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dressUpPanel = new System.Windows.Forms.Panel();
            this.dressUpGameButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mapPanel.SuspendLayout();
            this.aUniversityPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dressUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.Controls.Add(this.dressUpPanel);
            this.mapPanel.Controls.Add(this.aUniversityPanel);
            this.mapPanel.Controls.Add(this.panel1);
            this.mapPanel.Location = new System.Drawing.Point(31, 36);
            this.mapPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(660, 471);
            this.mapPanel.TabIndex = 0;
            this.mapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mapPanel_Paint);
            // 
            // aUniversityPanel
            // 
            this.aUniversityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aUniversityPanel.Controls.Add(this.button2);
            this.aUniversityPanel.Controls.Add(this.label2);
            this.aUniversityPanel.Location = new System.Drawing.Point(212, 4);
            this.aUniversityPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aUniversityPanel.Name = "aUniversityPanel";
            this.aUniversityPanel.Size = new System.Drawing.Size(204, 123);
            this.aUniversityPanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "A-University";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Glamor Lair";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dressUpPanel
            // 
            this.dressUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dressUpPanel.Controls.Add(this.dressUpGameButton);
            this.dressUpPanel.Controls.Add(this.label3);
            this.dressUpPanel.Location = new System.Drawing.Point(424, 4);
            this.dressUpPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dressUpPanel.Name = "dressUpPanel";
            this.dressUpPanel.Size = new System.Drawing.Size(204, 123);
            this.dressUpPanel.TabIndex = 3;
            // 
            // dressUpGameButton
            // 
            this.dressUpGameButton.Location = new System.Drawing.Point(37, 55);
            this.dressUpGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.dressUpGameButton.Name = "dressUpGameButton";
            this.dressUpGameButton.Size = new System.Drawing.Size(143, 28);
            this.dressUpGameButton.TabIndex = 1;
            this.dressUpGameButton.Text = "Enter";
            this.dressUpGameButton.UseVisualStyleBackColor = true;
            this.dressUpGameButton.Click += new System.EventHandler(this.dressUpGameButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dress Up Game";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 554);
            this.Controls.Add(this.mapPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Map";
            this.Text = "Map";
            this.mapPanel.ResumeLayout(false);
            this.aUniversityPanel.ResumeLayout(false);
            this.aUniversityPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dressUpPanel.ResumeLayout(false);
            this.dressUpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel aUniversityPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dressUpPanel;
        private System.Windows.Forms.Button dressUpGameButton;
        private System.Windows.Forms.Label label3;
    }
}