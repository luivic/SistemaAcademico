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
    public partial class ProfessorNota2 : Form
    {
        public ProfessorNota2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatriculaDAO dao = new MatriculaDAO();
            List<Matricula> matriculas;

            matriculas = dao.ConsultarMatricula();
            foreach (Matricula matricula in matriculas)
            {
                tblaluno.Rows.Add(matricula.Aluno, matricula.Turma, matricula.Nota1, matricula.Exame,matricula.Aprovado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!!");
            else if (txtvalor.Text.Length > 10)
                MessageBox.Show("O número deve ser m enor que 10 ");
            else
            {
                Matricula m = new Matricula();
                MatriculaDAO dao = new MatriculaDAO();

                m.Noat2 = Convert.ToInt32(txtvalor.Text);
                MessageBox.Show("Nota2 adicionada com sucesso!!");
            }
        }
    }
}
