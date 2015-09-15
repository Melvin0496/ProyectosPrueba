namespace EjerciciosPracticos
{
    partial class PerimetroYArea
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
            this.PerimetroradioButton = new System.Windows.Forms.RadioButton();
            this.ArearadioButton = new System.Windows.Forms.RadioButton();
            this.Presionarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ArearadioButton);
            this.groupBox1.Controls.Add(this.PerimetroradioButton);
            this.groupBox1.Location = new System.Drawing.Point(80, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escoja una opcion";
            // 
            // PerimetroradioButton
            // 
            this.PerimetroradioButton.AutoSize = true;
            this.PerimetroradioButton.Location = new System.Drawing.Point(6, 19);
            this.PerimetroradioButton.Name = "PerimetroradioButton";
            this.PerimetroradioButton.Size = new System.Drawing.Size(63, 17);
            this.PerimetroradioButton.TabIndex = 1;
            this.PerimetroradioButton.TabStop = true;
            this.PerimetroradioButton.Text = "Primetro";
            this.PerimetroradioButton.UseVisualStyleBackColor = true;
            // 
            // ArearadioButton
            // 
            this.ArearadioButton.AutoSize = true;
            this.ArearadioButton.Location = new System.Drawing.Point(6, 42);
            this.ArearadioButton.Name = "ArearadioButton";
            this.ArearadioButton.Size = new System.Drawing.Size(47, 17);
            this.ArearadioButton.TabIndex = 2;
            this.ArearadioButton.TabStop = true;
            this.ArearadioButton.Text = "Area";
            this.ArearadioButton.UseVisualStyleBackColor = true;
            // 
            // Presionarbutton
            // 
            this.Presionarbutton.Location = new System.Drawing.Point(103, 193);
            this.Presionarbutton.Name = "Presionarbutton";
            this.Presionarbutton.Size = new System.Drawing.Size(75, 23);
            this.Presionarbutton.TabIndex = 1;
            this.Presionarbutton.Text = "Presionar";
            this.Presionarbutton.UseVisualStyleBackColor = true;
            this.Presionarbutton.Click += new System.EventHandler(this.Presionarbutton_Click);
            // 
            // PerimetroYArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Presionarbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "PerimetroYArea";
            this.Text = "Perimetro y area ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ArearadioButton;
        private System.Windows.Forms.RadioButton PerimetroradioButton;
        private System.Windows.Forms.Button Presionarbutton;
    }
}