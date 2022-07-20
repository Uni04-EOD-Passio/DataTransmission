using DataTransmission.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Data
{
    internal class DateReportDAO
    {
        public void ReadDateReport()
        {
            SqlConnection conn1 = null;
            SqlConnection conn2 = null;
            BrandDTO brandDTO = null;
            List<BrandDTO> brandList = null;
            try
            {
                conn1 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ProdPassio; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");
                conn2 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ResoSaleReport; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");

                conn1.Open();
                conn2.Open();

                string sql1 = "";
                string sql2 = "";



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn1.Close();
                conn2.Close();
            }
        }
    }
}
