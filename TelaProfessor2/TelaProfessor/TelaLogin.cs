using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelaLogin
{
    public partial class TelaLogin : Form
    {
        private static object exit;

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conexao = "Data Source=CHARLES_AVELAR;Initial Catalog=Cadastro;Integrated Security=True";
            SqlConnection add = new SqlConnection(conexao);
            SqlCommand comando = new SqlCommand("select count(*)from Usuarios where Usuario = @Usuario and Senha=@Senha", add);
            comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = textBox1.Text;
            comando.Parameters.Add("@Senha", SqlDbType.VarChar).Value = textBox2.Text;
            add.Open();
            int i = (int)comando.ExecuteScalar();
            if (i > 0)
            {
                TelaLogin button1 = new TelaLogin();
                TelaProf.TelaProf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login e Senha não correspondem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
