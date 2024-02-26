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

            if (radioButton1.Checked)
            {
                a.RegimeTributario = "Simples";
            }
            else if (radioButton2.Checked)
            {
                a.RegimeTributario = "Lucro Presumido";
            }
            else
            {
                a.RegimeTributario = "Real";
            }


            a.DataInicio = dateTimePicker1.Value.Date;
            a.Telefone = maskedTextBox1.Text;
            a.CapitalSocial = tb_CapitalSocial.Text;
            a.Endereco = cb_Endereco.Text;

            if (radioButton4.Checked)
            {
                a.Tipo = "Matriz";
            }
            else if (radioButton5.Checked)
            {
                a.Tipo = "Filial";
            }

            if (radioButton6.Checked)
            {
                a.PorteEmpresa = "Pequeno";
            }
            else if (radioButton7.Checked)
            {
                a.PorteEmpresa = "Médio";
            }
            else
            {
                a.PorteEmpresa = "Grande";
            }

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_Cnpj.Clear();
            tb_RazaoSocial.Clear();
            tb_NomeFantasia.Clear();
            cb_SituacaoCadastral.SelectedItem = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
            tb_CapitalSocial.Clear();
            cb_Endereco.SelectedItem = null;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            cb_NaturezaJuridica.SelectedItem = null;
            tb_NomeProprietario.Clear();
            tb_CpfProprietario.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_CpfProprietario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
