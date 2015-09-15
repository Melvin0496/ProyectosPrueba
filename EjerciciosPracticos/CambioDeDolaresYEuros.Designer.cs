namespace EjerciciosPracticos
{
    partial class CambioDeDolaresYEuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioDeDolaresYEuros));
            this.DolaresradioButton = new System.Windows.Forms.RadioButton();
            this.EurosradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DolarestextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EurostextBox = new System.Windows.Forms.TextBox();
            this.Convertirbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DolaresradioButton
            // 
            this.DolaresradioButton.AutoSize = true;
            this.DolaresradioButton.Location = new System.Drawing.Point(6, 28);
            this.DolaresradioButton.Name = "DolaresradioButton";
            this.DolaresradioButton.Size = new System.Drawing.Size(61, 17);
            this.DolaresradioButton.TabIndex = 0;
            this.DolaresradioButton.TabStop = true;
            this.DolaresradioButton.Text = "Dolares";
            this.DolaresradioButton.UseVisualStyleBackColor = true;
            // 
            // EurosradioButton
            // 
            this.EurosradioButton.AutoSize = true;
            this.EurosradioButton.Location = new System.Drawing.Point(6, 63);
            this.EurosradioButton.Name = "EurosradioButton";
            this.EurosradioButton.Size = new System.Drawing.Size(52, 17);
            this.EurosradioButton.TabIndex = 1;
            this.EurosradioButton.TabStop = true;
            this.EurosradioButton.Text = "Euros";
            this.EurosradioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dolares:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DolaresradioButton);
            this.groupBox1.Controls.Add(this.EurosradioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambios Del Dia";
            // 
            // DolarestextBox
            // 
            this.DolarestextBox.Location = new System.Drawing.Point(64, 128);
            this.DolarestextBox.Name = "DolarestextBox";
            this.DolarestextBox.Size = new System.Drawing.Size(100, 20);
            this.DolarestextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Euros:";
            // 
            // EurostextBox
            // 
            this.EurostextBox.Location = new System.Drawing.Point(64, 158);
            this.EurostextBox.Name = "EurostextBox";
            this.EurostextBox.Size = new System.Drawing.Size(100, 20);
            this.EurostextBox.TabIndex = 6;
            // 
            // Convertirbutton
            // 
            this.Convertirbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Convertirbutton.BackgroundImage")));
            this.Convertirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Convertirbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Convertirbutton.Location = new System.Drawing.Point(91, 204);
            this.Convertirbutton.Name = "Convertirbutton";
            this.Convertirbutton.Size = new System.Drawing.Size(106, 34);
            this.Convertirbutton.TabIndex = 7;
            this.Convertirbutton.Text = "Cambiar";
            this.Convertirbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Convertirbutton.UseVisualStyleBackColor = true;
            this.Convertirbutton.Click += new System.EventHandler(this.Convertirbutton_Click);
            // 
            // CambioDeDolaresYEuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Convertirbutton);
            this.Controls.Add(this.EurostextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DolarestextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CambioDeDolaresYEuros";
            this.Text = "Cambio de dolares y euros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DolaresradioButton;
        private System.Windows.Forms.RadioButton EurosradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DolarestextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EurostextBox;
        private System.Windows.Forms.Button Convertirbutton;
    }
}