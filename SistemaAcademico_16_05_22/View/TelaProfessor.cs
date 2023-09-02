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
    public partial class TelaProfessor : Form
    {
        public TelaProfessor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbprof.SelectedItem.Equals("Notas"))
            {
                TelaProfessorNotas notas = new TelaProfessorNotas();
                notas.Show();
                this.Hide();
            }
            else if (cmbprof.SelectedItem.Equals("Frequência"))
            {
                TelaProfessorFrquencia f = new TelaProfessorFrquencia();
                f.Show();
                this.Hide();
            }
        }
    }
}
