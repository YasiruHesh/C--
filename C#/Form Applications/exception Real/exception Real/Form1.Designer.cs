namespace exception_Real
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtNumirator = new System.Windows.Forms.TextBox();
            this.txtDenomirator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Numirator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Denominator";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(45, 253);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(35, 13);
            this.lblOut.TabIndex = 2;
            this.lblOut.Text = "label3";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(157, 131);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(176, 81);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtNumirator
            // 
            this.txtNumirator.Location = new System.Drawing.Point(263, 25);
            this.txtNumirator.Name = "txtNumirator";
            this.txtNumirator.Size = new System.Drawing.Size(100, 20);
            this.txtNumirator.TabIndex = 4;
            // 
            // txtDenomirator
            // 
            this.txtDenomirator.Location = new System.Drawing.Point(263, 81);
            this.txtDenomirator.Name = "txtDenomirator";
            this.txtDenomirator.Size = new System.Drawing.Size(100, 20);
            this.txtDenomirator.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 323);
            this.Controls.Add(this.txtDenomirator);
            this.Controls.Add(this.txtNumirator);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtNumirator;
        private System.Windows.Forms.TextBox txtDenomirator;
    }
}

