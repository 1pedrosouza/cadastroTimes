using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time.Model
{
    class ConexaoBD
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pedro.hsalves2\source\repos\time\time\BDTimeCS.mdf;Integrated Security=True";
        }
    }
}
