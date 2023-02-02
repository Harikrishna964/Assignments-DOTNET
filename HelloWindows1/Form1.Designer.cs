namespace HelloWindows1
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
            this.btnhi = new System.Windows.Forms.Button();
            this.btnhello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnhi
            // 
            this.btnhi.Location = new System.Drawing.Point(304, 125);
            this.btnhi.Name = "btnhi";
            this.btnhi.Size = new System.Drawing.Size(75, 23);
            this.btnhi.TabIndex = 0;
            this.btnhi.Text = "Button Hi";
            this.btnhi.UseVisualStyleBackColor = true;
            // 
            // btnhello
            // 
            this.btnhello.Location = new System.Drawing.Point(449, 125);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(75, 23);
            this.btnhello.TabIndex = 1;
            this.btnhello.Text = "Button Hello";
            this.btnhello.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(424, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhello);
            this.Controls.Add(this.btnhi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhi;
        private System.Windows.Forms.Button btnhello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
    }
}

