using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAcademico_16_05_22.ConexaoSQL;
using SistemaAcademico_16_05_22.Model;

namespace SistemaAcademico_16_05_22.DAO
{
    class UsuarioDAO
    {
        public UsuarioDAO()
        {
            bool conexao = Conexao.AbrirConexao();

            if (conexao)
                MessageBox.Show("Conectou");
            else MessageBox.Show("Não conectou");
        }
        public void cadastrarUsuario(Usuario u)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();
            

            string sql = "INSERT INTO Usuario(numero, nome, login, senha, perfil ) " +
                "VALUES" +
                "(" + u.Numero + ", '" + u.Nome + "', '" + u.Login + "', '" + u.Senha + "', '" + u.Perfil + "' )";
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);
        }
    }
    
}
