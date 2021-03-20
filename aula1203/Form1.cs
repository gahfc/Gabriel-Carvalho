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
    public partial class Form1 : Form
    {
        FormCadastroPessoal form = new FormCadastroPessoal();
        FormLogin FormLogin = new FormLogin();
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

            {

                e.Cancel = true;

            }
        }

        private void dadastropessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if(form.IsDisposed) form = new FormCadastroPessoal();

            form.MdiParent = this;

            form.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
