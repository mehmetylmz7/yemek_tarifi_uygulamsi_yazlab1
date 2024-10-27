using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazlabProje1
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DIDIM\\SQLEXPRESS;Initial Catalog=yazlab1_tarif;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }


    }
}
