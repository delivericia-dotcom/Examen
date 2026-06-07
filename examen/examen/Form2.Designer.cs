namespace examen
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Textnota1 = new System.Windows.Forms.TextBox();
            this.Textnota2 = new System.Windows.Forms.TextBox();
            this.Textnota3 = new System.Windows.Forms.TextBox();
            this.Textnota4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Textnota1
            // 
            this.Textnota1.Location = new System.Drawing.Point(347, 46);
            this.Textnota1.Name = "Textnota1";
            this.Textnota1.Size = new System.Drawing.Size(100, 22);
            this.Textnota1.TabIndex = 1;
            this.Textnota1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Textnota2
            // 
            this.Textnota2.Location = new System.Drawing.Point(390, 85);
            this.Textnota2.Name = "Textnota2";
            this.Textnota2.Size = new System.Drawing.Size(100, 22);
            this.Textnota2.TabIndex = 2;
            // 
            // Textnota3
            // 
            this.Textnota3.Location = new System.Drawing.Point(359, 175);
            this.Textnota3.Name = "Textnota3";
            this.Textnota3.Size = new System.Drawing.Size(100, 22);
            this.Textnota3.TabIndex = 3;
            // 
            // Textnota4
            // 
            this.Textnota4.Location = new System.Drawing.Point(369, 224);
            this.Textnota4.Name = "Textnota4";
            this.Textnota4.Size = new System.Drawing.Size(100, 22);
            this.Textnota4.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Textnota4);
            this.Controls.Add(this.Textnota3);
            this.Controls.Add(this.Textnota2);
            this.Controls.Add(this.Textnota1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textnota1;
        private System.Windows.Forms.TextBox Textnota2;
        private System.Windows.Forms.TextBox Textnota3;
        private System.Windows.Forms.TextBox Textnota4;
    }
}