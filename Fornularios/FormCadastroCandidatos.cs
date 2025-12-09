using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimuladorDeVotos.RegrasDeNegocio;
using SimuladorDeVotos;
using static SimuladorDeVotos.Program;

namespace SimuladorDeVotos.Fornularios
{
    public partial class FormCadastroCandidatos : Form
    {
        // Lista estática para armazenar candidatos
        

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
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtApelido.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroCandi.Text) ||
                string.IsNullOrWhiteSpace(txtPartido.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtNumeroCandi.Text, out int numeroCandidato))
            {
                MessageBox.Show("Número do candidato inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de duplicidade usando expressão lambda
            if (Candidatos.Any(c => c.NumeroCandidato == numeroCandidato))
            {
                MessageBox.Show("Já existe um candidato com este número!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var candidato = new Candidato
            {
                NomeCompleto = txtNomeCompleto.Text.Trim(),
                Apelido = txtApelido.Text.Trim(),
                NumeroCandidato = numeroCandidato,
                Partido = txtPartido.Text.Trim()
            };
            Candidatos.Add(candidato);

            MessageBox.Show("Candidato cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btCancelar_Click(sender, e);
        }

    }
}
