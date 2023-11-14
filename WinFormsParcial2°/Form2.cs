using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFroms.Entidades;

namespace WinFormsParcial2_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Cubo cubo;
        List<Borde> listaBordes = Enum.GetValues(typeof(Borde))
                .Cast<Borde>().ToList();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
            Crearbordes();
        }

        private void Crearbordes()
        {
            //37; 26
            int X = 26;
            int Y = 37;

            bool check = true;
            var listaBorde = Enum.GetValues(typeof(Borde))
            .Cast<Borde>().ToList();
            foreach (var itemborde in listaBorde)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rbt{itemborde.ToString()}",
                    Text = itemborde.ToString(),
                    Location = new Point(X, Y),
                    Checked = check
                };
                groupBox1.Controls.Add(rb);
                Y += 38;
                check = false;
            }
        }

        private void CargarComboColores()
        {
            var listaRelleno = Enum.GetValues(typeof(Relleno))
            .Cast<Relleno>().ToList();
            comboBox1.DataSource = listaRelleno;
            comboBox1.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Cubo GetCubo()
        {
            return cubo;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                cubo = new Cubo();
                cubo.Arista = int.Parse(txtArista.Text);
                cubo.Relleno = (Relleno)comboBox1.SelectedItem;
                cubo.Borde = ObtenerBorde();

                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtArista.Text, out int baseRect))
            {
                valido = false;
                errorProvider1.SetError(txtArista, "Arista del Cubo no numérica!!!");
            }
            else if (baseRect <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtArista, "Arista no válida!!!");
            }
            return valido;
        }

        private Borde ObtenerBorde()
        {
            Borde tipo = 0;
            foreach (var itemBorde in listaBordes)
            {
                var key = $"rbt{itemBorde.ToString()}";
                var rb = (RadioButton)groupBox1.Controls.Find(key, true)[0];
                if (rb.Checked)
                {
                    tipo = itemBorde;
                    break;
                }
            }
            return tipo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
