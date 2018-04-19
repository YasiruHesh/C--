namespace array2
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
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(57, 24);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(171, 121);
            this.lstOut.TabIndex = 0;
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(197, 194);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(147, 75);
            this.btnArray.TabIndex = 1;
            this.btnArray.Text = "Submit";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 317);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.lstOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnArray;
    }
}

