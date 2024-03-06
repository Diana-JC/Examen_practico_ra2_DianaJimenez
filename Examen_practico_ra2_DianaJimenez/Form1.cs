using System.Windows.Forms;
using static examen_practico_ra2_DianaJimenez.Form1;

namespace examen_practico_ra2_DianaJimenez
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();


        }


        private void InitializeComboBoxes()
        {
            // Inicializar ComboBox para género
            cb_genero.Items.Add("Masculino");
            cb_genero.Items.Add("Femenino");

            // Inicializar ComboBox para área técnica
            cb_area_tecnica.Items.Add("Informática");
            cb_area_tecnica.Items.Add("Gastronomia");
            cb_area_tecnica.Items.Add("Enfermeria");
            cb_area_tecnica.Items.Add("Contabilidad");

            // Inicializar ComboBox para curso y sección
            cb_curso.Items.Add("4to");
            cb_curso.Items.Add("5to");
            cb_curso.Items.Add("6to");


            cb_seccion.Items.Add("A1");
            cb_seccion.Items.Add("A2");
            cb_seccion.Items.Add("A3");
            cb_seccion.Items.Add("B");
            cb_seccion.Items.Add("C");
            cb_seccion.Items.Add("D1");
            cb_seccion.Items.Add("D2");
            cb_seccion.Items.Add("E");
        }

        private void HabilitarCampos()
        {
            txt_matricula.Enabled = true;
            txt_nombre.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
            txt_email.Enabled = true;
            txt_maestro.Enabled = true;
            cb_seccion.Enabled = true;
            cb_area_tecnica.Enabled = true;
            cb_curso.Enabled = true;
            cb_genero.Enabled = true;

        }

        private void DeshabilitarCampos()
        {
            txt_matricula.Enabled = false;
            txt_nombre.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
            txt_email.Enabled = false;
            txt_maestro.Enabled = false;
            cb_seccion.Enabled = false;
            cb_area_tecnica.Enabled = false;
            cb_curso.Enabled = false;
            cb_genero.Enabled = false;
        }


        private void HabilitarControles(bool estado)
        {
            txt_matricula.Enabled = estado;
            txt_nombre.Enabled = estado;
            txt_direccion.Enabled = estado;
            txt_telefono.Enabled = estado;
            cb_genero.Enabled = estado;
            txt_email.Enabled = estado;
            cb_curso.Enabled = estado;
            cb_seccion.Enabled = estado;
            cb_area_tecnica.Enabled = estado;
            txt_maestro.Enabled = estado;
            btn_guardar.Enabled = estado;
        }

        private void LimpiarCampos()
        {
            txt_matricula.Text = "";
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            cb_genero.SelectedIndex = -1;
            txt_email.Text = "";
            cb_curso.SelectedIndex = -1;
            cb_seccion.SelectedIndex = -1;
            cb_area_tecnica.SelectedIndex = -1;
            txt_maestro.Text = "";
        }

        private void GuardarRegistro()
        {
            string registro = $"{txt_matricula.Text},{txt_nombre.Text},{cb_curso.SelectedItem},{cb_seccion.SelectedItem},{cb_area_tecnica.SelectedItem}";
            dgv_Estudiante.Rows.Add(registro.Split(','));
            GuardarArchivo(registro);
        }

        private void GuardarArchivo(string registro)
        {
            string filePath = "registros.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(registro);
            }
        }






        private void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
            LimpiarCampos();
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_agregar.Enabled = true;

        }



        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarControles(true);
            btn_eliminar.Enabled = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Eliminar registro seleccionado del DataGridView
                    if (dgv_Estudiante.SelectedRows.Count > 0)
                    {
                        dgv_Estudiante.Rows.RemoveAt(dgv_Estudiante.SelectedRows[0].Index);
                    }

                }

            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_Estudiante.Rows.Add(txt_nombre.Text, cb_curso.Text, cb_seccion.Text, txt_matricula.Text, txt_telefono.Text, cb_area_tecnica.Text, txt_direccion.Text, cb_genero.Text, txt_email.Text, txt_maestro.Text);
            LimpiarCampos();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;

            Resultado = MessageBox.Show("Desea salir de la aplicacion ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            { Close(); }
        }


        public class Estudiante
        {
            public string Matricula { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Genero { get; set; }
            public string Email { get; set; }
            public string Curso { get; set; }
            public string Seccion { get; set; }
            public string AreaTecnica { get; set; }
            public string MaestroTitular { get; set; }

            public Estudiante(string matricula, string nombre, string direccion, string telefono, string genero, string email, string curso, string seccion, string areaTecnica, string maestroTitular)
            {
                Matricula = matricula;
                Nombre = nombre;
                Direccion = direccion;
                Telefono = telefono;
                Genero = genero;
                Email = email;
                Curso = curso;
                Seccion = seccion;
                AreaTecnica = areaTecnica;
                MaestroTitular = maestroTitular;
            }


        }

        
    }

}

