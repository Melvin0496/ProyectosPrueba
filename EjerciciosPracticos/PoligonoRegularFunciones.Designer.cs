namespace EjerciciosPracticos
{
    partial class PoligonoRegularFunciones
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
            this.NumerosLadostextBox = new System.Windows.Forms.TextBox();
            this.LongitudLadostextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros de lados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud del lado:";
            // 
            // NumerosLadostextBox
            // 
            this.NumerosLadostextBox.Location = new System.Drawing.Point(113, 46);
            this.NumerosLadostextBox.Name = "NumerosLadostextBox";
            this.NumerosLadostextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerosLadostextBox.TabIndex = 2;
            // 
            // LongitudLadostextBox
            // 
            this.LongitudLadostextBox.Location = new System.Drawing.Point(113, 85);
            this.LongitudLadostextBox.Name = "LongitudLadostextBox";
            this.LongitudLadostextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudLadostextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(113, 127);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.ReadOnly = true;
            this.ResultadotextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadotextBox.TabIndex = 5;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(100, 190);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 6;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // PoligonoRegularFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LongitudLadostextBox);
            this.Controls.Add(this.NumerosLadostextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PoligonoRegularFunciones";
            this.Text = "Poligono regular funciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumerosLadostextBox;
        private System.Windows.Forms.TextBox LongitudLadostextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}