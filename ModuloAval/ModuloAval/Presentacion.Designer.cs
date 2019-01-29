namespace ModuloAval
{
    partial class Presentacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aVALARMATRICULAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVALARPRESENTACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVALARMATRICULAToolStripMenuItem,
            this.aVALARPRESENTACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aVALARMATRICULAToolStripMenuItem
            // 
            this.aVALARMATRICULAToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aVALARMATRICULAToolStripMenuItem.Name = "aVALARMATRICULAToolStripMenuItem";
            this.aVALARMATRICULAToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.aVALARMATRICULAToolStripMenuItem.Text = "AVALAR MATRICULA";
            this.aVALARMATRICULAToolStripMenuItem.Click += new System.EventHandler(this.aVALARMATRICULAToolStripMenuItem_Click);
            // 
            // aVALARPRESENTACIONToolStripMenuItem
            // 
            this.aVALARPRESENTACIONToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aVALARPRESENTACIONToolStripMenuItem.Name = "aVALARPRESENTACIONToolStripMenuItem";
            this.aVALARPRESENTACIONToolStripMenuItem.Size = new System.Drawing.Size(172, 20);
            this.aVALARPRESENTACIONToolStripMenuItem.Text = "AVALAR PRESENTACION";
            this.aVALARPRESENTACIONToolStripMenuItem.Click += new System.EventHandler(this.aVALARPRESENTACIONToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 510);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aVALARPRESENTACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVALARMATRICULAToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}