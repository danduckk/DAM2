namespace BibliotecaMDI
{
    partial class frmPrincipal
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
            ficheroToolStripMenuItem = new ToolStripMenuItem();
            MnuAlta = new ToolStripMenuItem();
            MnuConsulta = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuSalir = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ficheroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ficheroToolStripMenuItem
            // 
            ficheroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuAlta, MnuConsulta, toolStripMenuItem1, MnuSalir });
            ficheroToolStripMenuItem.Name = "ficheroToolStripMenuItem";
            ficheroToolStripMenuItem.Size = new Size(85, 29);
            ficheroToolStripMenuItem.Text = "Fichero";
            // 
            // MnuAlta
            // 
            MnuAlta.Name = "MnuAlta";
            MnuAlta.ShortcutKeys = Keys.Control | Keys.A;
            MnuAlta.Size = new Size(270, 34);
            MnuAlta.Text = "Alta";
            MnuAlta.Click += MnuAlta_Click;
            // 
            // MnuConsulta
            // 
            MnuConsulta.Name = "MnuConsulta";
            MnuConsulta.ShortcutKeys = Keys.Control | Keys.C;
            MnuConsulta.Size = new Size(270, 34);
            MnuConsulta.Text = "Consulta";
            MnuConsulta.Click += MnuConsulta_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(267, 6);
            // 
            // MnuSalir
            // 
            MnuSalir.Name = "MnuSalir";
            MnuSalir.ShortcutKeys = Keys.Control | Keys.S;
            MnuSalir.Size = new Size(270, 34);
            MnuSalir.Text = "Salir";
            MnuSalir.Click += MnuSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(149, 313);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(404, 295);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmPrincipal
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheroToolStripMenuItem;
        private ToolStripMenuItem MnuAlta;
        private ToolStripMenuItem MnuConsulta;
        private ToolStripMenuItem MnuSalir;
        private ToolStripSeparator toolStripMenuItem1;
        private Button button1;
        private Button button2;
    }
}
