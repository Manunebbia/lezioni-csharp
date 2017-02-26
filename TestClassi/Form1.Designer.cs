namespace TestClassi
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
            this.enemyImg = new System.Windows.Forms.PictureBox();
            this.nextButt = new System.Windows.Forms.Button();
            this.prevButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImg)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyImg
            // 
            this.enemyImg.Location = new System.Drawing.Point(310, 27);
            this.enemyImg.Name = "enemyImg";
            this.enemyImg.Size = new System.Drawing.Size(192, 150);
            this.enemyImg.TabIndex = 0;
            this.enemyImg.TabStop = false;
            // 
            // nextButt
            // 
            this.nextButt.Location = new System.Drawing.Point(254, 82);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(32, 23);
            this.nextButt.TabIndex = 2;
            this.nextButt.Text = ">";
            this.nextButt.UseVisualStyleBackColor = true;
            this.nextButt.Click += new System.EventHandler(this.nextButt_Click);
            // 
            // prevButt
            // 
            this.prevButt.Location = new System.Drawing.Point(201, 82);
            this.prevButt.Name = "prevButt";
            this.prevButt.Size = new System.Drawing.Size(32, 23);
            this.prevButt.TabIndex = 3;
            this.prevButt.Text = "<";
            this.prevButt.UseVisualStyleBackColor = true;
            this.prevButt.Click += new System.EventHandler(this.prevButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 314);
            this.Controls.Add(this.prevButt);
            this.Controls.Add(this.nextButt);
            this.Controls.Add(this.enemyImg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemyImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyImg;
        private System.Windows.Forms.Button prevButt;
        private System.Windows.Forms.Button nextButt;
    }
}

