namespace GetPercentage
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
            this.outPut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ud = new System.Windows.Forms.RadioButton();
            this.Pd = new System.Windows.Forms.RadioButton();
            this.CW = new System.Windows.Forms.RadioButton();
            this.EX = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // outPut
            // 
            this.outPut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outPut.Location = new System.Drawing.Point(120, 148);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(118, 41);
            this.outPut.TabIndex = 0;
            this.outPut.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ud);
            this.groupBox1.Controls.Add(this.Pd);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EX);
            this.groupBox2.Controls.Add(this.CW);
            this.groupBox2.Location = new System.Drawing.Point(203, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assesment Type";
            // 
            // Ud
            // 
            this.Ud.AutoSize = true;
            this.Ud.Location = new System.Drawing.Point(26, 19);
            this.Ud.Name = "Ud";
            this.Ud.Size = new System.Drawing.Size(96, 17);
            this.Ud.TabIndex = 3;
            this.Ud.TabStop = true;
            this.Ud.Text = "Undergraduate";
            this.Ud.UseVisualStyleBackColor = true;
            // 
            // Pd
            // 
            this.Pd.AutoSize = true;
            this.Pd.Location = new System.Drawing.Point(26, 49);
            this.Pd.Name = "Pd";
            this.Pd.Size = new System.Drawing.Size(88, 17);
            this.Pd.TabIndex = 4;
            this.Pd.TabStop = true;
            this.Pd.Text = "Postgraduate";
            this.Pd.UseVisualStyleBackColor = true;
            // 
            // CW
            // 
            this.CW.AutoSize = true;
            this.CW.Location = new System.Drawing.Point(34, 19);
            this.CW.Name = "CW";
            this.CW.Size = new System.Drawing.Size(87, 17);
            this.CW.TabIndex = 5;
            this.CW.TabStop = true;
            this.CW.Text = "Course Work";
            this.CW.UseVisualStyleBackColor = true;
            this.CW.CheckedChanged += new System.EventHandler(this.CW_CheckedChanged);
            // 
            // EX
            // 
            this.EX.AutoSize = true;
            this.EX.Location = new System.Drawing.Point(34, 49);
            this.EX.Name = "EX";
            this.EX.Size = new System.Drawing.Size(82, 17);
            this.EX.TabIndex = 6;
            this.EX.TabStop = true;
            this.EX.Text = "Examination";
            this.EX.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outPut);
            this.Name = "Form1";
            this.Text = "Percentage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outPut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ud;
        private System.Windows.Forms.RadioButton Pd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton EX;
        private System.Windows.Forms.RadioButton CW;
    }
}

