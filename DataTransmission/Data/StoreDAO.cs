using DataTransmission.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Data
{
    internal class StoreDAO
    {
        public void ReadStore()
        {
            SqlConnection conn1 = null;
            SqlConnection conn2 = null;
            StoreDTO storeDTO = null;
            List<StoreDTO> storeList = null;
            try
            {
                conn1 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ProdPassio; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");
                conn2 = new SqlConnection("Server=DESKTOP-83BQOP4\\RAY; Database=ResoSaleReport; TrustServerCertificate=True; MultipleActiveResultSets=true; User Id=sa;Password=123456;");

                conn1.Open();
                conn2.Open();

                string sql1 = "select Name,ShortName,Address,Lat,Lon,Province,District,Ward,isAvailable,Active,Email,Phone,Fax,CreateDate,Type,RoomRentMode,ReportDate," +
                    "GroupId,OpenTime,CloseTime,DefaultAdminPassword,HasProducts,HasNews,HasImageCollections,HasMultipleLanguage,HasWebPages,HasCustomerFeedbacks," +
                    "BrandId,HasOrder,HasBlogEditCollections,LogoUrl,FbAccessToken,StoreFeatureFilter,RunReport,AttendanceStoreFilter,StoreCode,PosId,StoreConfig," +
                    "DefaultDashBoard,PaymentTypeApply,ModeStore, ID " +
                    "from Store";
                /*string sql2 = "INSERT INTO Store(ID, Name,ShortName,Address,Lat,Lon,Province,District,Ward,isAvailable,Active,Email,Phone,Fax,CreateDate,Type,RoomRentMode,ReportDate," +
                    "GroupId,OpenTime,CloseTime,DefaultAdminPassword,HasProducts,HasNews,HasImageCollections,HasMultipleLanguage,HasWebPages,HasCustomerFeedbacks," +
                    "BrandId,HasOrder,HasBlogEditCollections,LogoUrl,FbAccessToken,StoreFeatureFilter,RunReport,AttendanceStoreFilter,StoreCode,PosId,StoreConfig," +
                    "DefaultDashBoard,PaymentTypeApply,ModeStore) " +
                    "VALUES(@ID, @Name,@ShortName,@Address,@Lat,@Lon,@Province,@District,@Ward,@isAvailable,@Active,@Email,@Phone,@Fax,@CreateDate,@Type,@RoomRentMode," +
                    "@ReportDate,@GroupId,@OpenTime,@CloseTime,@DefaultAdminPassword,@HasProducts,@HasNews,@HasImageCollections,@HasMultipleLanguage,@HasWebPages," +
                    "@HasCustomerFeedbacks,@BrandId,@HasOrder,@HasBlogEditCollections,@LogoUrl,@FbAccessToken,@StoreFeatureFilter,@RunReport,@AttendanceStoreFilter," +
                    "@StoreCode,@PosId,@StoreConfig,@DefaultDashBoard,@PaymentTypeApply,@ModeStore)";*/
                /*string sql2 = "insert into Store(ID,Name,ShortName,Address,Lat,Lon,Province,District,Ward,isAvailable,Active,Email,Phone,Fax,CreateDate,Type,RoomRentMode,ReportDate, " +
                    "GroupId,OpenTime,CloseTime,DefaultAdminPassword,HasProducts,HasNews,HasImageCollections,HasMultipleLanguage,HasWebPages,HasCustomerFeedbacks," +
                    "BrandId,HasOrder,HasBlogEditCollections,LogoUrl,FbAccessToken,StoreFeatureFilter,RunReport,AttendanceStoreFilter,StoreCode,PosId,StoreConfig," +
                    "DefaultDashBoard,PaymentTypeApply,ModeStore) " +
                    "values(4,'vu', 'anh vu', 'hcm', 12, 123, 79, 756, '', 1, '', '', 5456645656, '', '', 5, 2, '', null, null, null, null, null, null, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null)";
*/

                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                SqlDataReader reader1 = null;
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                { 
                    storeDTO = new StoreDTO();
                    if(reader1.IsDBNull(0))
                    {
                        storeDTO.Name = null;
                    }
                    else
                    {
                        storeDTO.Name = reader1.GetString(0);
                    }
                    if (reader1.IsDBNull(1))
                    {
                        storeDTO.ShortName = null;
                    }
                    else
                    {
                        storeDTO.ShortName= reader1.GetString(1);
                    }
                    if (reader1.IsDBNull(2))
                    {
                        storeDTO.Address = null;
                    }
                    else
                    {
                        storeDTO.Address = reader1.GetString(2);
                    }
                    if (reader1.IsDBNull(3))
                    {
                        storeDTO.Lat = null;
                    }
                    else
                    {
                        storeDTO.Lat = reader1.GetString(3); 
                    }
                    if (reader1.IsDBNull(4))
                    {
                        storeDTO.Lon = null;
                    }
                    else
                    {
                        storeDTO.Lon = reader1.GetString(4);
                    }
                    if (reader1.IsDBNull(5))
                    {
                        storeDTO.Province = null;
                    }
                    else
                    {
                        storeDTO.Province = reader1.GetString(5); 
                    }
                    if (reader1.IsDBNull(6))
                    {
                        storeDTO.District = null;
                    }
                    else
                    {
                        storeDTO.District = reader1.GetString(6);
                    }
                    if (reader1.IsDBNull(7))
                    {
                        storeDTO.Ward = null;
                    }
                    else
                    {
                        storeDTO.Ward= reader1.GetString(7);
                    }
                    if (reader1.IsDBNull(8))
                    {
                        storeDTO.isAvailable = null;
                    }
                    else
                    {
                        storeDTO.isAvailable = reader1.GetBoolean(8);
                    }
                    if (reader1.IsDBNull(9))
                    {
                        storeDTO.Active = null;
                    }
                    else
                    {
                        storeDTO.Active = reader1.GetBoolean(9);
                    }
                    if (reader1.IsDBNull(10))
                    {
                        storeDTO.Email = null;
                    }
                    else
                    {
                        storeDTO.Email = reader1.GetString(10);
                    }
                    if (reader1.IsDBNull(11))
                    {
                        storeDTO.Phone = null;
                    }
                    else
                    {
                        storeDTO.Phone = reader1.GetString(11);
                    }
                    if (reader1.IsDBNull(12))
                    {
                        storeDTO.Fax = null;
                    }
                    else
                    {
                        storeDTO.Fax = reader1.GetString(12);
                    }
                    if (reader1.IsDBNull(13))
                    {
                        storeDTO.CreateDate = null;
                    }
                    else
                    {
                        storeDTO.CreateDate= reader1.GetDateTime(13);
                    }
                    if (reader1.IsDBNull(14))
                    {
                        storeDTO.Type = null;
                    }
                    else
                    {
                        storeDTO.Type = reader1.GetInt32(14);
                    }
                    if (reader1.IsDBNull(15))
                    {
                        storeDTO.RoomRentMode = null;
                    }
                    else
                    {
                        storeDTO.RoomRentMode = reader1.GetInt32(15);
                    }
                    if (reader1.IsDBNull(16))
                    {
                        storeDTO.ReportDate = null;
                    }
                    else
                    {
                        storeDTO.ReportDate = reader1.GetDateTime(16);
                    }
                    if (reader1.IsDBNull(17))
                    {
                        storeDTO.GroupId = null;
                    }
                    else
                    {
                        storeDTO.GroupId = reader1.GetInt32(17);
                    }
                    if (reader1.IsDBNull(18))
                    {
                        storeDTO.OpenTime = null;
                    }
                    else
                    {
                        storeDTO.OpenTime = reader1.GetDateTime(18);
                    }
                    if (reader1.IsDBNull(19))
                    {
                        storeDTO.CloseTime = null;
                    }
                    else
                    {
                        storeDTO.CloseTime = reader1.GetDateTime(19);
                    }
                    if (reader1.IsDBNull(20))
                    {
                        storeDTO.DefaultAdminPassword = null;
                    }
                    else
                    {
                        storeDTO.DefaultAdminPassword = reader1.GetString(20);
                    }
                    if (reader1.IsDBNull(21))
                    {
                        storeDTO.HasProducts = null;
                    }
                    else
                    {
                        storeDTO.HasProducts = reader1.GetBoolean(21);
                    }
                    if (reader1.IsDBNull(22))
                    {
                        storeDTO.HasNews = null;
                    }
                    else
                    {
                        storeDTO.HasNews = reader1.GetBoolean(22);
                    }
                    if (reader1.IsDBNull(23))
                    {
                        storeDTO.HasImageCollections = null;
                    }
                    else
                    {
                        storeDTO.HasImageCollections = reader1.GetBoolean(23);
                    }
                    if (reader1.IsDBNull(24))
                    {
                        storeDTO.HasMultipleLanguage = null;
                    }
                    else
                    {
                        storeDTO.HasMultipleLanguage = reader1.GetBoolean(24);
                    }
                    if (reader1.IsDBNull(25))
                    {
                        storeDTO.HasWebPages = null;
                    }
                    else
                    {
                        storeDTO.HasWebPages = reader1.GetBoolean(25);
                    }
                    if (reader1.IsDBNull(26))
                    {
                        storeDTO.HasCustomerFeedbacks = null;
                    }
                    else
                    {
                        storeDTO.HasCustomerFeedbacks = reader1.GetBoolean(26);
                    }
                    if (reader1.IsDBNull(27))
                    {
                        storeDTO.BrandId = null;
                    }
                    else
                    {
                        storeDTO.BrandId = reader1.GetInt32(27);
                    }
                    if (reader1.IsDBNull(28))
                    {
                        storeDTO.HasOrder = null;
                    }
                    else
                    {
                        storeDTO.HasOrder = reader1.GetBoolean(28);
                    }
                    if (reader1.IsDBNull(29))
                    {
                        storeDTO.HasBlogEditCollections = null;
                    }
                    else
                    {
                        storeDTO.HasBlogEditCollections = reader1.GetBoolean(29);
                    }
                    if (reader1.IsDBNull(30))
                    {
                        storeDTO.LogoUrl = null;
                    }
                    else
                    {
                        storeDTO.LogoUrl = reader1.GetString(30);
                    }
                    if (reader1.IsDBNull(31))
                    {
                        storeDTO.FbAccessToken = null;
                    }
                    else
                    {
                        storeDTO.FbAccessToken = reader1.GetString(31);
                    }
                    if (reader1.IsDBNull(32))
                    {
                        storeDTO.StoreFeatureFilter = null;
                    }
                    else
                    {
                        storeDTO.StoreFeatureFilter = reader1.GetString(32);
                    }
                    if (reader1.IsDBNull(33))
                    {
                        storeDTO.RunReport = null;
                    }
                    else
                    {
                        storeDTO.RunReport = reader1.GetBoolean(33);
                    }
                    if (reader1.IsDBNull(34))
                    {
                        storeDTO.AttendanceStoreFilter = null;
                    }
                    else
                    {
                        storeDTO.AttendanceStoreFilter = reader1.GetInt32(34);
                    }
                    if (reader1.IsDBNull(35))
                    {
                        storeDTO.StoreCode = null;
                    }
                    else
                    {
                        storeDTO.StoreCode = reader1.GetString(35);
                    }
                    if (reader1.IsDBNull(36))
                    {
                        storeDTO.PosId = null;
                    }
                    else
                    {
                        storeDTO.PosId = reader1.GetInt32(36);
                    }
                    if (reader1.IsDBNull(37))
                    {
                        storeDTO.StoreConfig = null;
                    }
                    else
                    {
                        storeDTO.StoreConfig = reader1.GetString(37);
                    }
                    if (reader1.IsDBNull(38))
                    {
                        storeDTO.DefaultDashBoard = null;
                    }
                    else
                    {
                        storeDTO.DefaultDashBoard = reader1.GetString(38);
                    }
                    if (reader1.IsDBNull(39))
                    {
                        storeDTO.PaymentTypeApply = null;
                    }
                    else
                    {
                        storeDTO.PaymentTypeApply = reader1.GetInt32(39);
                    }
                    if (reader1.IsDBNull(40))
                    {
                        storeDTO.ModeStore = null;
                    }
                    else
                    {
                        storeDTO.ModeStore = reader1.GetInt32(40);
                    }
                    if (reader1.IsDBNull(41))
                    {
                        storeDTO.ID = null;
                    }
                    else
                    {
                        storeDTO.ID = reader1.GetInt32(41);
                    }
                    if (storeList == null)
                    {
                        storeList = new List<StoreDTO> { storeDTO };
                    }
                    storeList.Add(storeDTO);
                    
                }


                foreach (var store in storeList)
                {
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.Parameters.AddWithValue("@ID", store.ID);
                    SqlParameter p0 = cmd2.Parameters.AddWithValue("@Name", store.Name);
                    if (store.Name == null)
                    {
                        p0.Value = DBNull.Value;
                    }
                    SqlParameter p1 = cmd2.Parameters.AddWithValue("@ShortName", store.ShortName);
                    if (store.ShortName == null)
                    {
                        p1.Value = DBNull.Value;
                    }
                    SqlParameter p2 = cmd2.Parameters.AddWithValue("@Address", store.Address);
                    if (store.Address == null)
                    {
                        p2.Value = DBNull.Value;
                    }
                    SqlParameter p3 = cmd2.Parameters.AddWithValue("@Lat", store.Lat);
                    if (store.Lat == null)
                    {
                        p3.Value = DBNull.Value;
                    }
                    SqlParameter p4 = cmd2.Parameters.AddWithValue("@Lon", store.Lon);
                    if (store.Lon == null)
                    {
                        p4.Value = DBNull.Value;
                    }
                    SqlParameter p5 = cmd2.Parameters.AddWithValue("@Province", store.Province);
                    if (store.Province == null)
                    {
                        p5.Value = DBNull.Value;
                    }
                    SqlParameter p6 = cmd2.Parameters.AddWithValue("@District", store.District);
                    if (store.District == null)
                    {
                        p6.Value = DBNull.Value;
                    }
                    SqlParameter p7 = cmd2.Parameters.AddWithValue("@Ward", store.Ward);
                    if (store.Ward == null)
                    {
                        p7.Value = DBNull.Value;
                    }
                    SqlParameter p8 = cmd2.Parameters.AddWithValue("@isAvailable", store.isAvailable);
                    if (store.isAvailable == null)
                    {
                        p8.Value = DBNull.Value;
                    }
                    SqlParameter p9 = cmd2.Parameters.AddWithValue("@Active", store.Active);
                    if (store.Active == null)
                    {
                        p9.Value = DBNull.Value;
                    }
                    SqlParameter p10 = cmd2.Parameters.AddWithValue("@Email", store.Email);
                    if (store.Email == null)
                    {
                        p10.Value = DBNull.Value;
                    }
                    SqlParameter p11 = cmd2.Parameters.AddWithValue("@Phone", store.Phone);
                    if (store.Phone == null)
                    {
                        p11.Value = DBNull.Value;
                    }
                    SqlParameter p12 = cmd2.Parameters.AddWithValue("@Fax", store.Fax);
                    if (store.Fax == null)
                    {
                        p12.Value = DBNull.Value;
                    }
                    SqlParameter p13 = cmd2.Parameters.AddWithValue("@CreateDate", store.CreateDate);
                    if (store.CreateDate == null)
                    {
                        p13.Value = DBNull.Value;
                    }
                    SqlParameter p14 = cmd2.Parameters.AddWithValue("@Type", store.Type);
                    if (store.Type == null)
                    {
                        p14.Value = DBNull.Value;
                    }
                    SqlParameter p15 = cmd2.Parameters.AddWithValue("@RoomRentMode", store.RoomRentMode);
                    if (store.RoomRentMode == null)
                    {
                        p15.Value = DBNull.Value;
                    }
                    SqlParameter p16 = cmd2.Parameters.AddWithValue("@ReportDate", store.ReportDate);
                    if (store.ReportDate == null)
                    {
                        p16.Value = DBNull.Value;
                    }
                    SqlParameter p17 = cmd2.Parameters.AddWithValue("@GroupId", store.GroupId);
                    if (store.GroupId == null)
                    {
                        p17.Value = DBNull.Value;
                    }
                    SqlParameter p18 = cmd2.Parameters.AddWithValue("@OpenTime", store.OpenTime);
                    if (store.OpenTime == null)
                    {
                        p18.Value = DBNull.Value;
                    }
                    SqlParameter p19 = cmd2.Parameters.AddWithValue("@CloseTime", store.CloseTime);
                    if (store.CloseTime == null)
                    {
                        p19.Value = DBNull.Value;
                    }
                    SqlParameter p20 = cmd2.Parameters.AddWithValue("@DefaultAdminPassword", store.DefaultAdminPassword);
                    if (store.DefaultAdminPassword == null)
                    {
                        p20.Value = DBNull.Value;
                    }
                    SqlParameter p21 = cmd2.Parameters.AddWithValue("@HasProducts", store.HasProducts);
                    if (store.HasProducts == null)
                    {
                        p21.Value = DBNull.Value;
                    }
                    SqlParameter p22 = cmd2.Parameters.AddWithValue("@HasNews", store.HasNews);
                    if (store.HasNews == null)
                    {
                        p22.Value = DBNull.Value;
                    }
                    SqlParameter p23 = cmd2.Parameters.AddWithValue("@HasImageCollections", store.HasImageCollections);
                    if (store.HasImageCollections == null)
                    {
                        p23.Value = DBNull.Value;
                    }
                    SqlParameter p24 = cmd2.Parameters.AddWithValue("@HasMultipleLanguage", store.HasMultipleLanguage);
                    if (store.HasMultipleLanguage == null)
                    {
                        p24.Value = DBNull.Value;
                    }
                    SqlParameter p25 = cmd2.Parameters.AddWithValue("@HasWebPages", store.HasWebPages);
                    if (store.HasWebPages == null)
                    {
                        p25.Value = DBNull.Value;
                    }
                    SqlParameter p26 = cmd2.Parameters.AddWithValue("@HasCustomerFeedbacks", store.HasCustomerFeedbacks);
                    if (store.HasCustomerFeedbacks == null)
                    {
                        p26.Value = DBNull.Value;
                    }
                    SqlParameter p27 = cmd2.Parameters.AddWithValue("@BrandId", store.BrandId);
                    if (store.BrandId == null)
                    {
                        p27.Value = DBNull.Value;
                    }
                    SqlParameter p28 = cmd2.Parameters.AddWithValue("@HasOrder", store.HasOrder);
                    if (store.HasOrder == null)
                    {
                        p28.Value = DBNull.Value;
                    }
                    SqlParameter p29 = cmd2.Parameters.AddWithValue("@HasBlogEditCollections", store.HasBlogEditCollections);
                    if (store.HasBlogEditCollections == null)
                    {
                        p29.Value = DBNull.Value;
                    }
                    SqlParameter p30 = cmd2.Parameters.AddWithValue("@LogoUrl", store.LogoUrl);
                    if (store.LogoUrl == null)
                    {
                        p30.Value = DBNull.Value;
                    }
                    SqlParameter p31 = cmd2.Parameters.AddWithValue("@FbAccessToken", store.FbAccessToken);
                    if (store.FbAccessToken == null)
                    {
                        p31.Value = DBNull.Value;
                    }
                    SqlParameter p32 = cmd2.Parameters.AddWithValue("@StoreFeatureFilter", store.StoreFeatureFilter);
                    if (store.StoreFeatureFilter == null)
                    {
                        p32.Value = DBNull.Value;
                    }
                    SqlParameter p33 = cmd2.Parameters.AddWithValue("@RunReport", store.RunReport);
                    if (store.RunReport == null)
                    {
                        p33.Value = DBNull.Value;
                    }
                    SqlParameter p34 = cmd2.Parameters.AddWithValue("@AttendanceStoreFilter", store.AttendanceStoreFilter);
                    if (store.AttendanceStoreFilter == null)
                    {
                        p34.Value = DBNull.Value;
                    }
                    SqlParameter p35 = cmd2.Parameters.AddWithValue("@StoreCode", store.StoreCode);
                    if (store.StoreCode == null)
                    {
                        p35.Value = DBNull.Value;
                    }
                    SqlParameter p36 = cmd2.Parameters.AddWithValue("@PosId", store.PosId);
                    if (store.PosId == null)
                    {
                        p36.Value = DBNull.Value;
                    }
                    SqlParameter p37 = cmd2.Parameters.AddWithValue("@StoreConfig", store.StoreConfig);
                    if (store.StoreConfig == null)
                    {
                        p37.Value = DBNull.Value;
                    }
                    SqlParameter p38 = cmd2.Parameters.AddWithValue("@DefaultDashBoard", store.DefaultDashBoard);
                    if (store.DefaultDashBoard == null)
                    {
                        p38.Value = DBNull.Value;
                    }
                    SqlParameter p39 = cmd2.Parameters.AddWithValue("@PaymentTypeApply", store.PaymentTypeApply);
                    if (store.PaymentTypeApply == null)
                    {
                        p39.Value = DBNull.Value;
                    }
                    SqlParameter p40 = cmd2.Parameters.AddWithValue("@ModeStore", store.ModeStore);
                    if (store.ModeStore == null)
                    {
                        p40.Value = DBNull.Value;
                    }

                    cmd2.ExecuteNonQuery();


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
