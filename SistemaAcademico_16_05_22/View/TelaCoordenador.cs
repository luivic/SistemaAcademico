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
    public partial class TelaCoordenador : Form
    {
        public TelaCoordenador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCoordenadorDisciplina dis = new TelaCoordenadorDisciplina();
            dis.Show();
            this.Hide();

        }
    }
}
