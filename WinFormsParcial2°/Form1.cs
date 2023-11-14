using WinFroms.Entidades;
using RepoWinFroms;
using System.Drawing;

namespace WinFormsParcial2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RepositorioDatos repositorio = new RepositorioDatos();
        List<Cubo> Cubolista;
        private void Form1_Load(object sender, EventArgs e)
        {
            Cubolista = repositorio.GetLista();
            MostrarDatosEnGrilla();

        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var cubo in Cubolista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, cubo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cubo cubo)
        {
            r.Cells[colArista.Index].Value = cubo.Arista;
            r.Cells[colBorde.Index].Value = cubo.Borde;
            r.Cells[colRelleno.Index].Value = cubo.Relleno;
            r.Cells[colArea.Index].Value = cubo.GetArea();
            r.Cells[colVolumen.Index].Value = cubo.GetVolumen();

            r.Tag = cubo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2() { Text = "Nuevo formulario" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Cubo cubo = frm.GetCubo();
            repositorio.Agregar(cubo);
            var r = ConstruirFila();
            SetearFila(r, cubo);
            AgregarFila(r);

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea borrar el Cubo?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Cubo cubo = filaSeleccionada.Tag as Cubo;
            repositorio.Borrar(cubo);

            QuitarFila(filaSeleccionada);
            MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }
    }
}