using _1___Empresa.Classes;
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
    public partial class Cadastro : Form
    {

        List<Empresa> ListaEmpresa = new List<Empresa>();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Empresa a = new Empresa();
            a.Cnpj = tb_Cnpj.Text;
            a.RazaoSocial = tb_RazaoSocial.Text;
            a.NomeFantasia = tb_NomeFantasia.Text;
            a.SituacaoCadastral = cb_SituacaoCadastral.Text;
            a.RegimeTributario = groupBox1.Controls.OfType().SingleOrdefault(RadioButton => RadioButton.Checked).Text;
            a.DataInicio = dateTimePicker1.Value.Date;
            a.Telefone = maskedTextBox1.Text;
            a.CapitalSocial = tb_CapitalSocial.Text;
            a.Endereco = cb_Endereco.Text;
            a.Tipo = groupBox2.Controls.OfType().SingleOrdefault(RadioButton => RadioButton.Checked).Text;
            a.PorteEmpresa = groupBox3.Controls.OfType().SingleOrdefault(RadioButton => RadioButton.Checked).Text;
            a.NaturezaJuridica = cb_NaturezaJuridica.Text;
            a.NomeProprietario = tb_NomeProprietario.Text;
            a.CpfProprietario = tb_CpfProprietario.Text;
            ListaEmpresa.Add(a);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = ListaEmpresa;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
