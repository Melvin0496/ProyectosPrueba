namespace EjerciciosPracticos
{
    partial class PromedioDeEdad
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
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PromediotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MayortextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MenortextBox = new System.Windows.Forms.TextBox();
            this.Presionarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edades:";
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.Location = new System.Drawing.Point(75, 58);
            this.EdadtextBox.Multiline = true;
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(100, 20);
            this.EdadtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promedio:";
            // 
            // PromediotextBox
            // 
            this.PromediotextBox.Location = new System.Drawing.Point(75, 96);
            this.PromediotextBox.Name = "PromediotextBox";
            this.PromediotextBox.ReadOnly = true;
            this.PromediotextBox.Size = new System.Drawing.Size(100, 20);
            this.PromediotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mayor:";
            // 
            // MayortextBox
            // 
            this.MayortextBox.Location = new System.Drawing.Point(75, 138);
            this.MayortextBox.Name = "MayortextBox";
            this.MayortextBox.ReadOnly = true;
            this.MayortextBox.Size = new System.Drawing.Size(100, 20);
            this.MayortextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Menor:";
            // 
            // MenortextBox
            // 
            this.MenortextBox.Location = new System.Drawing.Point(75, 177);
            this.MenortextBox.Name = "MenortextBox";
            this.MenortextBox.ReadOnly = true;
            this.MenortextBox.Size = new System.Drawing.Size(100, 20);
            this.MenortextBox.TabIndex = 7;
            // 
            // Presionarbutton
            // 
            this.Presionarbutton.Location = new System.Drawing.Point(100, 223);
            this.Presionarbutton.Name = "Presionarbutton";
            this.Presionarbutton.Size = new System.Drawing.Size(75, 23);
            this.Presionarbutton.TabIndex = 8;
            this.Presionarbutton.Text = "Presionar";
            this.Presionarbutton.UseVisualStyleBackColor = true;
            this.Presionarbutton.Click += new System.EventHandler(this.Presionarbutton_Click);
            // 
            // PromedioDeEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Presionarbutton);
            this.Controls.Add(this.MenortextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MayortextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PromediotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.label1);
            this.Name = "PromedioDeEdad";
            this.Text = "Promedio de edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdadtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PromediotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MayortextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MenortextBox;
        private System.Windows.Forms.Button Presionarbutton;
    }
}