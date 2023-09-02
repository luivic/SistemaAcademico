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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (rdbsecre.Checked)
            {
                TelaSecretaria secre = new TelaSecretaria();
                secre.Show();
                this.Hide();
            }
            else if (rdbcord.Checked)
            {
                TelaCoordenador c = new TelaCoordenador();
                c.Show();
                this.Hide();
            }
            else if (rdbprof.Checked)
            {
                TelaProfessor prof = new TelaProfessor();
                prof.Show();
                this.Hide();
            }
            else if(rdbaluno.Checked)
            {
                TelaAluno a = new TelaAluno();
                a.Show();
                this.Hide();

            }
            
          
        }

        private void rdbcord_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
