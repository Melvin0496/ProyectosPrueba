namespace EjerciciosPracticos
{
    partial class ConvertirDeGradosARadianesFunciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.RadianestextBox = new System.Windows.Forms.TextBox();
            this.Convertirbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados:";
            // 
            // GradostextBox
            // 
            this.GradostextBox.Location = new System.Drawing.Point(71, 34);
            this.GradostextBox.Name = "GradostextBox";
            this.GradostextBox.Size = new System.Drawing.Size(100, 20);
            this.GradostextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radianes:";
            // 
            // RadianestextBox
            // 
            this.RadianestextBox.Location = new System.Drawing.Point(71, 76);
            this.RadianestextBox.Name = "RadianestextBox";
            this.RadianestextBox.ReadOnly = true;
            this.RadianestextBox.Size = new System.Drawing.Size(100, 20);
            this.RadianestextBox.TabIndex = 3;
            // 
            // Convertirbutton
            // 
            this.Convertirbutton.Location = new System.Drawing.Point(105, 146);
            this.Convertirbutton.Name = "Convertirbutton";
            this.Convertirbutton.Size = new System.Drawing.Size(75, 23);
            this.Convertirbutton.TabIndex = 4;
            this.Convertirbutton.Text = "Convertir";
            this.Convertirbutton.UseVisualStyleBackColor = true;
            this.Convertirbutton.Click += new System.EventHandler(this.Convertirbutton_Click);
            // 
            // ConvertirDeGradosARadianesFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Convertirbutton);
            this.Controls.Add(this.RadianestextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradostextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConvertirDeGradosARadianesFunciones";
            this.Text = "Coversion de grados a radianes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GradostextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RadianestextBox;
        private System.Windows.Forms.Button Convertirbutton;
    }
}