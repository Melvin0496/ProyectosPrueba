namespace EjerciciosPracticos
{
    partial class GradosARadianes
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
            this.GradostextBox = new System.Windows.Forms.TextBox();
            this.Convertirbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados a Convertir:";
            // 
            // GradostextBox
            // 
            this.GradostextBox.Location = new System.Drawing.Point(116, 36);
            this.GradostextBox.Name = "GradostextBox";
            this.GradostextBox.Size = new System.Drawing.Size(100, 20);
            this.GradostextBox.TabIndex = 1;
            // 
            // Convertirbutton
            // 
            this.Convertirbutton.Location = new System.Drawing.Point(102, 131);
            this.Convertirbutton.Name = "Convertirbutton";
            this.Convertirbutton.Size = new System.Drawing.Size(75, 23);
            this.Convertirbutton.TabIndex = 2;
            this.Convertirbutton.Text = "Convertir";
            this.Convertirbutton.UseVisualStyleBackColor = true;
            this.Convertirbutton.Click += new System.EventHandler(this.Convertirbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(116, 68);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadotextBox.TabIndex = 4;
            // 
            // GradosARadianes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Convertirbutton);
            this.Controls.Add(this.GradostextBox);
            this.Controls.Add(this.label1);
            this.Name = "GradosARadianes";
            this.Text = "Grados A Radianes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GradostextBox;
        private System.Windows.Forms.Button Convertirbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultadotextBox;
    }
}