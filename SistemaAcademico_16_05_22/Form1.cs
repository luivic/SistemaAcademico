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

namespace SistemaAcademico_16_05_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblcad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro cad = new TelaCadastro();
            cad.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicial i = new TelaInicial();
            i.Show();
            this.Hide();
        }
    }
}
