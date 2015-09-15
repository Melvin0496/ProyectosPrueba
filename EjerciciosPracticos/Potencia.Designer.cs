namespace EjerciciosPracticos
{
    partial class Potencia
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
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PotenciatextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExponentetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(78, 34);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potencia:";
            // 
            // PotenciatextBox
            // 
            this.PotenciatextBox.Location = new System.Drawing.Point(78, 100);
            this.PotenciatextBox.Name = "PotenciatextBox";
            this.PotenciatextBox.ReadOnly = true;
            this.PotenciatextBox.Size = new System.Drawing.Size(100, 20);
            this.PotenciatextBox.TabIndex = 3;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(103, 192);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 4;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exponente:";
            // 
            // ExponentetextBox
            // 
            this.ExponentetextBox.Location = new System.Drawing.Point(78, 67);
            this.ExponentetextBox.Name = "ExponentetextBox";
            this.ExponentetextBox.Size = new System.Drawing.Size(100, 20);
            this.ExponentetextBox.TabIndex = 6;
            // 
            // Potencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExponentetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.PotenciatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.label1);
            this.Name = "Potencia";
            this.Text = "Potencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PotenciatextBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExponentetextBox;
    }
}