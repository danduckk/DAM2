namespace Trivial
{
    partial class Capitales
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
            menuStrip1 = new MenuStrip();
            partidaToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nombreCapitalesToolStripMenuItem = new ToolStripMenuItem();
            nombrePaisesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            multiplesOpcionesToolStripMenuItem = new ToolStripMenuItem();
            escribirRespuestaToolStripMenuItem = new ToolStripMenuItem();
            lbPais = new Label();
            lbCapital = new Label();
            btnSiguiente = new Button();
            btnSalir = new Button();
            lblPregunta = new Label();
            lblOpcion4 = new Label();
            lblOpcion3 = new Label();
            lblOpcion2 = new Label();
            lblOpcion1 = new Label();
            lblResultado = new Label();
            lblPorcentaje = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { partidaToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(758, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // partidaToolStripMenuItem
            // 
            partidaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            partidaToolStripMenuItem.Size = new Size(56, 20);
            partidaToolStripMenuItem.Text = "Partida";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(180, 22);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += nuevaToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreCapitalesToolStripMenuItem, nombrePaisesToolStripMenuItem, toolStripSeparator2, multiplesOpcionesToolStripMenuItem, escribirRespuestaToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nombreCapitalesToolStripMenuItem
            // 
            nombreCapitalesToolStripMenuItem.Name = "nombreCapitalesToolStripMenuItem";
            nombreCapitalesToolStripMenuItem.Size = new Size(174, 22);
            nombreCapitalesToolStripMenuItem.Text = "Nombre Capitales";
            // 
            // nombrePaisesToolStripMenuItem
            // 
            nombrePaisesToolStripMenuItem.Name = "nombrePaisesToolStripMenuItem";
            nombrePaisesToolStripMenuItem.Size = new Size(174, 22);
            nombrePaisesToolStripMenuItem.Text = "Nombre Paises";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(171, 6);
            // 
            // multiplesOpcionesToolStripMenuItem
            // 
            multiplesOpcionesToolStripMenuItem.Name = "multiplesOpcionesToolStripMenuItem";
            multiplesOpcionesToolStripMenuItem.Size = new Size(174, 22);
            multiplesOpcionesToolStripMenuItem.Text = "Multiples opciones";
            // 
            // escribirRespuestaToolStripMenuItem
            // 
            escribirRespuestaToolStripMenuItem.Name = "escribirRespuestaToolStripMenuItem";
            escribirRespuestaToolStripMenuItem.Size = new Size(174, 22);
            escribirRespuestaToolStripMenuItem.Text = "Escribir respuesta";
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Location = new Point(12, 43);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(31, 15);
            lbPais.TabIndex = 2;
            lbPais.Text = "Pais:";
            // 
            // lbCapital
            // 
            lbCapital.AutoSize = true;
            lbCapital.Location = new Point(12, 120);
            lbCapital.Name = "lbCapital";
            lbCapital.Size = new Size(47, 15);
            lbCapital.TabIndex = 3;
            lbCapital.Text = "Capital:";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(12, 373);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(142, 23);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblPregunta
            // 
            lblPregunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPregunta.BackColor = SystemColors.ControlLightLight;
            lblPregunta.BorderStyle = BorderStyle.Fixed3D;
            lblPregunta.Font = new Font("Segoe UI", 20F);
            lblPregunta.Location = new Point(12, 68);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(729, 39);
            lblPregunta.TabIndex = 10;
            lblPregunta.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOpcion4
            // 
            lblOpcion4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOpcion4.BackColor = SystemColors.ControlLightLight;
            lblOpcion4.BorderStyle = BorderStyle.Fixed3D;
            lblOpcion4.Font = new Font("Segoe UI", 20F);
            lblOpcion4.Location = new Point(12, 308);
            lblOpcion4.Name = "lblOpcion4";
            lblOpcion4.Size = new Size(729, 39);
            lblOpcion4.TabIndex = 11;
            lblOpcion4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOpcion3
            // 
            lblOpcion3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOpcion3.BackColor = SystemColors.ControlLightLight;
            lblOpcion3.BorderStyle = BorderStyle.Fixed3D;
            lblOpcion3.Font = new Font("Segoe UI", 20F);
            lblOpcion3.Location = new Point(12, 253);
            lblOpcion3.Name = "lblOpcion3";
            lblOpcion3.Size = new Size(729, 39);
            lblOpcion3.TabIndex = 12;
            lblOpcion3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOpcion2
            // 
            lblOpcion2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOpcion2.BackColor = SystemColors.ControlLightLight;
            lblOpcion2.BorderStyle = BorderStyle.Fixed3D;
            lblOpcion2.Font = new Font("Segoe UI", 20F);
            lblOpcion2.Location = new Point(12, 201);
            lblOpcion2.Name = "lblOpcion2";
            lblOpcion2.Size = new Size(729, 39);
            lblOpcion2.TabIndex = 13;
            lblOpcion2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOpcion1
            // 
            lblOpcion1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOpcion1.BackColor = SystemColors.ControlLightLight;
            lblOpcion1.BorderStyle = BorderStyle.Fixed3D;
            lblOpcion1.Font = new Font("Segoe UI", 20F);
            lblOpcion1.Location = new Point(12, 151);
            lblOpcion1.Name = "lblOpcion1";
            lblOpcion1.Size = new Size(729, 39);
            lblOpcion1.TabIndex = 14;
            lblOpcion1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.Blue;
            lblResultado.ForeColor = Color.Yellow;
            lblResultado.Location = new Point(616, 120);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(125, 23);
            lblResultado.TabIndex = 15;
            lblResultado.Text = "label1";
            lblResultado.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.BackColor = Color.Yellow;
            lblPorcentaje.BorderStyle = BorderStyle.Fixed3D;
            lblPorcentaje.ForeColor = SystemColors.ActiveCaptionText;
            lblPorcentaje.Location = new Point(616, 392);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(30, 25);
            lblPorcentaje.TabIndex = 16;
            lblPorcentaje.TextAlign = ContentAlignment.TopCenter;
            // 
            // Capitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 710);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblResultado);
            Controls.Add(lblOpcion1);
            Controls.Add(lblOpcion2);
            Controls.Add(lblOpcion3);
            Controls.Add(lblOpcion4);
            Controls.Add(lblPregunta);
            Controls.Add(btnSalir);
            Controls.Add(btnSiguiente);
            Controls.Add(lbCapital);
            Controls.Add(lbPais);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Capitales";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Capitales_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem partidaToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem nombreCapitalesToolStripMenuItem;
        private ToolStripMenuItem nombrePaisesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem multiplesOpcionesToolStripMenuItem;
        private ToolStripMenuItem escribirRespuestaToolStripMenuItem;
        private Label lbPais;
        private Label lbCapital;
        private Button btnSiguiente;
        private Button btnSalir;
        private Label lblPregunta;
        private Label lblOpcion4;
        private Label lblOpcion3;
        private Label lblOpcion2;
        private Label lblOpcion1;
        private Label lblResultado;
        private Label lblPorcentaje;
    }
}
