namespace BIBLIOTECA
{
    partial class FrmAlta
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
            LblTitulo = new Label();
            txtTitulo = new TextBox();
            txtEditorial = new TextBox();
            LblEditorial = new Label();
            txtAutor = new TextBox();
            LblAutor = new Label();
            label1 = new Label();
            chkNuevo = new CheckBox();
            label2 = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCargarFoto = new Button();
            picPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPortada).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 14F);
            LblTitulo.Location = new Point(131, 116);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(87, 38);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(281, 123);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(150, 31);
            txtTitulo.TabIndex = 1;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(281, 271);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(150, 31);
            txtEditorial.TabIndex = 3;
            // 
            // LblEditorial
            // 
            LblEditorial.AutoSize = true;
            LblEditorial.Font = new Font("Segoe UI", 14F);
            LblEditorial.Location = new Point(131, 264);
            LblEditorial.Name = "LblEditorial";
            LblEditorial.Size = new Size(117, 38);
            LblEditorial.TabIndex = 2;
            LblEditorial.Text = "Editorial";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(281, 195);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(150, 31);
            txtAutor.TabIndex = 5;
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Font = new Font("Segoe UI", 14F);
            LblAutor.Location = new Point(131, 188);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(86, 38);
            LblAutor.TabIndex = 4;
            LblAutor.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(131, 336);
            label1.Name = "label1";
            label1.Size = new Size(98, 38);
            label1.TabIndex = 6;
            label1.Text = "Nuevo";
            // 
            // chkNuevo
            // 
            chkNuevo.AutoSize = true;
            chkNuevo.Location = new Point(281, 345);
            chkNuevo.Name = "chkNuevo";
            chkNuevo.Size = new Size(22, 21);
            chkNuevo.TabIndex = 7;
            chkNuevo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(574, 115);
            label2.Name = "label2";
            label2.Size = new Size(174, 38);
            label2.TabIndex = 8;
            label2.Text = "Foto Portada";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(131, 445);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 88);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(320, 445);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 88);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(496, 445);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(184, 88);
            btnCargarFoto.TabIndex = 11;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // picPortada
            // 
            picPortada.Location = new Point(574, 169);
            picPortada.Name = "picPortada";
            picPortada.Size = new Size(174, 197);
            picPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            picPortada.TabIndex = 12;
            picPortada.TabStop = false;
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 602);
            Controls.Add(picPortada);
            Controls.Add(btnCargarFoto);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(chkNuevo);
            Controls.Add(label1);
            Controls.Add(txtAutor);
            Controls.Add(LblAutor);
            Controls.Add(txtEditorial);
            Controls.Add(LblEditorial);
            Controls.Add(txtTitulo);
            Controls.Add(LblTitulo);
            Name = "FrmAlta";
            Text = "Alta de libros";
            Load += FrmAlta_Load;
            ((System.ComponentModel.ISupportInitialize)picPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private TextBox txtTitulo;
        private TextBox txtEditorial;
        private Label LblEditorial;
        private TextBox txtAutor;
        private Label LblAutor;
        private Label label1;
        private CheckBox chkNuevo;
        private Label label2;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCargarFoto;
        private PictureBox picPortada;
    }
}