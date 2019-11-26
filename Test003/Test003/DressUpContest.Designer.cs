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
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLose = new System.Windows.Forms.Button();
            this.dressUpPictureBox = new System.Windows.Forms.PictureBox();
            this.clothingTabMaster = new System.Windows.Forms.TabControl();
            this.shirtsTab = new System.Windows.Forms.TabPage();
            this.pantsTab = new System.Windows.Forms.TabPage();
            this.shirtSelctionComboBox = new System.Windows.Forms.ComboBox();
            this.pantsSelctionComboBox = new System.Windows.Forms.ComboBox();
            this.pants_selectBtn = new System.Windows.Forms.Button();
            this.shirt_selectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dressUpPictureBox)).BeginInit();
            this.clothingTabMaster.SuspendLayout();
            this.shirtsTab.SuspendLayout();
            this.pantsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(499, 250);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(452, 91);
            this.btnWin.TabIndex = 0;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLose
            // 
            this.btnLose.Location = new System.Drawing.Point(499, 347);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(452, 91);
            this.btnLose.TabIndex = 1;
            this.btnLose.Text = "Lose";
            this.btnLose.UseVisualStyleBackColor = true;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // dressUpPictureBox
            // 
            this.dressUpPictureBox.Image = global::Test003.Properties.Resources.Henry004;
            this.dressUpPictureBox.Location = new System.Drawing.Point(12, 12);
            this.dressUpPictureBox.Name = "dressUpPictureBox";
            this.dressUpPictureBox.Size = new System.Drawing.Size(481, 358);
            this.dressUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dressUpPictureBox.TabIndex = 2;
            this.dressUpPictureBox.TabStop = false;
            // 
            // clothingTabMaster
            // 
            this.clothingTabMaster.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.clothingTabMaster.Controls.Add(this.shirtsTab);
            this.clothingTabMaster.Controls.Add(this.pantsTab);
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
            this.shirtsTab.Controls.Add(this.shirt_selectBtn);
            this.shirtsTab.Controls.Add(this.shirtSelctionComboBox);
            this.shirtsTab.Location = new System.Drawing.Point(4, 4);
            this.shirtsTab.Name = "shirtsTab";
            this.shirtsTab.Padding = new System.Windows.Forms.Padding(3);
            this.shirtsTab.Size = new System.Drawing.Size(448, 223);
            this.shirtsTab.TabIndex = 0;
            this.shirtsTab.Text = "Shirt";
            this.shirtsTab.ToolTipText = "Shirt";
            this.shirtsTab.UseVisualStyleBackColor = true;
            this.shirtsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pantsTab
            // 
            this.pantsTab.Controls.Add(this.pants_selectBtn);
            this.pantsTab.Controls.Add(this.pantsSelctionComboBox);
            this.pantsTab.Location = new System.Drawing.Point(4, 4);
            this.pantsTab.Name = "pantsTab";
            this.pantsTab.Padding = new System.Windows.Forms.Padding(3);
            this.pantsTab.Size = new System.Drawing.Size(448, 223);
            this.pantsTab.TabIndex = 1;
            this.pantsTab.Text = "Pants";
            this.pantsTab.UseVisualStyleBackColor = true;
            // 
            // shirtSelctionComboBox
            // 
            this.shirtSelctionComboBox.FormattingEnabled = true;
            this.shirtSelctionComboBox.Location = new System.Drawing.Point(3, 6);
            this.shirtSelctionComboBox.Name = "shirtSelctionComboBox";
            this.shirtSelctionComboBox.Size = new System.Drawing.Size(350, 24);
            this.shirtSelctionComboBox.TabIndex = 4;
            this.shirtSelctionComboBox.SelectedIndexChanged += new System.EventHandler(this.shirtSelctionComboBox_SelectedIndexChanged);
            // 
            // pantsSelctionComboBox
            // 
            this.pantsSelctionComboBox.FormattingEnabled = true;
            this.pantsSelctionComboBox.Location = new System.Drawing.Point(6, 6);
            this.pantsSelctionComboBox.Name = "pantsSelctionComboBox";
            this.pantsSelctionComboBox.Size = new System.Drawing.Size(350, 24);
            this.pantsSelctionComboBox.TabIndex = 0;
            this.pantsSelctionComboBox.SelectedIndexChanged += new System.EventHandler(this.pantsSelctionComboBox_SelectedIndexChanged);
            // 
            // pants_selectBtn
            // 
            this.pants_selectBtn.Location = new System.Drawing.Point(7, 37);
            this.pants_selectBtn.Name = "pants_selectBtn";
            this.pants_selectBtn.Size = new System.Drawing.Size(75, 23);
            this.pants_selectBtn.TabIndex = 1;
            this.pants_selectBtn.Text = "Select";
            this.pants_selectBtn.UseVisualStyleBackColor = true;
            // 
            // shirt_selectBtn
            // 
            this.shirt_selectBtn.Location = new System.Drawing.Point(7, 37);
            this.shirt_selectBtn.Name = "shirt_selectBtn";
            this.shirt_selectBtn.Size = new System.Drawing.Size(75, 23);
            this.shirt_selectBtn.TabIndex = 5;
            this.shirt_selectBtn.Text = "Select";
            this.shirt_selectBtn.UseVisualStyleBackColor = true;
            this.shirt_selectBtn.Click += new System.EventHandler(this.shirt_selectBtn_Click);
            // 
            // DressUpContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.clothingTabMaster);
            this.Controls.Add(this.dressUpPictureBox);
            this.Controls.Add(this.btnLose);
            this.Controls.Add(this.btnWin);
            this.Name = "DressUpContest";
            this.Text = "DressUpContest";
            this.Load += new System.EventHandler(this.DressUpContest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dressUpPictureBox)).EndInit();
            this.clothingTabMaster.ResumeLayout(false);
            this.shirtsTab.ResumeLayout(false);
            this.pantsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.PictureBox dressUpPictureBox;
        private System.Windows.Forms.TabControl clothingTabMaster;
        private System.Windows.Forms.TabPage pantsTab;
        private System.Windows.Forms.TabPage shirtsTab;
        private System.Windows.Forms.ComboBox shirtSelctionComboBox;
        private System.Windows.Forms.ComboBox pantsSelctionComboBox;
        private System.Windows.Forms.Button pants_selectBtn;
        private System.Windows.Forms.Button shirt_selectBtn;
    }
}