namespace ProyectoFinalC_
{
    partial class FormGrafos
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
            btnAgregarVertice = new Button();
            btnAgregarArista = new Button();
            btnEliminarVertice = new Button();
            btnEncontrarCamino = new Button();
            btnRecorridoDFS = new Button();
            listGrafo = new ListBox();
            listBoxMatrizAdyacencia = new ListBox();
            listRecorridoDFS = new ListView();
            txtVertice = new TextBox();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtPeso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAgregarVertice
            // 
            btnAgregarVertice.Location = new Point(48, 35);
            btnAgregarVertice.Name = "btnAgregarVertice";
            btnAgregarVertice.Size = new Size(97, 23);
            btnAgregarVertice.TabIndex = 0;
            btnAgregarVertice.Text = "Agregar vertice";
            btnAgregarVertice.UseVisualStyleBackColor = true;
            btnAgregarVertice.Click += btnAgregarVertice_Click;
            // 
            // btnAgregarArista
            // 
            btnAgregarArista.Location = new Point(27, 104);
            btnAgregarArista.Name = "btnAgregarArista";
            btnAgregarArista.Size = new Size(97, 34);
            btnAgregarArista.TabIndex = 1;
            btnAgregarArista.Text = "Agregar arista";
            btnAgregarArista.UseVisualStyleBackColor = true;
            btnAgregarArista.Click += btnAgregarArista_Click;
            // 
            // btnEliminarVertice
            // 
            btnEliminarVertice.Location = new Point(538, 44);
            btnEliminarVertice.Name = "btnEliminarVertice";
            btnEliminarVertice.Size = new Size(97, 46);
            btnEliminarVertice.TabIndex = 2;
            btnEliminarVertice.Text = "Eliminar";
            btnEliminarVertice.UseVisualStyleBackColor = true;
            btnEliminarVertice.Click += btnEliminarVertice_Click;
            // 
            // btnEncontrarCamino
            // 
            btnEncontrarCamino.Location = new Point(538, 96);
            btnEncontrarCamino.Name = "btnEncontrarCamino";
            btnEncontrarCamino.Size = new Size(97, 42);
            btnEncontrarCamino.TabIndex = 3;
            btnEncontrarCamino.Text = "Encontrar Camino";
            btnEncontrarCamino.UseVisualStyleBackColor = true;
            btnEncontrarCamino.Click += btnEncontrarCamino_Click;
            // 
            // btnRecorridoDFS
            // 
            btnRecorridoDFS.Location = new Point(538, 154);
            btnRecorridoDFS.Name = "btnRecorridoDFS";
            btnRecorridoDFS.Size = new Size(97, 34);
            btnRecorridoDFS.TabIndex = 4;
            btnRecorridoDFS.Text = "Recorrido DFS";
            btnRecorridoDFS.UseVisualStyleBackColor = true;
            btnRecorridoDFS.Click += btnRecorridoDFS_Click;
            // 
            // listGrafo
            // 
            listGrafo.FormattingEnabled = true;
            listGrafo.ItemHeight = 15;
            listGrafo.Location = new Point(3, 272);
            listGrafo.Name = "listGrafo";
            listGrafo.Size = new Size(235, 169);
            listGrafo.TabIndex = 5;
            // 
            // listBoxMatrizAdyacencia
            // 
            listBoxMatrizAdyacencia.FormattingEnabled = true;
            listBoxMatrizAdyacencia.ItemHeight = 15;
            listBoxMatrizAdyacencia.Location = new Point(280, 272);
            listBoxMatrizAdyacencia.Name = "listBoxMatrizAdyacencia";
            listBoxMatrizAdyacencia.Size = new Size(228, 154);
            listBoxMatrizAdyacencia.TabIndex = 6;
            // 
            // listRecorridoDFS
            // 
            listRecorridoDFS.Location = new Point(553, 272);
            listRecorridoDFS.Name = "listRecorridoDFS";
            listRecorridoDFS.Size = new Size(235, 166);
            listRecorridoDFS.TabIndex = 7;
            listRecorridoDFS.UseCompatibleStateImageBehavior = false;
            // 
            // txtVertice
            // 
            txtVertice.Location = new Point(211, 35);
            txtVertice.Name = "txtVertice";
            txtVertice.Size = new Size(161, 23);
            txtVertice.TabIndex = 8;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(211, 95);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(100, 23);
            txtOrigen.TabIndex = 9;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(211, 124);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(100, 23);
            txtDestino.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(211, 165);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(57, 23);
            txtPeso.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 98);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 12;
            label1.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 127);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 168);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 14;
            label3.Text = "Peso";
            // 
            // FormGrafos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPeso);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(txtVertice);
            Controls.Add(listRecorridoDFS);
            Controls.Add(listBoxMatrizAdyacencia);
            Controls.Add(listGrafo);
            Controls.Add(btnRecorridoDFS);
            Controls.Add(btnEncontrarCamino);
            Controls.Add(btnEliminarVertice);
            Controls.Add(btnAgregarArista);
            Controls.Add(btnAgregarVertice);
            Name = "FormGrafos";
            Text = "FormGrafos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarVertice;
        private Button btnAgregarArista;
        private Button btnEliminarVertice;
        private Button btnEncontrarCamino;
        private Button btnRecorridoDFS;
        private ListBox listGrafo;
        private ListBox listBoxMatrizAdyacencia;
        private ListView listRecorridoDFS;
        private TextBox txtVertice;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtPeso;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}