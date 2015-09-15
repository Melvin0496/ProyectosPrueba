namespace EjerciciosPracticos
{
    partial class ImpuestoDeUnProducto
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
            this.ProductotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ITBIStextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioNetotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(80, 27);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(80, 90);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ITBIS:";
            // 
            // ITBIStextBox
            // 
            this.ITBIStextBox.Location = new System.Drawing.Point(80, 123);
            this.ITBIStextBox.Name = "ITBIStextBox";
            this.ITBIStextBox.ReadOnly = true;
            this.ITBIStextBox.Size = new System.Drawing.Size(100, 20);
            this.ITBIStextBox.TabIndex = 4;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(105, 213);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 6;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio Neto:";
            // 
            // PrecioNetotextBox
            // 
            this.PrecioNetotextBox.Location = new System.Drawing.Point(80, 160);
            this.PrecioNetotextBox.Name = "PrecioNetotextBox";
            this.PrecioNetotextBox.ReadOnly = true;
            this.PrecioNetotextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioNetotextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo:";
            // 
            // TipotextBox
            // 
            this.TipotextBox.Location = new System.Drawing.Point(80, 58);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(100, 20);
            this.TipotextBox.TabIndex = 2;
            // 
            // ImpuestoDeUnProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TipotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecioNetotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.ITBIStextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductotextBox);
            this.Controls.Add(this.label1);
            this.Name = "ImpuestoDeUnProducto";
            this.Text = "Impuesto de un producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ITBIStextBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioNetotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TipotextBox;
    }
}