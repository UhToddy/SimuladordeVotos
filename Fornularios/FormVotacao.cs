using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimuladorDeVotos.Program;

namespace SimuladorDeVotos.Fornularios
{
    public partial class FormVotacao : Form
    {
        public FormVotacao()
        {
            
            InitializeComponent();
            dtgCandidatos.DataSource = Candidatos;
            lbSucesso.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
