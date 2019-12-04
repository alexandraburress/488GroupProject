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
            this.socksListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.shoesListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hairListBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.faceListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.glassesTab = new System.Windows.Forms.TabPage();
            this.glassesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dressUpPictureBox)).BeginInit();
            this.clothingTabMaster.SuspendLayout();
            this.shirtsTab.SuspendLayout();
            this.pantsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.glassesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dressUpPictureBox
            // 
            this.dressUpPictureBox.Image = global::Test003.Properties.Resources.Henry004;
            this.dressUpPictureBox.Location = new System.Drawing.Point(12, 13);
            this.dressUpPictureBox.Name = "dressUpPictureBox";
            this.dressUpPictureBox.Size = new System.Drawing.Size(481, 391);
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
            this.clothingTabMaster.Controls.Add(this.glassesTab);
            this.clothingTabMaster.ItemSize = new System.Drawing.Size(70, 67);
            this.clothingTabMaster.Location = new System.Drawing.Point(499, 13);
            this.clothingTabMaster.Multiline = true;
            this.clothingTabMaster.Name = "clothingTabMaster";
            this.clothingTabMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clothingTabMaster.SelectedIndex = 0;
            this.clothingTabMaster.Size = new System.Drawing.Size(523, 395);
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
            this.shirtsTab.Size = new System.Drawing.Size(515, 320);
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
            this.shirtSelectionListBox.Size = new System.Drawing.Size(406, 292);
            this.shirtSelectionListBox.TabIndex = 6;
            this.shirtSelectionListBox.SelectedIndexChanged += new System.EventHandler(this.shirtSelectionListBox_SelectedIndexChanged);
            // 
            // pantsTab
            // 
            this.pantsTab.Controls.Add(this.pantsListBox);
            this.pantsTab.Location = new System.Drawing.Point(4, 71);
            this.pantsTab.Name = "pantsTab";
            this.pantsTab.Padding = new System.Windows.Forms.Padding(3);
            this.pantsTab.Size = new System.Drawing.Size(515, 320);
            this.pantsTab.TabIndex = 1;
            this.pantsTab.Text = "Pants";
            this.pantsTab.UseVisualStyleBackColor = true;
            // 
            // pantsListBox
            // 
            this.pantsListBox.FormattingEnabled = true;
            this.pantsListBox.ItemHeight = 16;
            this.pantsListBox.Location = new System.Drawing.Point(7, 6);
            this.pantsListBox.Name = "pantsListBox";
            this.pantsListBox.Size = new System.Drawing.Size(405, 260);
            this.pantsListBox.TabIndex = 7;
            this.pantsListBox.SelectedIndexChanged += new System.EventHandler(this.pantsListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.socksListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 71);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 320);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Socks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // socksListBox
            // 
            this.socksListBox.FormattingEnabled = true;
            this.socksListBox.ItemHeight = 16;
            this.socksListBox.Location = new System.Drawing.Point(6, 6);
            this.socksListBox.Name = "socksListBox";
            this.socksListBox.Size = new System.Drawing.Size(411, 276);
            this.socksListBox.TabIndex = 0;
            this.socksListBox.SelectedIndexChanged += new System.EventHandler(this.socksListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.shoesListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 71);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 320);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Shoes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // shoesListBox
            // 
            this.shoesListBox.FormattingEnabled = true;
            this.shoesListBox.ItemHeight = 16;
            this.shoesListBox.Location = new System.Drawing.Point(3, 6);
            this.shoesListBox.Name = "shoesListBox";
            this.shoesListBox.Size = new System.Drawing.Size(420, 276);
            this.shoesListBox.TabIndex = 0;
            this.shoesListBox.SelectedIndexChanged += new System.EventHandler(this.shoesListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hairListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 71);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(515, 320);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Hair";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.faceListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 71);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(515, 320);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Make-Up";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // faceListBox
            // 
            this.faceListBox.FormattingEnabled = true;
            this.faceListBox.ItemHeight = 16;
            this.faceListBox.Location = new System.Drawing.Point(7, 6);
            this.faceListBox.Name = "faceListBox";
            this.faceListBox.Size = new System.Drawing.Size(411, 292);
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
            // scoreLbl
            // 
            this.scoreLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLbl.Location = new System.Drawing.Point(286, 414);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(207, 70);
            this.scoreLbl.TabIndex = 5;
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // glassesTab
            // 
            this.glassesTab.Controls.Add(this.glassesListBox);
            this.glassesTab.Location = new System.Drawing.Point(4, 71);
            this.glassesTab.Name = "glassesTab";
            this.glassesTab.Padding = new System.Windows.Forms.Padding(3);
            this.glassesTab.Size = new System.Drawing.Size(515, 320);
            this.glassesTab.TabIndex = 6;
            this.glassesTab.Text = "Glasses";
            this.glassesTab.UseVisualStyleBackColor = true;
            // 
            // glassesListBox
            // 
            this.glassesListBox.FormattingEnabled = true;
            this.glassesListBox.ItemHeight = 16;
            this.glassesListBox.Location = new System.Drawing.Point(7, 6);
            this.glassesListBox.Name = "glassesListBox";
            this.glassesListBox.Size = new System.Drawing.Size(379, 244);
            this.glassesListBox.TabIndex = 0;
            this.glassesListBox.SelectedIndexChanged += new System.EventHandler(this.glassesListBox_SelectedIndexChanged);
            // 
            // DressUpContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLbl);
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
            this.glassesTab.ResumeLayout(false);
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
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage glassesTab;
        private System.Windows.Forms.ListBox glassesListBox;
    }
}