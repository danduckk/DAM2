namespace BibliotecaMDI
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
            pcbPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbPortada).BeginInit();
            SuspendLayout();
            // 
            // pcbPortada
            // 
            pcbPortada.Location = new Point(655, 62);
            pcbPortada.Name = "pcbPortada";
            pcbPortada.Size = new Size(225, 324);
            pcbPortada.TabIndex = 0;
            pcbPortada.TabStop = false;
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 754);
            Controls.Add(pcbPortada);
            Name = "FrmAlta";
            Text = "FrmAlta";
            ((System.ComponentModel.ISupportInitialize)pcbPortada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbPortada;
    }
}