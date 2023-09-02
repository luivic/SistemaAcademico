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
using SistemaAcademico_16_05_22.Model;
using SistemaAcademico_16_05_22.View;

namespace SistemaAcademico_16_05_22.View
{
    public partial class TelaProfessorNotas3 : Form
    {
        public TelaProfessorNotas3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbexame.Equals("Exame"))
            {
                ProfessorNotaExame exame = new ProfessorNotaExame();
                exame.Show();
                this.Hide();
            }
            else if (rdbexame.Equals("Nota1"))
            {
                ProfessorNota1 n = new ProfessorNota1();
                n.Show();
                this.Hide();

            }
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void rdbexame_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbnota2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbnota1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
