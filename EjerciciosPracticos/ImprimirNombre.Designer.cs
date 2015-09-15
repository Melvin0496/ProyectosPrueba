namespace EjerciciosPracticos
{
    partial class ImprimirNombre
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
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Presionarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(112, 51);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(35, 13);
            this.Nombrelabel.TabIndex = 0;
            this.Nombrelabel.Text = "label1";
            // 
            // Presionarbutton
            // 
            this.Presionarbutton.Location = new System.Drawing.Point(94, 132);
            this.Presionarbutton.Name = "Presionarbutton";
            this.Presionarbutton.Size = new System.Drawing.Size(75, 23);
            this.Presionarbutton.TabIndex = 1;
            this.Presionarbutton.Text = "Presionar";
            this.Presionarbutton.UseVisualStyleBackColor = true;
            this.Presionarbutton.Click += new System.EventHandler(this.Presionarbutton_Click);
            // 
            // ImprimirNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Presionarbutton);
            this.Controls.Add(this.Nombrelabel);
            this.Name = "ImprimirNombre";
            this.Text = "ImprimirNombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Button Presionarbutton;
    }
}