namespace ProyectoFinalC_
{
    partial class FormsColas
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
            btnEncolar = new Button();
            btnDesencolar = new Button();
            txtElemento = new TextBox();
            lstCola = new ListBox();
            SuspendLayout();
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(62, 46);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(75, 23);
            btnEncolar.TabIndex = 0;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(62, 95);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(75, 23);
            btnDesencolar.TabIndex = 1;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesencolar_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(169, 66);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(100, 23);
            txtElemento.TabIndex = 2;
            // 
            // lstCola
            // 
            lstCola.FormattingEnabled = true;
            lstCola.ItemHeight = 15;
            lstCola.Location = new Point(169, 175);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(252, 169);
            lstCola.TabIndex = 3;
            // 
            // FormsColas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCola);
            Controls.Add(txtElemento);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Name = "FormsColas";
            Text = "FormsColas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncolar;
        private Button btnDesencolar;
        private TextBox txtElemento;
        private ListBox lstCola;
    }
}