namespace ProyectoFinalC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            btnPilas = new Button();
            btnColas = new Button();
            btnADO = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(606, 109);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Grafos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(610, 61);
            button2.Name = "button2";
            button2.Size = new Size(71, 42);
            button2.TabIndex = 1;
            button2.Text = "Arbol Binario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPilas
            // 
            btnPilas.Location = new Point(606, 156);
            btnPilas.Name = "btnPilas";
            btnPilas.Size = new Size(75, 23);
            btnPilas.TabIndex = 2;
            btnPilas.Text = "Pilas";
            btnPilas.UseVisualStyleBackColor = true;
            btnPilas.Click += btnPilas_Click;
            // 
            // btnColas
            // 
            btnColas.Location = new Point(606, 185);
            btnColas.Name = "btnColas";
            btnColas.Size = new Size(75, 23);
            btnColas.TabIndex = 3;
            btnColas.Text = "Colas";
            btnColas.UseVisualStyleBackColor = true;
            btnColas.Click += btnColas_Click;
            // 
            // btnADO
            // 
            btnADO.Location = new Point(606, 226);
            btnADO.Name = "btnADO";
            btnADO.Size = new Size(75, 23);
            btnADO.TabIndex = 4;
            btnADO.Text = "button3";
            btnADO.UseVisualStyleBackColor = true;
            btnADO.Click += btnADO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnADO);
            Controls.Add(btnColas);
            Controls.Add(btnPilas);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnPilas;
        private Button btnColas;
        private Button btnADO;
    }
}