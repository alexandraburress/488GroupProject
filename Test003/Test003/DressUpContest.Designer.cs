﻿namespace Test003
{
    partial class DressUpContest
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
            this.dressUpPictureBox = new System.Windows.Forms.PictureBox();
            this.clothingTabMaster = new System.Windows.Forms.TabControl();
            this.shirtsTab = new System.Windows.Forms.TabPage();
            this.shirtSelectionListBox = new System.Windows.Forms.ListBox();
            this.pantsTab = new System.Windows.Forms.TabPage();
            this.pantsListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.socksListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.shoesListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hairListBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.faceListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dressUpPictureBox)).BeginInit();
            this.clothingTabMaster.SuspendLayout();
            this.shirtsTab.SuspendLayout();
            this.pantsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dressUpPictureBox
            // 
            this.dressUpPictureBox.Image = global::Test003.Properties.Resources.Henry004;
            this.dressUpPictureBox.Location = new System.Drawing.Point(9, 53);
            this.dressUpPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.dressUpPictureBox.Name = "dressUpPictureBox";
            this.dressUpPictureBox.Size = new System.Drawing.Size(354, 341);
            this.dressUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dressUpPictureBox.TabIndex = 2;
            this.dressUpPictureBox.TabStop = false;
            // 
            // clothingTabMaster
            // 
            this.clothingTabMaster.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.clothingTabMaster.Controls.Add(this.tabPage4);
            this.clothingTabMaster.Controls.Add(this.shirtsTab);
            this.clothingTabMaster.Controls.Add(this.pantsTab);
            this.clothingTabMaster.Controls.Add(this.tabPage1);
            this.clothingTabMaster.Controls.Add(this.tabPage2);
            this.clothingTabMaster.Controls.Add(this.tabPage3);
            this.clothingTabMaster.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothingTabMaster.ItemSize = new System.Drawing.Size(70, 67);
            this.clothingTabMaster.Location = new System.Drawing.Point(367, 11);
            this.clothingTabMaster.Margin = new System.Windows.Forms.Padding(2);
            this.clothingTabMaster.Multiline = true;
            this.clothingTabMaster.Name = "clothingTabMaster";
            this.clothingTabMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clothingTabMaster.SelectedIndex = 0;
            this.clothingTabMaster.Size = new System.Drawing.Size(398, 444);
            this.clothingTabMaster.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.clothingTabMaster.TabIndex = 3;
            // 
            // shirtsTab
            // 
            this.shirtsTab.BackColor = System.Drawing.Color.Violet;
            this.shirtsTab.Controls.Add(this.shirtSelectionListBox);
            this.shirtsTab.Location = new System.Drawing.Point(4, 4);
            this.shirtsTab.Margin = new System.Windows.Forms.Padding(2);
            this.shirtsTab.Name = "shirtsTab";
            this.shirtsTab.Padding = new System.Windows.Forms.Padding(2);
            this.shirtsTab.Size = new System.Drawing.Size(323, 436);
            this.shirtsTab.TabIndex = 0;
            this.shirtsTab.Text = "Shirt";
            this.shirtsTab.ToolTipText = "Shirt";
            this.shirtsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // shirtSelectionListBox
            // 
            this.shirtSelectionListBox.BackColor = System.Drawing.Color.Violet;
            this.shirtSelectionListBox.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shirtSelectionListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.shirtSelectionListBox.FormattingEnabled = true;
            this.shirtSelectionListBox.ItemHeight = 28;
            this.shirtSelectionListBox.Location = new System.Drawing.Point(4, 5);
            this.shirtSelectionListBox.Margin = new System.Windows.Forms.Padding(2);
            this.shirtSelectionListBox.Name = "shirtSelectionListBox";
            this.shirtSelectionListBox.Size = new System.Drawing.Size(306, 88);
            this.shirtSelectionListBox.TabIndex = 6;
            this.shirtSelectionListBox.SelectedIndexChanged += new System.EventHandler(this.shirtSelectionListBox_SelectedIndexChanged);
            // 
            // pantsTab
            // 
            this.pantsTab.BackColor = System.Drawing.Color.Violet;
            this.pantsTab.Controls.Add(this.pantsListBox);
            this.pantsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pantsTab.Location = new System.Drawing.Point(4, 4);
            this.pantsTab.Margin = new System.Windows.Forms.Padding(2);
            this.pantsTab.Name = "pantsTab";
            this.pantsTab.Padding = new System.Windows.Forms.Padding(2);
            this.pantsTab.Size = new System.Drawing.Size(323, 436);
            this.pantsTab.TabIndex = 1;
            this.pantsTab.Text = "Pants";
            // 
            // pantsListBox
            // 
            this.pantsListBox.BackColor = System.Drawing.Color.Violet;
            this.pantsListBox.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pantsListBox.FormattingEnabled = true;
            this.pantsListBox.ItemHeight = 28;
            this.pantsListBox.Location = new System.Drawing.Point(4, 5);
            this.pantsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.pantsListBox.Name = "pantsListBox";
            this.pantsListBox.Size = new System.Drawing.Size(305, 116);
            this.pantsListBox.TabIndex = 7;
            this.pantsListBox.SelectedIndexChanged += new System.EventHandler(this.pantsListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Violet;
            this.tabPage1.Controls.Add(this.socksListBox);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(323, 436);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Socks";
            // 
            // socksListBox
            // 
            this.socksListBox.BackColor = System.Drawing.Color.Violet;
            this.socksListBox.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socksListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.socksListBox.FormattingEnabled = true;
            this.socksListBox.ItemHeight = 28;
            this.socksListBox.Location = new System.Drawing.Point(4, 5);
            this.socksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.socksListBox.Name = "socksListBox";
            this.socksListBox.Size = new System.Drawing.Size(309, 88);
            this.socksListBox.TabIndex = 0;
            this.socksListBox.SelectedIndexChanged += new System.EventHandler(this.socksListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Violet;
            this.tabPage2.Controls.Add(this.shoesListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(323, 436);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Shoes";
            // 
            // shoesListBox
            // 
            this.shoesListBox.BackColor = System.Drawing.Color.Violet;
            this.shoesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.shoesListBox.FormattingEnabled = true;
            this.shoesListBox.ItemHeight = 28;
            this.shoesListBox.Location = new System.Drawing.Point(2, 5);
            this.shoesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.shoesListBox.Name = "shoesListBox";
            this.shoesListBox.Size = new System.Drawing.Size(316, 88);
            this.shoesListBox.TabIndex = 0;
            this.shoesListBox.SelectedIndexChanged += new System.EventHandler(this.shoesListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Violet;
            this.tabPage3.Controls.Add(this.hairListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(323, 436);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Hair";
            // 
            // hairListBox
            // 
            this.hairListBox.BackColor = System.Drawing.Color.Violet;
            this.hairListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hairListBox.FormattingEnabled = true;
            this.hairListBox.ItemHeight = 28;
            this.hairListBox.Location = new System.Drawing.Point(4, 5);
            this.hairListBox.Margin = new System.Windows.Forms.Padding(2);
            this.hairListBox.Name = "hairListBox";
            this.hairListBox.Size = new System.Drawing.Size(302, 88);
            this.hairListBox.TabIndex = 0;
            this.hairListBox.SelectedIndexChanged += new System.EventHandler(this.hairListBox_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Violet;
            this.tabPage4.Controls.Add(this.faceListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(323, 436);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Make-Up";
            // 
            // faceListBox
            // 
            this.faceListBox.BackColor = System.Drawing.Color.Violet;
            this.faceListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.faceListBox.FormattingEnabled = true;
            this.faceListBox.ItemHeight = 28;
            this.faceListBox.Location = new System.Drawing.Point(5, 6);
            this.faceListBox.Margin = new System.Windows.Forms.Padding(2);
            this.faceListBox.Name = "faceListBox";
            this.faceListBox.Size = new System.Drawing.Size(309, 88);
            this.faceListBox.TabIndex = 0;
            this.faceListBox.SelectedIndexChanged += new System.EventHandler(this.faceListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(9, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate Contest Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the best outfit for Henry!";
            // 
            // DressUpContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(776, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clothingTabMaster);
            this.Controls.Add(this.dressUpPictureBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DressUpContest";
            this.Text = "DressUpContest";
            this.Load += new System.EventHandler(this.DressUpContest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dressUpPictureBox)).EndInit();
            this.clothingTabMaster.ResumeLayout(false);
            this.shirtsTab.ResumeLayout(false);
            this.pantsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dressUpPictureBox;
        private System.Windows.Forms.TabControl clothingTabMaster;
        private System.Windows.Forms.TabPage pantsTab;
        private System.Windows.Forms.TabPage shirtsTab;
        private System.Windows.Forms.ListBox shirtSelectionListBox;
        private System.Windows.Forms.ListBox pantsListBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox socksListBox;
        private System.Windows.Forms.ListBox shoesListBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox hairListBox;
        private System.Windows.Forms.ListBox faceListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}