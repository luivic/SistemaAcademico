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
    public partial class TelaAluno : Form
    {
        public TelaAluno()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbaluno.SelectedItem.Equals("Matrícula"))
            {
                TelaAlunoMatricula ma = new TelaAlunoMatricula();
                ma.Show();
                this.Hide();
            }
        }
    }
}
