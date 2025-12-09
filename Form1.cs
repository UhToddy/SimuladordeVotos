using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorDeVotos;
using SimuladorDeVotos.Fornularios;

namespace SimuladorDeVotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadrasto_Click(object sender, EventArgs e)
        {
            FormCadastroCandidatos form = new FormCadastroCandidatos();
            form.ShowDialog();

        }

        private void btVotacaoIntera_Click(object sender, EventArgs e)
        {
            FormVotacao form = new FormVotacao();
            form.ShowDialog();

        }
    }
}
