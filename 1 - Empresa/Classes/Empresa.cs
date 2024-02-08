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
        public string NomeProprietário { get; set; }
        public string CpfProprietario { get; set; }
    }
}
