namespace ProyectoFinal
{
    partial class FormBiblioteca
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CbBuscarLibro = new ComboBox();
            CbBuscarAutor = new ComboBox();
            BtnBuscarLibro = new Button();
            BtnBuscarAutor = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtLibrosEncontrados = new TextBox();
            TxtAutor = new TextBox();
            TxtUbicacion = new TextBox();
            TxtCantidadLibros = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 23);
            label1.Name = "label1";
            label1.Size = new Size(270, 36);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca España ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 159);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 1;
            label2.Text = "Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 196);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 2;
            label3.Text = "Autor ";
            // 
            // CbBuscarLibro
            // 
            CbBuscarLibro.FormattingEnabled = true;
            CbBuscarLibro.Items.AddRange(new object[] { "El viejo y el mar ", "Viaje al centro de la tierra", "Harry Potter", "Don Quijote de la mancha " });
            CbBuscarLibro.Location = new Point(315, 158);
            CbBuscarLibro.Name = "CbBuscarLibro";
            CbBuscarLibro.Size = new Size(121, 23);
            CbBuscarLibro.TabIndex = 3;
            // 
            // CbBuscarAutor
            // 
            CbBuscarAutor.FormattingEnabled = true;
            CbBuscarAutor.Items.AddRange(new object[] { "Ernest Hemingway", "Julio Verne", "J.K: Rowling", "Miguel De Cervantes" });
            CbBuscarAutor.Location = new Point(315, 198);
            CbBuscarAutor.Name = "CbBuscarAutor";
            CbBuscarAutor.Size = new Size(121, 23);
            CbBuscarAutor.TabIndex = 4;
            // 
            // BtnBuscarLibro
            // 
            BtnBuscarLibro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscarLibro.Location = new Point(488, 158);
            BtnBuscarLibro.Name = "BtnBuscarLibro";
            BtnBuscarLibro.Size = new Size(75, 28);
            BtnBuscarLibro.TabIndex = 5;
            BtnBuscarLibro.Text = "Buscar";
            BtnBuscarLibro.UseVisualStyleBackColor = true;
            BtnBuscarLibro.Click += BtnBuscarLibro_Click;
            // 
            // BtnBuscarAutor
            // 
            BtnBuscarAutor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscarAutor.Location = new Point(488, 196);
            BtnBuscarAutor.Name = "BtnBuscarAutor";
            BtnBuscarAutor.Size = new Size(75, 27);
            BtnBuscarAutor.TabIndex = 6;
            BtnBuscarAutor.Text = "Buscar ";
            BtnBuscarAutor.UseVisualStyleBackColor = true;
            BtnBuscarAutor.Click += BtnBuscarAutor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 345);
            label4.Name = "label4";
            label4.Size = new Size(156, 22);
            label4.TabIndex = 7;
            label4.Text = "Libro Encontrado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(267, 347);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 8;
            label5.Text = "Autor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(413, 347);
            label6.Name = "label6";
            label6.Size = new Size(91, 22);
            label6.TabIndex = 9;
            label6.Text = "Ubicacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 352);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 10;
            // 
            // TxtLibrosEncontrados
            // 
            TxtLibrosEncontrados.Location = new Point(62, 372);
            TxtLibrosEncontrados.Name = "TxtLibrosEncontrados";
            TxtLibrosEncontrados.Size = new Size(100, 23);
            TxtLibrosEncontrados.TabIndex = 11;
            // 
            // TxtAutor
            // 
            TxtAutor.Location = new Point(243, 372);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(100, 23);
            TxtAutor.TabIndex = 12;
            // 
            // TxtUbicacion
            // 
            TxtUbicacion.Location = new Point(413, 372);
            TxtUbicacion.Name = "TxtUbicacion";
            TxtUbicacion.Size = new Size(100, 23);
            TxtUbicacion.TabIndex = 13;
            // 
            // TxtCantidadLibros
            // 
            TxtCantidadLibros.Location = new Point(610, 372);
            TxtCantidadLibros.Name = "TxtCantidadLibros";
            TxtCantidadLibros.Size = new Size(100, 23);
            TxtCantidadLibros.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(595, 345);
            label8.Name = "label8";
            label8.Size = new Size(148, 22);
            label8.TabIndex = 15;
            label8.Text = "Cantidad Libros ";
            // 
            // FormBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(TxtCantidadLibros);
            Controls.Add(TxtUbicacion);
            Controls.Add(TxtAutor);
            Controls.Add(TxtLibrosEncontrados);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnBuscarAutor);
            Controls.Add(BtnBuscarLibro);
            Controls.Add(CbBuscarAutor);
            Controls.Add(CbBuscarLibro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBiblioteca";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox CbBuscarLibro;
        private ComboBox CbBuscarAutor;
        private Button BtnBuscarLibro;
        private Button BtnBuscarAutor;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtLibrosEncontrados;
        private TextBox TxtAutor;
        private TextBox TxtUbicacion;
        private TextBox TxtCantidadLibros;
        private Label label8;
    }
}