using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ModuloAval
{
    public partial class AvalMatricula : Form
    {
        Conexion con = new Conexion();
        public DataGridViewRow lista;
        string nombre;
        string apellido;
        string cedula;
        string total;

        public AvalMatricula()
        {
            InitializeComponent();
        }

        private void ListaEstudiantesMatricula_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            llenarTabla();
        }

        public void llenarTabla()
        {
            dataGridView1.DataSource = ListaAlumnos();
            dataGridView1.Columns[0].Visible = false;
        }

        public DataTable ListaAlumnos()
        {
            string sql = "select [ID_ESTUDIANTE], [CEDULA],[NOMBRES],[APELLIDOS]  from ESTUDIANTE, AVAL where ESTUDIANTE.ID_DIRECTOR=AVAL.ID_DIRECTOR";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.abrirConexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            nombre = Convert.ToString(fila.Cells["NOMBRES"].Value);
            apellido = Convert.ToString(fila.Cells["APELLIDOS"].Value);
            cedula = Convert.ToString(fila.Cells["CEDULA"].Value);
            total = nombre.Trim() + " " + apellido.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AvalarMatricula(string aval)
        {

            string nivel = "2";
            int director = 1;

            string sql = @"Insert into AVAL (ID_DIRECTOR, NIVEL, AVAL_MATRICULA) 
            values(@ID_DIRECTOR, @NIVEL, @AVAL_MATRICULA)";

            SqlCommand cmd = new SqlCommand(sql, con.abrirConexion());
            cmd.Parameters.AddWithValue("@ID_DIRECTOR", director);
            cmd.Parameters.AddWithValue("@NIVEL", nivel);
            cmd.Parameters.AddWithValue("@AVAL_MATRICULA", aval);
            cmd.ExecuteNonQuery();
            
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (checkFavorable.Checked == true)
            {
                AvalarMatricula("si");
            }
            if (checkDesfavorable.Checked == true)
            {
                AvalarMatricula("no");
            }
            MessageBox.Show("Se ha registrado el Aval Matricula del estudiante " + total,"AVAL MATRICULA");
            this.Close();
        }

        private void checkFavorable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFavorable.Checked == true)
            {
                checkDesfavorable.Checked = false;
            }
        }

        private void checkDesfavorable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDesfavorable.Checked == true)
            {
                checkFavorable.Checked = false;
            }
        }
    }
}
