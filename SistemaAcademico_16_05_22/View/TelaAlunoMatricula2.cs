using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico_16_05_22.DAO;
using SistemaAcademico_16_05_22.View;
using SistemaAcademico_16_05_22.Model;

namespace SistemaAcademico_16_05_22.View
{
    public partial class TelaAlunoMatricula2 : Form
    {
        public TelaAlunoMatricula2()
        {
            InitializeComponent();
        }

        private void TelaAlunoMatricula2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnuma.Text.Equals("") ||
                txtnota1.Text.Equals("") ||
                txtnota2.Text.Equals("") ||
                txtexame.Text.Equals("") ||
                txtfaltas.Text.Equals("") ||
                cmbsituacao.SelectedItem.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");
            else if (cmbsituacao.SelectedItem.Equals("Aprovado"))
            {
                Matricula ma = new Matricula();
                MatriculaDAO dao = new MatriculaDAO();

                ma.Aprovado = Convert.ToBoolean(cmbsituacao.SelectedItem);
                dao.realizarMatricula(ma);
            }
            else if (txtexame.Text.Length > 10 || txtnota1.Text.Length > 10|| txtnota2.Text.Length > 10)
                MessageBox.Show("As notas não podem ser maiores que 10");

            else
            {
                Matricula ma = new Matricula();
                MatriculaDAO dao = new MatriculaDAO();

                ma.Aluno.NumeroA = Convert.ToInt32(txtnuma.Text);
                ma.Nota1 = Convert.ToInt32(txtnota1.Text);
                ma.Noat2 = Convert.ToInt32(txtnota2.Text);
                ma.Exame = Convert.ToInt32(txtexame.Text);
                ma.Faltas = Convert.ToInt32(txtfaltas.Text);
                dao.realizarMatricula(ma);
                MessageBox.Show("MaTricula realizada com Sucessoo!! ");
            }
        }

        private void cmbsituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaAluno a = new TelaAluno();
            a.Show();
            this.Hide();
        }
    }
}
