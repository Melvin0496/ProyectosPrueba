namespace EjerciciosPracticos
{
    partial class PoligonoRegular
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
            this.NumerosDeLadostextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LongitudDelLadotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PerimetrotextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero De Lados:";
            // 
            // NumerosDeLadostextBox
            // 
            this.NumerosDeLadostextBox.Location = new System.Drawing.Point(111, 40);
            this.NumerosDeLadostextBox.Name = "NumerosDeLadostextBox";
            this.NumerosDeLadostextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerosDeLadostextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logitud Del Lado:";
            // 
            // LongitudDelLadotextBox
            // 
            this.LongitudDelLadotextBox.Location = new System.Drawing.Point(111, 75);
            this.LongitudDelLadotextBox.Name = "LongitudDelLadotextBox";
            this.LongitudDelLadotextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudDelLadotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Perimetro:";
            // 
            // PerimetrotextBox
            // 
            this.PerimetrotextBox.Location = new System.Drawing.Point(111, 116);
            this.PerimetrotextBox.Name = "PerimetrotextBox";
            this.PerimetrotextBox.Size = new System.Drawing.Size(100, 20);
            this.PerimetrotextBox.TabIndex = 5;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(101, 182);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 6;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // PoligonoRegular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.PerimetrotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LongitudDelLadotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumerosDeLadostextBox);
            this.Controls.Add(this.label1);
            this.Name = "PoligonoRegular";
            this.Text = "Poligono Regular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumerosDeLadostextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LongitudDelLadotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PerimetrotextBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}