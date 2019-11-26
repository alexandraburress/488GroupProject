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
            this.SuspendLayout();
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(248, 100);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(289, 91);
            this.btnWin.TabIndex = 0;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLose
            // 
            this.btnLose.Location = new System.Drawing.Point(248, 241);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(289, 91);
            this.btnLose.TabIndex = 1;
            this.btnLose.Text = "Lose";
            this.btnLose.UseVisualStyleBackColor = true;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // DressUpContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLose);
            this.Controls.Add(this.btnWin);
            this.Name = "DressUpContest";
            this.Text = "DressUpContest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLose;
    }
}