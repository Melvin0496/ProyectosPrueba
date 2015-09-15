namespace EjerciciosPracticos
{
    partial class Perimetro
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
            this.NumeroLadostextBox = new System.Windows.Forms.TextBox();
            this.LongitudLadotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PerimetrotextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de lados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud del lado:";
            // 
            // NumeroLadostextBox
            // 
            this.NumeroLadostextBox.Location = new System.Drawing.Point(108, 33);
            this.NumeroLadostextBox.Name = "NumeroLadostextBox";
            this.NumeroLadostextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroLadostextBox.TabIndex = 2;
            // 
            // LongitudLadotextBox
            // 
            this.LongitudLadotextBox.Location = new System.Drawing.Point(108, 68);
            this.LongitudLadotextBox.Name = "LongitudLadotextBox";
            this.LongitudLadotextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudLadotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Perimetro:";
            // 
            // PerimetrotextBox
            // 
            this.PerimetrotextBox.Location = new System.Drawing.Point(108, 107);
            this.PerimetrotextBox.Name = "PerimetrotextBox";
            this.PerimetrotextBox.ReadOnly = true;
            this.PerimetrotextBox.Size = new System.Drawing.Size(100, 20);
            this.PerimetrotextBox.TabIndex = 5;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(108, 175);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 6;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Perimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.PerimetrotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LongitudLadotextBox);
            this.Controls.Add(this.NumeroLadostextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Perimetro";
            this.Text = "Perimetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroLadostextBox;
        private System.Windows.Forms.TextBox LongitudLadotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PerimetrotextBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}