using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1___Empresa.Telas
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuTransicao.Start();

          Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransicao.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
