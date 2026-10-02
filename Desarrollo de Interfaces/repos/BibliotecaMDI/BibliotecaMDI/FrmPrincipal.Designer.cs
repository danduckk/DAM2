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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            ficheroToolStripMenuItem = new ToolStripMenuItem();
            MnuAlta = new ToolStripMenuItem();
            MnuConsulta = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuSalir = new ToolStripMenuItem();
            button1 = new Button();
            ofdFoto = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            lblHora = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            button1.Location = new Point(574, 256);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "openFileDialog1";
            ofdFoto.HelpRequest += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblHora });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblHora
            // 
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(739, 25);
            lblHora.Spring = true;
            lblHora.Text = "toolStripStatusLabel1";
            lblHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // frmPrincipal
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Gestión Biblioteca";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private OpenFileDialog ofdFoto;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}
