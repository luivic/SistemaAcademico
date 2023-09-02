using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico_16_05_22.View;

namespace SistemaAcademico_16_05_22.View
{
    public partial class TelaSecretaria : Form
    {
        public TelaSecretaria()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbselecionar.SelectedItem.Equals("Professor"))
            {
                TelaSecreProfessor prof = new TelaSecreProfessor();
                prof.Show();
                this.Hide();

            }
            else if (cmbselecionar.SelectedItem.Equals("Disciplina"))
            {
                TelaSecreDisciplina dis = new TelaSecreDisciplina();
                dis.Show();
                this.Hide();
            }
            else if (cmbselecionar.SelectedItem.Equals("Aluno"))
            {
                TelaSecreAluno a = new TelaSecreAluno();
                a.Show();
                this.Hide();
            }
           
        }
    }
}
