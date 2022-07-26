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
        ReportTrackingDTO reportTrackingDTO = null;
        List<ReportTrackingDTO> list = null;
        Mixin mixin = new Mixin();
        SqlCommand cmd1 = null;
        SqlCommand cmd2 = null;

        public void ReadReportTracking()
        {
            
            try
            {
                conn1 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ProdPassio; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");
                conn2 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ResoSaleReport; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");

                conn1.Open();
                conn2.Open();

                string sql1 = "select [Id],StoreId,Date,DateUpdate,UpdatePerson,IsUpdate " +
                    "from ReportTracking";
                string sql2 = "";

                cmd1 = new SqlCommand(sql1, conn1);
                SqlDataReader reader = null;
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    reportTrackingDTO = new ReportTrackingDTO();

                    reportTrackingDTO.Id = mixin.Check(0, reportTrackingDTO.Id, reader);
                    reportTrackingDTO.StoreID = mixin.Check(1, reportTrackingDTO.StoreID, reader);
                    reportTrackingDTO.Date = mixin.Check(2, reportTrackingDTO.Date, reader);
                    reportTrackingDTO.DateUpdate = mixin.Check(3, reportTrackingDTO.DateUpdate, reader);
                    reportTrackingDTO.UpdatePerson = mixin.Check(4, reportTrackingDTO.UpdatePerson, reader);
                    reportTrackingDTO.isUpdate = mixin.Check(5, reportTrackingDTO.isUpdate, reader);

                    if (list == null)
                    {
                        list = new List<ReportTrackingDTO>();
                    }
                    list.Add(reportTrackingDTO);

                }
                foreach(var dto in list)
                {
                    Console.WriteLine(dto.Id);
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
