using DataTransmission.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Data
{
    internal class ReportTrackingDAO
    {
        SqlConnection conn1 = null;
        SqlConnection conn2 = null;
        ReportTrackingDAO reportTrackingDAO = null;
        List<ReportTrackingDAO> list = null;

        public void ReadReportTracking()
        {
            
            try
            {
                conn1 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ProdPassio; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");
                conn2 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ResoSaleReport; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");

                conn1.Open();
                conn2.Open();

                string sql1 = "";
                string sql2 = "";

                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                SqlDataReader reader1 = null;
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    reportTrackingDAO = new ReportTrackingDAO();
                }


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
