using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ1B
{
    public class TestFilters
    {
        public static List<PenalidadesAplicadas> FilterByCPFStart(List<PenalidadesAplicadas> penalidades, string start = "237") =>
            penalidades.Where(p => p.CPF.StartsWith(start)).ToList();

        public static List<PenalidadesAplicadas> FilterByYear(List<PenalidadesAplicadas> penalidades, int y) =>
            penalidades.Where(p => p.VigenciaCadastro.Year == y).ToList();

        public static int CountByContainInRazao(List<PenalidadesAplicadas> penalidades, string str) =>
            penalidades.Where(p => p.RazaoSocial.Contains(str)).ToList().Count();

        public static List<PenalidadesAplicadas> OrderByRazaoSocial(List<PenalidadesAplicadas> penalidades) =>
            penalidades.OrderBy(p => p.RazaoSocial).ToList();

        public static string GenerateXML(List<PenalidadesAplicadas> lista)
        {
            if (lista.Count > 0)
            {
                var penalidadeAplicada = new XElement("Root", from data in lista
                                                              select new XElement("motorista",
                                                              new XElement("razao_social", data.RazaoSocial),
                                                              new XElement("cnoj", data.CNPJ),
                                                              new XElement("nome_motorista", data.NomeMotorista),
                                                              new XElement("cpf", data.CPF),
                                                              new XElement("vigencia_de_cadastro", data.VigenciaCadastro)
                                                              )
                                                              );
                return penalidadeAplicada.ToString();
            }
            else
                return "Sem registros";
        }
    }
}

