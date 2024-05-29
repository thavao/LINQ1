using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1B
{
    public class ReadFile
    {
        public static List<PenalidadesAplicadas> GetData(string path)
        {
            StreamReader sr = new(path);
            string jsonString = sr.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<MotoristaHabilitado>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy"});

            if (lst != null) return lst.PenalidadesAplicadas;
            return null;
        }

    }
}
