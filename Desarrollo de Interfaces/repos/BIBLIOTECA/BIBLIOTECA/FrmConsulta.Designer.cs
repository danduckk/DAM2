namespace BIBLIOTECA
{
    partial class FrmConsulta
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
            TipoConsulta = new GroupBox();
            rbEditorial = new RadioButton();
            rbAutor = new RadioButton();
            lsbTitulos = new ListBox();
            lsbAutorEditorial = new ListBox();
            LblTitulo = new Label();
            LblAutorEditorial = new Label();
            LblFotoPortada = new Label();
            TipoConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TipoConsulta
            // 
            TipoConsulta.Controls.Add(rbEditorial);
            TipoConsulta.Controls.Add(rbAutor);
            TipoConsulta.Location = new Point(46, 64);
            TipoConsulta.Name = "TipoConsulta";
            TipoConsulta.Size = new Size(300, 150);
            TipoConsulta.TabIndex = 0;
            TipoConsulta.TabStop = false;
            TipoConsulta.Text = "TipoConsulta";
            // 
            // rbEditorial
            // 
            rbEditorial.AutoSize = true;
            rbEditorial.Location = new Point(20, 95);
            rbEditorial.Name = "rbEditorial";
            rbEditorial.Size = new Size(101, 29);
            rbEditorial.TabIndex = 1;
            rbEditorial.TabStop = true;
            rbEditorial.Text = "Editorial";
            rbEditorial.UseVisualStyleBackColor = true;
            // 
            // rbAutor
            // 
            rbAutor.AutoSize = true;
            rbAutor.Location = new Point(20, 47);
            rbAutor.Name = "rbAutor";
            rbAutor.Size = new Size(82, 29);
            rbAutor.TabIndex = 0;
            rbAutor.TabStop = true;
            rbAutor.Text = "Autor";
            rbAutor.UseVisualStyleBackColor = true;
            // 
            // lsbTitulos
            // 
            lsbTitulos.FormattingEnabled = true;
            lsbTitulos.ItemHeight = 25;
            lsbTitulos.Location = new Point(46, 329);
            lsbTitulos.Name = "lsbTitulos";
            lsbTitulos.Size = new Size(182, 229);
            lsbTitulos.TabIndex = 1;
            lsbTitulos.DoubleClick += lsbTitulos_DoubleClick;
            // 
            // lsbAutorEditorial
            // 
            lsbAutorEditorial.FormattingEnabled = true;
            lsbAutorEditorial.ItemHeight = 25;
            lsbAutorEditorial.Location = new Point(308, 329);
            lsbAutorEditorial.Name = "lsbAutorEditorial";
            lsbAutorEditorial.Size = new Size(182, 229);
            lsbAutorEditorial.TabIndex = 2;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 14F);
            LblTitulo.Location = new Point(46, 272);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(87, 38);
            LblTitulo.TabIndex = 7;
            LblTitulo.Text = "Título";
            // 
            // LblAutorEditorial
            // 
            LblAutorEditorial.AutoSize = true;
            LblAutorEditorial.Font = new Font("Segoe UI", 14F);
            LblAutorEditorial.Location = new Point(277, 272);
            LblAutorEditorial.Name = "LblAutorEditorial";
            LblAutorEditorial.Size = new Size(213, 38);
            LblAutorEditorial.TabIndex = 8;
            LblAutorEditorial.Text = "Autor / Editorial";
            // 
            // LblFotoPortada
            // 
            LblFotoPortada.AutoSize = true;
            LblFotoPortada.Font = new Font("Segoe UI", 14F);
            LblFotoPortada.Location = new Point(580, 272);
            LblFotoPortada.Name = "LblFotoPortada";
            LblFotoPortada.Size = new Size(174, 38);
            LblFotoPortada.TabIndex = 9;
            LblFotoPortada.Text = "Foto Portada";
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(LblFotoPortada);
            Controls.Add(LblAutorEditorial);
            Controls.Add(LblTitulo);
            Controls.Add(lsbAutorEditorial);
            Controls.Add(lsbTitulos);
            Controls.Add(TipoConsulta);
            Name = "FrmConsulta";
            Text = "Consulta de Libros";
            Load += FrmConsulta_Load;
            TipoConsulta.ResumeLayout(false);
            TipoConsulta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox TipoConsulta;
        private RadioButton rbAutor;
        private RadioButton rbEditorial;
        private ListBox lsbTitulos;
        private ListBox lsbAutorEditorial;
        private Label LblTitulo;
        private Label LblAutorEditorial;
        private Label LblFotoPortada;
    }
}