using DataTransmission.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Data
{
    internal class PaymentReportDAO
    {
        public void ReadPaymentReport()
        {
            SqlConnection conn1 = null;
            SqlConnection conn2 = null;
            PaymentReportDTO paymentReport = null;
            List<PaymentReportDTO> list = null;
            Mixin mixin = new Mixin();
            SqlCommand cmd1 = null;
            SqlCommand cmd2 = null;
            try
            {
                conn1 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ProdPassio; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");
                conn2 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ResoSaleReport; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");

                conn1.Open();
                conn2.Open();

                string sql1 = "select [ID],CreateBy,Status,Date,StoreID,CashAmount,MemberCardAmount,BankAmount,VoucherAmount,DebtAmount,OtherAmount,PayDebtAmount,ReceiptAmount,SpendAmount " +
                    "from PaymentReport";
                string sql2 = "insert into PaymentReport(ID,CreateBy,Status,Date,StoreID,CashAmount,MemberCardAmount,BankAmount,VoucherAmount,DebtAmount,OtherAmount,PayDebtAmount,ReceiptAmount,SpendAmount) " +
                    "values(@ID, @CreateBy, @Status, @Date, @StoreID, @CashAmount, @MemberCardAmount, @BankAmount, @VoucherAmount, @DebtAmount, @OtherAmount, @PayDebtAmount, @ReceiptAmount, @SpendAmount)";

                cmd1 = new SqlCommand(sql1, conn1);
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    paymentReport = new PaymentReportDTO();

                    paymentReport.ID = mixin.Check(0, paymentReport.ID, reader);
                    paymentReport.CreateBy = mixin.Check(1, paymentReport.CreateBy, reader);
                    paymentReport.Status = mixin.Check(2, paymentReport.Status, reader);
                    paymentReport.Date = mixin.Check(3, paymentReport.Date, reader);
                    paymentReport.StoreID = mixin.Check(4, paymentReport.StoreID, reader);
                    paymentReport.CashAmount = (float)mixin.Check(5, paymentReport.CashAmount, reader);
                    paymentReport.MemberCardAmount = (float)mixin.Check(6, paymentReport.MemberCardAmount, reader);
                    paymentReport.BankAmount = (float)mixin.Check(7, paymentReport.BankAmount, reader);
                    paymentReport.VoucherAmount = (float)mixin.Check(8, paymentReport.VoucherAmount, reader);
                    paymentReport.DebtAmount = (float)mixin.Check(9, paymentReport.DebtAmount, reader);
                    paymentReport.OtherAmount = (float)mixin.Check(10, paymentReport.OtherAmount, reader);
                    paymentReport.PayDebtAmount = (float)mixin.Check(11, paymentReport.PayDebtAmount, reader);
                    paymentReport.ReceiptAmount = (float)mixin.Check(12, paymentReport.ReceiptAmount, reader);
                    paymentReport.SpendAmount = (float)mixin.Check(13, paymentReport.SpendAmount, reader);
                
                    if(list == null)
                    {
                        list = new List<PaymentReportDTO>();
                    }
                    list.Add(paymentReport);
                }
                foreach(var dto in list)
                {
                    cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.Parameters.AddWithValue("@ID", dto.ID);
                    SqlParameter p0 = cmd2.Parameters.AddWithValue("@CreateBy", dto.CreateBy);
                    if (dto.CreateBy == null)
                    {
                        p0.Value = DBNull.Value;
                    }
                    SqlParameter p1 = cmd2.Parameters.AddWithValue("@Status", dto.Status);
                    if (dto.Status == null)
                    {
                        p1.Value = DBNull.Value;
                    }
                    SqlParameter p2 = cmd2.Parameters.AddWithValue("@Date", dto.Date);
                    if (dto.Date == null)
                    {
                        p2.Value = DBNull.Value;
                    }
                    SqlParameter p3 = cmd2.Parameters.AddWithValue("@StoreID", dto.StoreID);
                    if (dto.StoreID == null)
                    {
                        p3.Value = DBNull.Value;
                    }
                    SqlParameter p4 = cmd2.Parameters.AddWithValue("@CashAmount", dto.CashAmount);
                    if (dto.CashAmount == null)
                    {
                        p4.Value = DBNull.Value;
                    }
                    SqlParameter p5 = cmd2.Parameters.AddWithValue("@MemberCardAmount", dto.MemberCardAmount);
                    if (dto.MemberCardAmount == null)
                    {
                        p5.Value = DBNull.Value;
                    }
                    SqlParameter p6 = cmd2.Parameters.AddWithValue("@BankAmount", dto.BankAmount);
                    if (dto.BankAmount == null)
                    {
                        p6.Value = DBNull.Value;
                    }
                    SqlParameter p7 = cmd2.Parameters.AddWithValue("@VoucherAmount", dto.VoucherAmount);
                    if (dto.VoucherAmount == null)
                    {
                        p7.Value = DBNull.Value;
                    }
                    SqlParameter p8 = cmd2.Parameters.AddWithValue("@DebtAmount", dto.DebtAmount);
                    if (dto.DebtAmount == null)
                    {
                        p8.Value = DBNull.Value;
                    }
                    SqlParameter p9 = cmd2.Parameters.AddWithValue("@OtherAmount", dto.OtherAmount);
                    if (dto.OtherAmount == null)
                    {
                        p9.Value = DBNull.Value;
                    }
                    SqlParameter p10 = cmd2.Parameters.AddWithValue("@PayDebtAmount", dto.PayDebtAmount);
                    if (dto.PayDebtAmount == null)
                    {
                        p10.Value = DBNull.Value;
                    }
                    SqlParameter p11 = cmd2.Parameters.AddWithValue("@ReceiptAmount", dto.ReceiptAmount);
                    if (dto.ReceiptAmount == null)
                    {
                        p11.Value = DBNull.Value;
                    }
                    SqlParameter p12 = cmd2.Parameters.AddWithValue("@SpendAmount", dto.SpendAmount);
                    if (dto.SpendAmount == null)
                    {
                        p12.Value = DBNull.Value;
                    }
                    cmd2.ExecuteNonQuery();
                    
                }
                Console.WriteLine("PaymentReport table created successfully !!");

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
