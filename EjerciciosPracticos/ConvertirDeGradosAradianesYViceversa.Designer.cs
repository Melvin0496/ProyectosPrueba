namespace EjerciciosPracticos
{
    partial class ConvertirDeGradosAradianesYViceversa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GradosARadianesradioButton = new System.Windows.Forms.RadioButton();
            this.RadianesAGradosradioButton = new System.Windows.Forms.RadioButton();
            this.Empezarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadianesAGradosradioButton);
            this.groupBox1.Controls.Add(this.GradosARadianesradioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Que desea convertir?";
            // 
            // GradosARadianesradioButton
            // 
            this.GradosARadianesradioButton.AutoSize = true;
            this.GradosARadianesradioButton.Location = new System.Drawing.Point(80, 19);
            this.GradosARadianesradioButton.Name = "GradosARadianesradioButton";
            this.GradosARadianesradioButton.Size = new System.Drawing.Size(111, 17);
            this.GradosARadianesradioButton.TabIndex = 0;
            this.GradosARadianesradioButton.TabStop = true;
            this.GradosARadianesradioButton.Text = "Grados a radianes";
            this.GradosARadianesradioButton.UseVisualStyleBackColor = true;
            // 
            // RadianesAGradosradioButton
            // 
            this.RadianesAGradosradioButton.AutoSize = true;
            this.RadianesAGradosradioButton.Location = new System.Drawing.Point(80, 51);
            this.RadianesAGradosradioButton.Name = "RadianesAGradosradioButton";
            this.RadianesAGradosradioButton.Size = new System.Drawing.Size(114, 17);
            this.RadianesAGradosradioButton.TabIndex = 1;
            this.RadianesAGradosradioButton.TabStop = true;
            this.RadianesAGradosradioButton.Text = "Radianes a grados";
            this.RadianesAGradosradioButton.UseVisualStyleBackColor = true;
            // 
            // Empezarbutton
            // 
            this.Empezarbutton.Location = new System.Drawing.Point(104, 182);
            this.Empezarbutton.Name = "Empezarbutton";
            this.Empezarbutton.Size = new System.Drawing.Size(75, 23);
            this.Empezarbutton.TabIndex = 1;
            this.Empezarbutton.Text = "Empezar";
            this.Empezarbutton.UseVisualStyleBackColor = true;
            this.Empezarbutton.Click += new System.EventHandler(this.Empezarbutton_Click);
            // 
            // ConvertirDeGradosAradianesYViceversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Empezarbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConvertirDeGradosAradianesYViceversa";
            this.Text = "Convertir de grados a radianes y viceversa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadianesAGradosradioButton;
        private System.Windows.Forms.RadioButton GradosARadianesradioButton;
        private System.Windows.Forms.Button Empezarbutton;
    }
}