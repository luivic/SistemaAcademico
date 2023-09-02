using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico_16_05_22.Model;
using SistemaAcademico_16_05_22.DAO;

namespace SistemaAcademico_16_05_22.View
{
    public partial class TelaCoordenadorTurma : Form
    {
        public TelaCoordenadorTurma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtano.Text.Equals("") ||
                txtsemes.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");
            else
            {
                Turma t = new Turma();
                TurmaDAO dao = new TurmaDAO();

                t.Semestre = Convert.ToInt32(txtsemes.Text);
                t.Ano = Convert.ToInt32(txtano.Text);
                MessageBox.Show("Semestre e Ano adicionados a turma !! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criação de Turma finalizada com Sucesso!! ");
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCoordenador c = new TelaCoordenador();
            c.Show();
            this.Hide();
        }
    }
}
