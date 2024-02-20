using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Empresa.Classes
{
    internal class Empresa
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public string RegimeTributario { get; set; }
        public DateTime DataInicio { get; set; }
        public string Telefone { get; set; }

        public string CapitalSocial { get; set; }
        public string Endereco { get ; set; }
        public string Tipo { get ; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJuridica { get; set; }
        public string NomeProprietario { get; set; }
        public string CpfProprietario { get; set; }

        public Empresa(string Cnpj, string RazaoSocial, string NomeFantasia, string SituacaoCadastral, string RegimeTributario, DateTime DataInicio, string Telefone, string CapitalSocial,
         string Endereco, string Tipo, string PorteEmpresa, string NaturezaJuridica, string NomeProprietario, string CpfProprietario)
        {
          this.Cnpj = Cnpj;
        this.RazaoSocial = RazaoSocial;
            this.NomeFantasia = NomeFantasia;
            this.SituacaoCadastral = SituacaoCadastral;
            this.RegimeTributario = RegimeTributario;
            this.DataInicio = DataInicio;
            this.Telefone = Telefone;   
            this.CapitalSocial = CapitalSocial; 
            this.Endereco = Endereco;   
            this.Tipo = Tipo;
            this.PorteEmpresa = PorteEmpresa;   
            this.NaturezaJuridica = NaturezaJuridica;
            this.NomeProprietario = NomeProprietario;
            this.CpfProprietario = CpfProprietario;
        }

    }
}
