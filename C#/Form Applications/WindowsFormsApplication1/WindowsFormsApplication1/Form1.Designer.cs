namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdiUG = new System.Windows.Forms.RadioButton();
            this.rdiPG = new System.Windows.Forms.RadioButton();
            this.rdiCW = new System.Windows.Forms.RadioButton();
            this.rdExam = new System.Windows.Forms.RadioButton();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdiPG);
            this.groupBox1.Controls.Add(this.rdiUG);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdExam);
            this.groupBox2.Controls.Add(this.rdiCW);
            this.groupBox2.Location = new System.Drawing.Point(265, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assessment Type";
            // 
            // rdiUG
            // 
            this.rdiUG.AutoSize = true;
            this.rdiUG.Location = new System.Drawing.Point(36, 19);
            this.rdiUG.Name = "rdiUG";
            this.rdiUG.Size = new System.Drawing.Size(96, 17);
            this.rdiUG.TabIndex = 2;
            this.rdiUG.TabStop = true;
            this.rdiUG.Text = "Undergraduate";
            this.rdiUG.UseVisualStyleBackColor = true;
            this.rdiUG.CheckedChanged += new System.EventHandler(this.rdiUG_CheckedChanged);
            // 
            // rdiPG
            // 
            this.rdiPG.AutoSize = true;
            this.rdiPG.Location = new System.Drawing.Point(36, 62);
            this.rdiPG.Name = "rdiPG";
            this.rdiPG.Size = new System.Drawing.Size(88, 17);
            this.rdiPG.TabIndex = 3;
            this.rdiPG.TabStop = true;
            this.rdiPG.Text = "Postgraduate";
            this.rdiPG.UseVisualStyleBackColor = true;
            this.rdiPG.CheckedChanged += new System.EventHandler(this.rdiPG_CheckedChanged);
            // 
            // rdiCW
            // 
            this.rdiCW.AutoSize = true;
            this.rdiCW.Location = new System.Drawing.Point(60, 19);
            this.rdiCW.Name = "rdiCW";
            this.rdiCW.Size = new System.Drawing.Size(83, 17);
            this.rdiCW.TabIndex = 3;
            this.rdiCW.TabStop = true;
            this.rdiCW.Text = "course work";
            this.rdiCW.UseVisualStyleBackColor = true;
            this.rdiCW.CheckedChanged += new System.EventHandler(this.rdiCW_CheckedChanged);
            // 
            // rdExam
            // 
            this.rdExam.AutoSize = true;
            this.rdExam.Location = new System.Drawing.Point(60, 62);
            this.rdExam.Name = "rdExam";
            this.rdExam.Size = new System.Drawing.Size(50, 17);
            this.rdExam.TabIndex = 4;
            this.rdExam.TabStop = true;
            this.rdExam.Text = "exam";
            this.rdExam.UseVisualStyleBackColor = true;
            this.rdExam.CheckedChanged += new System.EventHandler(this.rdExam_CheckedChanged);
            // 
            // lblOutPut
            // 
            this.lblOutPut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutPut.Location = new System.Drawing.Point(120, 234);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(222, 41);
            this.lblOutPut.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 319);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdiPG;
        private System.Windows.Forms.RadioButton rdiUG;
        private System.Windows.Forms.RadioButton rdExam;
        private System.Windows.Forms.RadioButton rdiCW;
        private System.Windows.Forms.Label lblOutPut;
    }
}

