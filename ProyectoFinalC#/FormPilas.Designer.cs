namespace ProyectoFinalC_
{
    partial class FormPilas
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
            btnPush = new Button();
            btnPop = new Button();
            listBoxPila = new ListBox();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // btnPush
            // 
            btnPush.Location = new Point(12, 44);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(75, 23);
            btnPush.TabIndex = 0;
            btnPush.Text = "push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(12, 93);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(75, 23);
            btnPop.TabIndex = 1;
            btnPop.Text = "pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // listBoxPila
            // 
            listBoxPila.FormattingEnabled = true;
            listBoxPila.ItemHeight = 15;
            listBoxPila.Location = new Point(100, 169);
            listBoxPila.Name = "listBoxPila";
            listBoxPila.Size = new Size(383, 214);
            listBoxPila.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(134, 66);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 3;
            // 
            // FormPilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValor);
            Controls.Add(listBoxPila);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Name = "FormPilas";
            Text = "FormPilas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPush;
        private Button btnPop;
        private ListBox listBoxPila;
        private TextBox txtValor;
    }
}