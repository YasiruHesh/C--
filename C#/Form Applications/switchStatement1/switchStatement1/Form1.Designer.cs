namespace switchStatement1
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.SelectClass = new System.Windows.Forms.Button();
            this.lblout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter your child age:";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(240, 27);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 1;
            // 
            // SelectClass
            // 
            this.SelectClass.Location = new System.Drawing.Point(169, 98);
            this.SelectClass.Name = "SelectClass";
            this.SelectClass.Size = new System.Drawing.Size(114, 39);
            this.SelectClass.TabIndex = 2;
            this.SelectClass.Text = "Find Class";
            this.SelectClass.UseVisualStyleBackColor = true;
            this.SelectClass.Click += new System.EventHandler(this.SelectClass_Click);
            // 
            // lblout
            // 
            this.lblout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblout.Location = new System.Drawing.Point(102, 178);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(290, 65);
            this.lblout.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 298);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.SelectClass);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button SelectClass;
        private System.Windows.Forms.Label lblout;
    }
}

