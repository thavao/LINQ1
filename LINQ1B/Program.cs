using LINQ1B;
using Microsoft.Data.SqlClient;
using System.Data;

void PrintData(List<PenalidadesAplicadas> pe)
{
    foreach (var item in pe)
    {
        Console.WriteLine(item + "\n");
    }
}

void SaveBD(List<PenalidadesAplicadas> pa)
{
    Banco bd = new Banco();
    SqlConnection conn = new(bd.getStrConnection());
    

    conn.Open();
    foreach (var item in pa)
    {
        SqlCommand cmd = new("[dbo].[InserirPenalidade]", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter razao = new("@RazaoSocial", SqlDbType.VarChar, 40);
        SqlParameter cnpj = new("@CNPJ", SqlDbType.VarChar, 17);
        SqlParameter nm = new("@NomeMotorista", SqlDbType.VarChar, 40);
        SqlParameter cpf = new("@CPF", SqlDbType.Char, 14);
        SqlParameter dtVigencia = new("@VigenciaDoCadastro", SqlDbType.Date);

        razao.Value = item.RazaoSocial;
        cnpj.Value = item.CNPJ;
        nm.Value = item.NomeMotorista;
        cpf.Value = item.CPF;
        dtVigencia.Value = item.VigenciaCadastro;

        cmd.Parameters.Add(razao);
        cmd.Parameters.Add(cnpj);
        cmd.Parameters.Add(nm);
        cmd.Parameters.Add(cpf);
        cmd.Parameters.Add(dtVigencia);


        cmd.ExecuteNonQuery();
    }
    conn.Close();

    Console.WriteLine("Ufa, acabou...");
}


var ls = ReadFile.GetData(@"C:\ArquivosProg\motoristas_habilitados.json");


/*Console.WriteLine("Listar Registros que tenham o número do documento (cpf) iniciando com 237");
PrintData(TestFilters.FilterByCPFStart(ls));

Console.WriteLine("Listar Registros que tenham o ano de vigencia em 2021");
PrintData(TestFilters.FilterByYear(ls, 2021));

Console.WriteLine("Quantas empresas tem a descrição LTDA no nome");
Console.WriteLine((TestFilters.CountByContainInRazao(ls, "LTDA")));

Console.WriteLine("Ordenar a lista de registro pela razao social");
PrintData(TestFilters.OrderByRazaoSocial(ls));
*/
Console.WriteLine("Inserir todos os registros no SQLServer");
//SaveBD(ls);