namespace FormulariosHeredados
{
    partial class frmBase
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
            mnuAlta = new ToolStripMenuItem();
            mnuConsultaList = new ToolStripMenuItem();
            mnuConsultaTree = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAlta, mnuConsultaList, mnuConsultaTree, mnuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1038, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAlta
            // 
            mnuAlta.Name = "mnuAlta";
            mnuAlta.Size = new Size(59, 29);
            mnuAlta.Text = "Alta";
            // 
            // mnuConsultaList
            // 
            mnuConsultaList.Name = "mnuConsultaList";
            mnuConsultaList.Size = new Size(128, 29);
            mnuConsultaList.Text = "Consulta List";
            mnuConsultaList.Click += mnuConsultaList_Click;
            // 
            // mnuConsultaTree
            // 
            mnuConsultaTree.Name = "mnuConsultaTree";
            mnuConsultaTree.Size = new Size(133, 29);
            mnuConsultaTree.Text = "Consulta Tree";
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(61, 29);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // frmBase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 599);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmBase";
            Text = "frmBase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuAlta;
        private ToolStripMenuItem mnuConsultaList;
        private ToolStripMenuItem mnuConsultaTree;
        private ToolStripMenuItem mnuSalir;
    }
}
