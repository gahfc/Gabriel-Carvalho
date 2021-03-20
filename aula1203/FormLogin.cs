using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1203
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();

            if (tbUsuario.Text == "" || tbSenha.Text == "")

            {

                if (tbUsuario.Text == "" && tbSenha.Text == "")

                {

                    MessageBox.Show("Preencha os campos do usuário e senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else if (tbUsuario.Text == "")

                {

                    MessageBox.Show("Preencha o campo do usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else

                {

                    MessageBox.Show("Preencha o campo da senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

            else

            {

                if (tbUsuario.Text == "admin" && tbSenha.Text == "1234")

                {

                    this.Hide();

                    form1.Show();

                }

                else

                {

                    MessageBox.Show("Usuário ou senha incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
    }
}
