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
            DateReportDTO dateReportDTO = null;
            List<DateReportDTO> list = null;
            Mixin mixin = new Mixin();
            SqlCommand cmd1 = null;
            SqlCommand cmd2 = null;
            try
            {
                conn1 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ProdPassio; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");
                conn2 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ResoSaleReport; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");

                conn1.Open();
                conn2.Open();

                string sql1 = "SELECT Date,CreateBy,Status,StoreID,TotalAmount,FinalAmount,Discount,DiscountOrderDetail,TotalCash,TotalOrder,TotalOrderAtStore," +
                    "TotalOrderTakeAway,TotalOrderDelivery,TotalOrderDetail,TotalOrderFeeItem,TotalOrderCard,TotalOrderCanceled,TotalOrderPreCanceled," +
                    "FinalAmountAtStore,FinalAmountTakeAway,FinalAmountDelivery,FinalAmountCard,FinalAmountCanceled,FinalAmountPreCanceled, ID " +
                    "FROM DateReport";
                string sql2 = "INSERT INTO DateReport(ID,Date,CreateBy,Status,StoreID,TotalAmount,FinalAmount,Discount,DiscountOrderDetail,TotalCash,TotalOrder,TotalOrderAtStore," +
                    "TotalOrderTakeAway,TotalOrderDelivery,TotalOrderDetail,TotalOrderFeeItem,TotalOrderCard,TotalOrderCanceled,TotalOrderPreCanceled," +
                    "FinalAmountAtStore,FinalAmountTakeAway,FinalAmountDelivery,FinalAmountCard,FinalAmountCanceled,FinalAmountPreCanceled) " +
                    "VALUES(@ID, @Date, @CreateBy, @Status, @StoreID, @TotalAmount, @FinalAmount, @Discount, @DiscountOrderDetail, @TotalCash, @TotalOrder, " +
                    "@TotalOrderAtStore, @TotalOrderTakeAway, @TotalOrderDelivery, @TotalOrderDetail, @TotalOrderFeeItem, @TotalOrderCard, @TotalOrderCanceled, " +
                    "@TotalOrderPreCanceled, @FinalAmountAtStore, @FinalAmountTakeAway, @FinalAmountDelivery, @FinalAmountCard, @FinalAmountCanceled, @FinalAmountPreCanceled)";

                cmd1 = new SqlCommand(sql1, conn1);
                SqlDataReader reader = cmd1.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    dateReportDTO = new DateReportDTO();

                    dateReportDTO.Date = mixin.Check(0, dateReportDTO.Date, reader);
                    dateReportDTO.CreateBy = mixin.Check(1, dateReportDTO.CreateBy, reader);
                    dateReportDTO.Status = mixin.Check(2, dateReportDTO.Status, reader);
                    dateReportDTO.StoreID = mixin.Check(3, dateReportDTO.StoreID, reader);
                    dateReportDTO.TotalAmount = (float)mixin.Check(4, dateReportDTO.TotalAmount, reader);
                    dateReportDTO.FinalAmount = (float)mixin.Check(5, dateReportDTO.FinalAmount, reader);
                    dateReportDTO.Discount = (float)mixin.Check(6, dateReportDTO.Discount, reader);
                    dateReportDTO.DiscountOrderDetail = (float)mixin.Check(7, dateReportDTO.DiscountOrderDetail, reader);
                    dateReportDTO.TotalCash = (float)mixin.Check(8, dateReportDTO.TotalCash, reader);
                    dateReportDTO.TotalOrder = mixin.Check(9, dateReportDTO.TotalOrder, reader);
                    dateReportDTO.TotalOrderAtStore = mixin.Check(10, dateReportDTO.TotalOrderAtStore, reader);
                    dateReportDTO.TotalOrderTakeAway = mixin.Check(11, dateReportDTO.TotalOrderTakeAway, reader);
                    dateReportDTO.TotalOrderDelivery = mixin.Check(12, dateReportDTO.TotalOrderDelivery, reader);
                    dateReportDTO.TotalOrderDetail = (float)mixin.Check(13, dateReportDTO.TotalOrderDetail, reader);
                    dateReportDTO.TotalOrderFeeItem = (float)mixin.Check(14, dateReportDTO.TotalOrderFeeItem, reader);
                    dateReportDTO.TotalOrderCard = mixin.Check(15, dateReportDTO.TotalOrderCard, reader);
                    dateReportDTO.TotalOrderCanceled = mixin.Check(16, dateReportDTO.TotalOrderCanceled, reader);
                    dateReportDTO.TotalOrderPreCanceled = mixin.Check(17, dateReportDTO.TotalOrderPreCanceled, reader);
                    dateReportDTO.FinalAmountAtStore = (float)mixin.Check(18, dateReportDTO.FinalAmountAtStore, reader);
                    dateReportDTO.FinalAmountTakeAway = (float)mixin.Check(19, dateReportDTO.FinalAmountTakeAway, reader);
                    dateReportDTO.FinalAmountDelivery = (float)mixin.Check(20, dateReportDTO.FinalAmountDelivery, reader);
                    dateReportDTO.FinalAmountCard = (float)mixin.Check(21, dateReportDTO.FinalAmountCard, reader);
                    dateReportDTO.FinalAmountCanceled = (float)mixin.Check(22, dateReportDTO.FinalAmountCanceled, reader);
                    dateReportDTO.FinalAmountPreCanceled = (float)mixin.Check(23, dateReportDTO.FinalAmountPreCanceled, reader);
                    dateReportDTO.ID = mixin.Check(24, dateReportDTO.ID, reader);
                    if (list == null)
                    {
                        list = new List<DateReportDTO>();
                    }
                    list.Add(dateReportDTO);
                }
                


                foreach (var dto in list)
                {
                    cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.Parameters.AddWithValue("@ID", dto.ID);
                    SqlParameter p0 = cmd2.Parameters.AddWithValue("@Date", dto.Date);
                    if (dto.Date == null)
                    {
                        p0.Value = DBNull.Value;
                    }
                    SqlParameter p1 = cmd2.Parameters.AddWithValue("@CreateBy", dto.CreateBy);
                    if (dto.CreateBy == null)
                    {
                        p1.Value = DBNull.Value;
                    }
                    SqlParameter p2 = cmd2.Parameters.AddWithValue("@Status", dto.Status);
                    if (dto.Status == null)
                    {
                        p2.Value = DBNull.Value;
                    }
                    SqlParameter p3 = cmd2.Parameters.AddWithValue("@StoreID", dto.StoreID);
                    if (dto.StoreID == null)
                    {
                        p3.Value = DBNull.Value;
                    }
                    SqlParameter p4 = cmd2.Parameters.AddWithValue("@TotalAmount", dto.TotalAmount);
                    if (dto.TotalAmount == null)
                    {
                        p4.Value = DBNull.Value;
                    }
                    SqlParameter p5 = cmd2.Parameters.AddWithValue("@FinalAmount", dto.FinalAmount);
                    if (dto.FinalAmount == null)
                    {
                        p5.Value = DBNull.Value;
                    }
                    SqlParameter p6 = cmd2.Parameters.AddWithValue("@Discount", dto.Discount);
                    if (dto.Discount == null)
                    {
                        p6.Value = DBNull.Value;
                    }
                    SqlParameter p7 = cmd2.Parameters.AddWithValue("@DiscountOrderDetail", dto.DiscountOrderDetail);
                    if (dto.DiscountOrderDetail == null)
                    {
                        p7.Value = DBNull.Value;
                    }
                    SqlParameter p8 = cmd2.Parameters.AddWithValue("@TotalCash", dto.TotalCash);
                    if (dto.TotalCash == null)
                    {
                        p8.Value = DBNull.Value;
                    }
                    SqlParameter p9 = cmd2.Parameters.AddWithValue("@TotalOrder", dto.TotalOrder);
                    if (dto.TotalOrder == null)
                    {
                        p9.Value = DBNull.Value;
                    }
                    SqlParameter p10 = cmd2.Parameters.AddWithValue("@TotalOrderAtStore", dto.TotalOrderAtStore);
                    if (dto.TotalOrderAtStore == null)
                    {
                        p10.Value = DBNull.Value;
                    }
                    SqlParameter p11 = cmd2.Parameters.AddWithValue("@TotalOrderTakeAway", dto.TotalOrderTakeAway);
                    if (dto.TotalOrderTakeAway == null)
                    {
                        p11.Value = DBNull.Value;
                    }
                    SqlParameter p12 = cmd2.Parameters.AddWithValue("@TotalOrderDelivery", dto.TotalOrderDelivery);
                    if (dto.TotalOrderDelivery == null)
                    {
                        p12.Value = DBNull.Value;
                    }
                    SqlParameter p13 = cmd2.Parameters.AddWithValue("@TotalOrderDetail", dto.TotalOrderDetail);
                    if (dto.TotalOrderDetail == null)
                    {
                        p13.Value = DBNull.Value;
                    }
                    SqlParameter p14 = cmd2.Parameters.AddWithValue("@TotalOrderFeeItem", dto.TotalOrderFeeItem);
                    if (dto.TotalOrderFeeItem == null)
                    {
                        p14.Value = DBNull.Value;
                    }
                    SqlParameter p15 = cmd2.Parameters.AddWithValue("@TotalOrderCard", dto.TotalOrderCard);
                    if (dto.TotalOrderCard == null)
                    {
                        p15.Value = DBNull.Value;
                    }
                    SqlParameter p16 = cmd2.Parameters.AddWithValue("@TotalOrderCanceled", dto.TotalOrderCanceled);
                    if (dto.TotalOrderCanceled == null)
                    {
                        p16.Value = DBNull.Value;
                    }
                    SqlParameter p17 = cmd2.Parameters.AddWithValue("@TotalOrderPreCanceled", dto.TotalOrderPreCanceled);
                    if (dto.TotalOrderPreCanceled == null)
                    {
                        p17.Value = DBNull.Value;
                    }
                    SqlParameter p18 = cmd2.Parameters.AddWithValue("@FinalAmountAtStore", dto.FinalAmountAtStore);
                    if (dto.FinalAmountAtStore == null)
                    {
                        p18.Value = DBNull.Value;
                    }
                    SqlParameter p19 = cmd2.Parameters.AddWithValue("@FinalAmountTakeAway", dto.FinalAmountTakeAway);
                    if (dto.FinalAmountTakeAway == null)
                    {
                        p19.Value = DBNull.Value;
                    }
                    SqlParameter p20 = cmd2.Parameters.AddWithValue("@FinalAmountDelivery", dto.FinalAmountDelivery);
                    if (dto.FinalAmountDelivery == null)
                    {
                        p20.Value = DBNull.Value;
                    }
                    SqlParameter p21 = cmd2.Parameters.AddWithValue("@FinalAmountCard", dto.FinalAmountCard);
                    if (dto.FinalAmountCard == null)
                    {
                        p21.Value = DBNull.Value;
                    }
                    SqlParameter p22 = cmd2.Parameters.AddWithValue("@FinalAmountCanceled", dto.FinalAmountCanceled);
                    if (dto.FinalAmountCanceled == null)
                    {
                        p22.Value = DBNull.Value;
                    }
                    SqlParameter p23 = cmd2.Parameters.AddWithValue("@FinalAmountPreCanceled", dto.FinalAmountPreCanceled);
                    if (dto.FinalAmountPreCanceled == null)
                    {
                        p23.Value = DBNull.Value;
                    }
                    cmd2.ExecuteNonQuery();
                    
                }
                Console.WriteLine("DateReport table created successfully !!");

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
