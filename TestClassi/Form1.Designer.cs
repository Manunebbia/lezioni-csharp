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
            this.nextButt = new System.Windows.Forms.Button();
            this.prevButt = new System.Windows.Forms.Button();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.pPicture = new System.Windows.Forms.PictureBox();
            this.pHpLbl = new System.Windows.Forms.Label();
            this.pHpBar = new System.Windows.Forms.ProgressBar();
            this.pNameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ePicture = new System.Windows.Forms.PictureBox();
            this.eHpLbl = new System.Windows.Forms.Label();
            this.eHpBar = new System.Windows.Forms.ProgressBar();
            this.eNameLbl = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButt
            // 
            this.nextButt.Location = new System.Drawing.Point(100, 330);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(32, 23);
            this.nextButt.TabIndex = 2;
            this.nextButt.Text = ">";
            this.nextButt.UseVisualStyleBackColor = true;
            this.nextButt.Click += new System.EventHandler(this.nextButt_Click);
            // 
            // prevButt
            // 
            this.prevButt.Location = new System.Drawing.Point(52, 330);
            this.prevButt.Name = "prevButt";
            this.prevButt.Size = new System.Drawing.Size(32, 23);
            this.prevButt.TabIndex = 3;
            this.prevButt.Text = "<";
            this.prevButt.UseVisualStyleBackColor = true;
            this.prevButt.Click += new System.EventHandler(this.prevButt_Click);
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.pPicture);
            this.playerPanel.Controls.Add(this.pHpLbl);
            this.playerPanel.Controls.Add(this.pHpBar);
            this.playerPanel.Controls.Add(this.pNameLbl);
            this.playerPanel.Location = new System.Drawing.Point(11, 34);
            this.playerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(223, 237);
            this.playerPanel.TabIndex = 6;
            this.playerPanel.Tag = "";
            // 
            // pPicture
            // 
            this.pPicture.Location = new System.Drawing.Point(11, 83);
            this.pPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(202, 148);
            this.pPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPicture.TabIndex = 12;
            this.pPicture.TabStop = false;
            // 
            // pHpLbl
            // 
            this.pHpLbl.AutoSize = true;
            this.pHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHpLbl.Location = new System.Drawing.Point(8, 36);
            this.pHpLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pHpLbl.Name = "pHpLbl";
            this.pHpLbl.Size = new System.Drawing.Size(103, 20);
            this.pHpLbl.TabIndex = 11;
            this.pHpLbl.Text = "100/100 HP";
            // 
            // pHpBar
            // 
            this.pHpBar.Location = new System.Drawing.Point(11, 57);
            this.pHpBar.Margin = new System.Windows.Forms.Padding(2);
            this.pHpBar.Name = "pHpBar";
            this.pHpBar.Size = new System.Drawing.Size(202, 21);
            this.pHpBar.TabIndex = 10;
            this.pHpBar.Tag = "Test";
            this.pHpBar.Value = 100;
            // 
            // pNameLbl
            // 
            this.pNameLbl.AutoSize = true;
            this.pNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLbl.Location = new System.Drawing.Point(8, 7);
            this.pNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pNameLbl.Name = "pNameLbl";
            this.pNameLbl.Size = new System.Drawing.Size(115, 20);
            this.pNameLbl.TabIndex = 0;
            this.pNameLbl.Text = "Nome mostro";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ePicture);
            this.panel1.Controls.Add(this.eHpLbl);
            this.panel1.Controls.Add(this.eHpBar);
            this.panel1.Controls.Add(this.eNameLbl);
            this.panel1.Location = new System.Drawing.Point(238, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 237);
            this.panel1.TabIndex = 14;
            this.panel1.Tag = "";
            // 
            // ePicture
            // 
            this.ePicture.Location = new System.Drawing.Point(11, 83);
            this.ePicture.Margin = new System.Windows.Forms.Padding(2);
            this.ePicture.Name = "ePicture";
            this.ePicture.Size = new System.Drawing.Size(202, 148);
            this.ePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ePicture.TabIndex = 12;
            this.ePicture.TabStop = false;
            // 
            // eHpLbl
            // 
            this.eHpLbl.AutoSize = true;
            this.eHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eHpLbl.Location = new System.Drawing.Point(8, 36);
            this.eHpLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eHpLbl.Name = "eHpLbl";
            this.eHpLbl.Size = new System.Drawing.Size(103, 20);
            this.eHpLbl.TabIndex = 11;
            this.eHpLbl.Text = "100/100 HP";
            // 
            // eHpBar
            // 
            this.eHpBar.Location = new System.Drawing.Point(11, 57);
            this.eHpBar.Margin = new System.Windows.Forms.Padding(2);
            this.eHpBar.Name = "eHpBar";
            this.eHpBar.Size = new System.Drawing.Size(202, 21);
            this.eHpBar.TabIndex = 10;
            this.eHpBar.Tag = "Test";
            this.eHpBar.Value = 100;
            // 
            // eNameLbl
            // 
            this.eNameLbl.AutoSize = true;
            this.eNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNameLbl.Location = new System.Drawing.Point(8, 7);
            this.eNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eNameLbl.Name = "eNameLbl";
            this.eNameLbl.Size = new System.Drawing.Size(115, 20);
            this.eNameLbl.TabIndex = 0;
            this.eNameLbl.Text = "Nome mostro";
            // 
            // logs
            // 
            this.logs.FormattingEnabled = true;
            this.logs.Location = new System.Drawing.Point(465, 33);
            this.logs.Margin = new System.Windows.Forms.Padding(2);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(243, 238);
            this.logs.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(465, 301);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(166, 125);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 437);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.prevButt);
            this.Controls.Add(this.nextButt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button prevButt;
        private System.Windows.Forms.Button nextButt;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.PictureBox pPicture;
        private System.Windows.Forms.Label pHpLbl;
        private System.Windows.Forms.ProgressBar pHpBar;
        private System.Windows.Forms.Label pNameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ePicture;
        private System.Windows.Forms.Label eHpLbl;
        private System.Windows.Forms.ProgressBar eHpBar;
        private System.Windows.Forms.Label eNameLbl;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}

