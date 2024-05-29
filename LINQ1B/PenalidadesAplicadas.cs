using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LINQ1B
{
    public class PenalidadesAplicadas
    {
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }
        
        [JsonProperty("nome_motorista")]
        public string NomeMotorista { get; set; }
        
        [JsonProperty("cpf")]
        public string CPF { get; set; }
        
        [JsonProperty("vigencia_do_cadastro")]
        public DateTime VigenciaCadastro { get; set; }

        public override string? ToString() => $"Razao social: {RazaoSocial}\nNome Motorista: {NomeMotorista}\nCPF: {CPF}\nAno de vigência: {VigenciaCadastro.ToString("dd/MM/yyyy")}";
    }
}
