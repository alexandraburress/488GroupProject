﻿namespace Test003
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
            this.outputLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.middleCharacterBoxImage = new System.Windows.Forms.PictureBox();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.eventAlertPanel = new System.Windows.Forms.Panel();
            this.eventOutputLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.middleCharacterBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.eventAlertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.Color.LightSalmon;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Location = new System.Drawing.Point(22, 447);
            this.outputLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(677, 156);
            this.outputLbl.TabIndex = 0;
            this.outputLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(722, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // middleCharacterBoxImage
            // 
            this.middleCharacterBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.middleCharacterBoxImage.Image = global::Test003.Properties.Resources.James_Green_Think_full;
            this.middleCharacterBoxImage.Location = new System.Drawing.Point(178, 51);
            this.middleCharacterBoxImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.middleCharacterBoxImage.Name = "middleCharacterBoxImage";
            this.middleCharacterBoxImage.Size = new System.Drawing.Size(376, 390);
            this.middleCharacterBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middleCharacterBoxImage.TabIndex = 3;
            this.middleCharacterBoxImage.TabStop = false;
            this.middleCharacterBoxImage.Click += new System.EventHandler(this.middleCharacterBoxImage_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.Image = global::Test003.Properties.Resources.GlamorLair001;
            this.backgroundImage.Location = new System.Drawing.Point(22, 51);
            this.backgroundImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(678, 390);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundImage.TabIndex = 2;
            this.backgroundImage.TabStop = false;
            this.backgroundImage.Click += new System.EventHandler(this.backgroundImage_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.prevButton);
            this.flowLayoutPanel1.Controls.Add(this.nextBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(457, 605);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 51);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(2, 2);
            this.prevButton.Margin = new System.Windows.Forms.Padding(2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(112, 43);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(118, 2);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(112, 43);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // eventAlertPanel
            // 
            this.eventAlertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventAlertPanel.Controls.Add(this.eventOutputLbl);
            this.eventAlertPanel.Controls.Add(this.pictureBox1);
            this.eventAlertPanel.Location = new System.Drawing.Point(217, 119);
            this.eventAlertPanel.Name = "eventAlertPanel";
            this.eventAlertPanel.Size = new System.Drawing.Size(277, 223);
            this.eventAlertPanel.TabIndex = 7;
            this.eventAlertPanel.Visible = false;
            this.eventAlertPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.eventAlertPanel_Paint);
            // 
            // eventOutputLbl
            // 
            this.eventOutputLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventOutputLbl.Location = new System.Drawing.Point(0, 124);
            this.eventOutputLbl.Name = "eventOutputLbl";
            this.eventOutputLbl.Size = new System.Drawing.Size(275, 97);
            this.eventOutputLbl.TabIndex = 2;
            this.eventOutputLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(51, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(722, 666);
            this.Controls.Add(this.eventAlertPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.middleCharacterBoxImage);
            this.Controls.Add(this.backgroundImage);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Story";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.middleCharacterBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.eventAlertPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.Windows.Forms.PictureBox middleCharacterBoxImage;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel eventAlertPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eventOutputLbl;
    }
}
