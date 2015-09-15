namespace EjerciciosPracticos
{
    partial class NumeroParImpar
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
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.Presionabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite un Numero:";
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(110, 33);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerotextBox.TabIndex = 1;
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.Location = new System.Drawing.Point(116, 90);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(35, 13);
            this.Resultadolabel.TabIndex = 2;
            this.Resultadolabel.Text = "label2";
            // 
            // Presionabutton
            // 
            this.Presionabutton.Location = new System.Drawing.Point(110, 153);
            this.Presionabutton.Name = "Presionabutton";
            this.Presionabutton.Size = new System.Drawing.Size(75, 23);
            this.Presionabutton.TabIndex = 3;
            this.Presionabutton.Text = "Presiona";
            this.Presionabutton.UseVisualStyleBackColor = true;
            this.Presionabutton.Click += new System.EventHandler(this.Presionabutton_Click);
            // 
            // NumeroParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Presionabutton);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.label1);
            this.Name = "NumeroParImpar";
            this.Text = "Numero Par o Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label Resultadolabel;
        private System.Windows.Forms.Button Presionabutton;
    }
}