namespace EjerciciosPracticos
{
    partial class ConvertirDeCentigradosAFahrenheitFunciones
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
            this.CentigradostextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FahrenheittextBox = new System.Windows.Forms.TextBox();
            this.Convertirbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centigrados:";
            // 
            // CentigradostextBox
            // 
            this.CentigradostextBox.Location = new System.Drawing.Point(84, 36);
            this.CentigradostextBox.Name = "CentigradostextBox";
            this.CentigradostextBox.Size = new System.Drawing.Size(100, 20);
            this.CentigradostextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrenheit:";
            // 
            // FahrenheittextBox
            // 
            this.FahrenheittextBox.Location = new System.Drawing.Point(84, 75);
            this.FahrenheittextBox.Name = "FahrenheittextBox";
            this.FahrenheittextBox.ReadOnly = true;
            this.FahrenheittextBox.Size = new System.Drawing.Size(100, 20);
            this.FahrenheittextBox.TabIndex = 3;
            // 
            // Convertirbutton
            // 
            this.Convertirbutton.Location = new System.Drawing.Point(98, 147);
            this.Convertirbutton.Name = "Convertirbutton";
            this.Convertirbutton.Size = new System.Drawing.Size(75, 23);
            this.Convertirbutton.TabIndex = 4;
            this.Convertirbutton.Text = "Convertir";
            this.Convertirbutton.UseVisualStyleBackColor = true;
            this.Convertirbutton.Click += new System.EventHandler(this.Convertirbutton_Click);
            // 
            // ConvertirDeCentigradosAFahrenheitFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Convertirbutton);
            this.Controls.Add(this.FahrenheittextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CentigradostextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConvertirDeCentigradosAFahrenheitFunciones";
            this.Text = "Convertir de centigrados a fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CentigradostextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FahrenheittextBox;
        private System.Windows.Forms.Button Convertirbutton;
    }
}