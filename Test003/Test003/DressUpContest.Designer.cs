namespace Test003
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.socksListBox = new System.Windows.Forms.ListBox();
            this.shoesListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.hairListBox = new System.Windows.Forms.ListBox();
            this.faceListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dressUpPictureBox.Location = new System.Drawing.Point(12, 13);
            this.dressUpPictureBox.Name = "dressUpPictureBox";
            this.dressUpPictureBox.Size = new System.Drawing.Size(481, 471);
            this.dressUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dressUpPictureBox.TabIndex = 2;
            this.dressUpPictureBox.TabStop = false;
            // 
            // clothingTabMaster
            // 
            this.clothingTabMaster.Controls.Add(this.shirtsTab);
            this.clothingTabMaster.Controls.Add(this.pantsTab);
            this.clothingTabMaster.Controls.Add(this.tabPage1);
            this.clothingTabMaster.Controls.Add(this.tabPage2);
            this.clothingTabMaster.Controls.Add(this.tabPage3);
            this.clothingTabMaster.Controls.Add(this.tabPage4);
            this.clothingTabMaster.ItemSize = new System.Drawing.Size(70, 67);
            this.clothingTabMaster.Location = new System.Drawing.Point(499, 13);
            this.clothingTabMaster.Multiline = true;
            this.clothingTabMaster.Name = "clothingTabMaster";
            this.clothingTabMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clothingTabMaster.SelectedIndex = 0;
            this.clothingTabMaster.Size = new System.Drawing.Size(523, 231);
            this.clothingTabMaster.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.clothingTabMaster.TabIndex = 3;
            // 
            // shirtsTab
            // 
            this.shirtsTab.BackColor = System.Drawing.Color.Black;
            this.shirtsTab.Controls.Add(this.shirtSelectionListBox);
            this.shirtsTab.Location = new System.Drawing.Point(4, 71);
            this.shirtsTab.Name = "shirtsTab";
            this.shirtsTab.Padding = new System.Windows.Forms.Padding(3);
            this.shirtsTab.Size = new System.Drawing.Size(515, 156);
            this.shirtsTab.TabIndex = 0;
            this.shirtsTab.Text = "Shirt";
            this.shirtsTab.ToolTipText = "Shirt";
            this.shirtsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // shirtSelectionListBox
            // 
            this.shirtSelectionListBox.FormattingEnabled = true;
            this.shirtSelectionListBox.ItemHeight = 16;
            this.shirtSelectionListBox.Location = new System.Drawing.Point(6, 6);
            this.shirtSelectionListBox.Name = "shirtSelectionListBox";
            this.shirtSelectionListBox.Size = new System.Drawing.Size(406, 132);
            this.shirtSelectionListBox.TabIndex = 6;
            this.shirtSelectionListBox.SelectedIndexChanged += new System.EventHandler(this.shirtSelectionListBox_SelectedIndexChanged);
            // 
            // pantsTab
            // 
            this.pantsTab.Controls.Add(this.pantsListBox);
            this.pantsTab.Location = new System.Drawing.Point(4, 71);
            this.pantsTab.Name = "pantsTab";
            this.pantsTab.Padding = new System.Windows.Forms.Padding(3);
            this.pantsTab.Size = new System.Drawing.Size(515, 156);
            this.pantsTab.TabIndex = 1;
            this.pantsTab.Text = "Pants";
            this.pantsTab.UseVisualStyleBackColor = true;
            // 
            // pantsListBox
            // 
            this.pantsListBox.FormattingEnabled = true;
            this.pantsListBox.ItemHeight = 16;
            this.pantsListBox.Location = new System.Drawing.Point(6, 6);
            this.pantsListBox.Name = "pantsListBox";
            this.pantsListBox.Size = new System.Drawing.Size(405, 148);
            this.pantsListBox.TabIndex = 7;
            this.pantsListBox.SelectedIndexChanged += new System.EventHandler(this.pantsListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.socksListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 71);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 156);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Socks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.shoesListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 71);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 156);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Shoes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // socksListBox
            // 
            this.socksListBox.FormattingEnabled = true;
            this.socksListBox.ItemHeight = 16;
            this.socksListBox.Location = new System.Drawing.Point(6, 6);
            this.socksListBox.Name = "socksListBox";
            this.socksListBox.Size = new System.Drawing.Size(411, 132);
            this.socksListBox.TabIndex = 0;
            this.socksListBox.SelectedIndexChanged += new System.EventHandler(this.socksListBox_SelectedIndexChanged);
            // 
            // shoesListBox
            // 
            this.shoesListBox.FormattingEnabled = true;
            this.shoesListBox.ItemHeight = 16;
            this.shoesListBox.Location = new System.Drawing.Point(3, 6);
            this.shoesListBox.Name = "shoesListBox";
            this.shoesListBox.Size = new System.Drawing.Size(420, 132);
            this.shoesListBox.TabIndex = 0;
            this.shoesListBox.SelectedIndexChanged += new System.EventHandler(this.shoesListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hairListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 71);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(515, 156);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Hair";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.faceListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 71);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(515, 156);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Make-Up";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // hairListBox
            // 
            this.hairListBox.FormattingEnabled = true;
            this.hairListBox.ItemHeight = 16;
            this.hairListBox.Location = new System.Drawing.Point(6, 6);
            this.hairListBox.Name = "hairListBox";
            this.hairListBox.Size = new System.Drawing.Size(401, 132);
            this.hairListBox.TabIndex = 0;
            this.hairListBox.SelectedIndexChanged += new System.EventHandler(this.hairListBox_SelectedIndexChanged);
            // 
            // faceListBox
            // 
            this.faceListBox.FormattingEnabled = true;
            this.faceListBox.ItemHeight = 16;
            this.faceListBox.Location = new System.Drawing.Point(7, 7);
            this.faceListBox.Name = "faceListBox";
            this.faceListBox.Size = new System.Drawing.Size(411, 132);
            this.faceListBox.TabIndex = 0;
            this.faceListBox.SelectedIndexChanged += new System.EventHandler(this.faceListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(508, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DressUpContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clothingTabMaster);
            this.Controls.Add(this.dressUpPictureBox);
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
    }
}