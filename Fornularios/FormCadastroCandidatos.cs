using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeVotos.Fornularios
{
    public partial class FormCadastroCandidatos : Form
    {
        public FormCadastroCandidatos()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtApelido.Clear();
            txtNomeCompleto.Clear();
            txtNumeroCandi.Clear();
            txtPartido.Clear();
            txtNomeCompleto.Select();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
