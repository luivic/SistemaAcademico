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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.Equals("") ||
                txtnumero.Text.Equals("") ||
                txtlogin.Text.Equals("") ||
                txtsenha.Text.Equals("")||
                txtperfil.Text.Equals("")) 
            {
                MessageBox.Show("Por favor preencha todos os campos!! ");
            }
            else
            {
                UsuarioDAO dao = new UsuarioDAO();
                Usuario usuario = new Usuario();

                usuario.Numero = Convert.ToInt32(txtnumero.Text);
                usuario.Nome = txtnome.Text;
                usuario.Login = txtlogin.Text;
                usuario.Senha = txtsenha.Text;
                usuario.Perfil = txtperfil.Text;
                dao.cadastrarUsuario(usuario);
                MessageBox.Show("Usuário Cadastrado com sucesso ");

                
            }
        }
    }
}
