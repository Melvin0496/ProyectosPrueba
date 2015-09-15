namespace EjerciciosPracticos
{
    partial class Area
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
            this.LongitudLadotextBox = new System.Windows.Forms.TextBox();
            this.NumeroLadostextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApotematextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AreatextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LongitudLadotextBox
            // 
            this.LongitudLadotextBox.Location = new System.Drawing.Point(113, 74);
            this.LongitudLadotextBox.Name = "LongitudLadotextBox";
            this.LongitudLadotextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudLadotextBox.TabIndex = 9;
            // 
            // NumeroLadostextBox
            // 
            this.NumeroLadostextBox.Location = new System.Drawing.Point(113, 39);
            this.NumeroLadostextBox.Name = "NumeroLadostextBox";
            this.NumeroLadostextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroLadostextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Longitud del lado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero de lados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apotema:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ApotematextBox
            // 
            this.ApotematextBox.Location = new System.Drawing.Point(113, 112);
            this.ApotematextBox.Name = "ApotematextBox";
            this.ApotematextBox.Size = new System.Drawing.Size(100, 20);
            this.ApotematextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Area:";
            // 
            // AreatextBox
            // 
            this.AreatextBox.Location = new System.Drawing.Point(113, 147);
            this.AreatextBox.Name = "AreatextBox";
            this.AreatextBox.ReadOnly = true;
            this.AreatextBox.Size = new System.Drawing.Size(100, 20);
            this.AreatextBox.TabIndex = 13;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(103, 201);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 14;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.AreatextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ApotematextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LongitudLadotextBox);
            this.Controls.Add(this.NumeroLadostextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Area";
            this.Text = "Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LongitudLadotextBox;
        private System.Windows.Forms.TextBox NumeroLadostextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApotematextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AreatextBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}