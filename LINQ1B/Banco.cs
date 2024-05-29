using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1B
{
    internal class Banco
    {
        string strConnection = "Data Source=127.0.0.1; Initial Catalog=Detran; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes";

        public string getStrConnection() => strConnection;
    }
}
