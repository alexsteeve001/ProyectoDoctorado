using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAval
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);

            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void aVALARPRESENTACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvalPresentacion presentacion = new AvalPresentacion();
            AbrirFormInPanel(presentacion);
        }

        private void aVALARMATRICULAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvalMatricula matricula = new AvalMatricula();
            AbrirFormInPanel(matricula);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
