using DataTransmission.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Data
{
    internal class BrandDAO
    {
        public void ReadBrand()
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

                string sql1 = "select BrandName,CreateDate,Active,Description,CompanyName,ContactPerson,PhoneNumber,Fax,Website,VATCode,VATTemplate,Address, " +
                    "ApiSMSKey,SecurityApiSMSKey,SMSType,BrandNameSMS,JsonConfigUrl,BrandFeatureFilter,WiskyId,DefaultDashBoard,RSAPrivateKey, " +
                    "RSAPublicKey,PGPPassword,PGPPrivateKey,PGPPulblicKey,DesKey,DesVector,AccessToken,TaxCode, Id " +
                    "from Brand";
                string sql2 = "INSERT INTO Brand(Id, BrandName,CreateDate,Active,Description,CompanyName,ContactPerson,PhoneNumber,Fax,Website,VATCode,VATTemplate,Address," +
                    "ApiSMSKey,SecurityApiSMSKey,SMSType,BrandNameSMS,JsonConfigUrl,BrandFeatureFilter,WiskyId,DefaultDashBoard,RSAPrivateKey," +
                    "RSAPublicKey,PGPPassword,PGPPrivateKey,PGPPulblicKey,DesKey,DesVector,AccessToken,TaxCode) " +
                    "VALUES (@Id, @BrandName, @CreateDate, @Active, @Description, @CompanyName, @ContactPerson, @PhoneNumber, @Fax, @Website, @VATCode, @VATTemplate, @Address, @ApiSMSKey, " +
                    "@SecurityApiSMSKey, @SMSType, @BrandNameSMS, @JsonConfigUrl, @BrandFeatureFilter, @WiskyId, @DefaultDashBoard, @RSAPrivateKey, @RSAPublicKey, @PGPPassword, " +
                    "@PGPPrivateKey, @PGPPulblicKey, @DesKey, @DesVector, @AccessToken, @TaxCode)";

                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                SqlDataReader reader1 = null;
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    brandDTO = new BrandDTO();
                    
                    if (reader1.IsDBNull(0))
                    {
                        brandDTO.BrandName = null;
                    }
                    else
                    {
                        brandDTO.BrandName = reader1.GetString(0);
                    }
                    brandDTO.CreateDate = reader1.GetDateTime(1);
                    brandDTO.Active = reader1.GetBoolean(2);
                    if (reader1.IsDBNull(3))
                    {
                        brandDTO.Description = null;
                    }
                    else
                    {
                        brandDTO.Description = reader1.GetString(3);
                    }
                   
                    if (reader1.IsDBNull(4))
                    {
                        brandDTO.CompanyName = null;
                    }
                    else
                    {
                        brandDTO.CompanyName = reader1.GetString(4);
                    }
                    if (reader1.IsDBNull(5))
                    {
                        brandDTO.ContactPerson = null;
                    }
                    else
                    {
                        brandDTO.ContactPerson = reader1.GetString(5);
                    }
                    if (reader1.IsDBNull(6))
                    {
                        brandDTO.PhoneNumber = null;
                    }
                    else
                    {
                        brandDTO.PhoneNumber = reader1.GetString(6);
                    }
                    if (reader1.IsDBNull(7))
                    {
                        brandDTO.Fax = null;
                    }
                    else
                    {
                        brandDTO.Fax = reader1.GetString(7);
                    }
                    if (reader1.IsDBNull(8))
                    {
                        brandDTO.Website = null;
                    }
                    else
                    {
                        brandDTO.Website = reader1.GetString(8);
                    }
                    if (reader1.IsDBNull(9))
                    {
                        brandDTO.VATCode = null;
                    }
                    else
                    {
                        brandDTO.VATCode = reader1.GetString(9);
                    }
                    if (reader1.IsDBNull(10))
                    {
                        brandDTO.VATTemplate = null;
                    }
                    else
                    {
                        brandDTO.VATTemplate = reader1.GetInt32(10);
                    }
                    if (reader1.IsDBNull(11))
                    {
                        brandDTO.Address = null;
                    }
                    else
                    {
                        brandDTO.Address = reader1.GetString(11);
                    }
                    if (reader1.IsDBNull(12))
                    {
                        brandDTO.ApiSMSKey = null;
                    }
                    else
                    {
                        brandDTO.ApiSMSKey = reader1.GetString(12);
                    }
                    if (reader1.IsDBNull(13))
                    {
                        brandDTO.SecurityApiSMSKey = null;
                    }
                    else
                    {
                        brandDTO.SecurityApiSMSKey = reader1.GetString(13);
                    }
                    if (reader1.IsDBNull(14))
                    {
                        brandDTO.SMSType = null;
                    }
                    else
                    {
                        brandDTO.SMSType = reader1.GetInt32(14);
                    }
                    if (reader1.IsDBNull(15))
                    {
                        brandDTO.BrandNameSMS = null;
                    }
                    else
                    {
                        brandDTO.BrandNameSMS = reader1.GetString(15);
                    }
                    if (reader1.IsDBNull(16))
                    {
                        brandDTO.JsonConfigUrl = null;
                    }
                    else
                    {
                        brandDTO.JsonConfigUrl = reader1.GetString(16);
                    }
                    if (reader1.IsDBNull(17))
                    {
                        brandDTO.BrandFeatureFilter = null;
                    }
                    else
                    {
                        brandDTO.BrandFeatureFilter = reader1.GetString(17);
                    }
                    if (reader1.IsDBNull(18))
                    {
                        brandDTO.WiskyId = null;
                    }
                    else
                    {
                        brandDTO.WiskyId = reader1.GetInt32(18);
                    }
                    if (reader1.IsDBNull(19))
                    {
                        brandDTO.DefaultDashBoard = null;
                    }
                    else
                    {
                        brandDTO.DefaultDashBoard = reader1.GetString(19);
                    }
                    if (reader1.IsDBNull(20))
                    {
                        brandDTO.RSAPrivateKey = null;
                    }
                    else
                    {
                        brandDTO.RSAPrivateKey = reader1.GetString(20);
                    }
                    if (reader1.IsDBNull(21))
                    {
                        brandDTO.RSAPublicKey = null;
                    }
                    else
                    {
                        brandDTO.RSAPublicKey = reader1.GetString(21);
                    }
                    if (reader1.IsDBNull(22))
                    {
                        brandDTO.PGPPassword = null;
                    }
                    else
                    {
                        brandDTO.PGPPassword = reader1.GetString(22);
                    }
                    if (reader1.IsDBNull(23))
                    {
                        brandDTO.PGPPrivateKey = null;
                    }
                    else
                    {
                        brandDTO.PGPPrivateKey = reader1.GetString(23);
                    }
                    if (reader1.IsDBNull(24))
                    {
                        brandDTO.PGPPulblicKey = null;
                    }
                    else
                    {
                        brandDTO.PGPPulblicKey = reader1.GetString(24);
                    }
                    if (reader1.IsDBNull(25))
                    {
                        brandDTO.DesKey = null;
                    }
                    else
                    {
                        brandDTO.DesKey = reader1.GetString(25);
                    }
                    if (reader1.IsDBNull(26))
                    {
                        brandDTO.DesVector = null;
                    }
                    else
                    {
                        brandDTO.DesVector = reader1.GetString(26);
                    }
                    if (reader1.IsDBNull(27))
                    {
                        brandDTO.AccessToken = null;
                    }
                    else
                    {
                        brandDTO.AccessToken = reader1.GetString(27);
                    }
                    if (reader1.IsDBNull(28))
                    {
                        brandDTO.TaxCode = null;
                    }
                    else
                    {
                        brandDTO.TaxCode = reader1.GetString(28);
                    }
                    if (reader1.IsDBNull(29))
                    {
                        brandDTO.Id = null;
                    }
                    else
                    {
                        brandDTO.Id = reader1.GetInt32(29);
                    }
                    
                    if(brandList == null)
                    {
                        brandList = new List<BrandDTO>();
                    }
                    brandList.Add(brandDTO);
                }

                foreach(var brand in brandList)
                {
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.Parameters.AddWithValue("@Id", brand.Id);
                    SqlParameter p0 = cmd2.Parameters.AddWithValue("@BrandName", brand.BrandName);
                    if(brand.BrandName == null)
                    {
                        p0.Value = DBNull.Value;
                    }
                   SqlParameter p1= cmd2.Parameters.AddWithValue("@CreateDate", brand.CreateDate);
                    if(brand.CreateDate == null)
                    {
                        p1.Value = DBNull.Value;
                    }
                   SqlParameter p2 = cmd2.Parameters.AddWithValue("@Active", brand.Active);
                    if(brand.Active == null)
                    {
                        p2.Value = DBNull.Value;
                    }
                   SqlParameter p3 = cmd2.Parameters.AddWithValue("@Description", brand.Description);
                    if(brand.Description == null)
                    {
                        p3.Value = DBNull.Value;
                    }
                   SqlParameter p4 = cmd2.Parameters.AddWithValue("@CompanyName", brand.CompanyName);
                    if(brand.CompanyName == null)
                    {
                        p4.Value = DBNull.Value;
                    }
                   SqlParameter p5 = cmd2.Parameters.AddWithValue("@ContactPerson", brand.ContactPerson);
                    if(brand.ContactPerson == null)
                    {
                        p5.Value = DBNull.Value;
                    }
                   SqlParameter p6 = cmd2.Parameters.AddWithValue("@PhoneNumber", brand.PhoneNumber);
                    if(brand.PhoneNumber == null)
                    {
                        p6.Value = DBNull.Value;
                    }
                   SqlParameter p7 = cmd2.Parameters.AddWithValue("@Fax", brand.Fax);
                    if(brand.Fax == null)
                    {
                        p7.Value = DBNull.Value;
                    }
                   SqlParameter p8 = cmd2.Parameters.AddWithValue("@Website", brand.Website);
                    if(brand.Website == null)
                    {
                        p8.Value = DBNull.Value;
                    }
                   SqlParameter p9 = cmd2.Parameters.AddWithValue("@VATCode", brand.VATCode);
                    if(brand.VATCode == null)
                    {
                        p9.Value = DBNull.Value;
                    }
                   SqlParameter p10 = cmd2.Parameters.AddWithValue("@VATTemplate",brand.VATTemplate);
                    if(brand.VATTemplate == null)
                    {
                        p10.Value = DBNull.Value;
                    }
                   SqlParameter p11 = cmd2.Parameters.AddWithValue("@Address", brand.Address);
                    if(brand.Address == null)
                    {
                        p11.Value = DBNull.Value;
                    }
                   SqlParameter p12 = cmd2.Parameters.AddWithValue("@ApiSMSKey", brand.ApiSMSKey);
                    if(brand.ApiSMSKey == null)
                    {
                        p12.Value = DBNull.Value;
                    }
                   SqlParameter p13 = cmd2.Parameters.AddWithValue("@SecurityApiSMSKey", brand.SecurityApiSMSKey);
                    if(brand.SecurityApiSMSKey == null)
                    {
                        p13.Value = DBNull.Value;
                    }
                   SqlParameter p14 = cmd2.Parameters.AddWithValue("@SMSType", brand.SMSType);
                    if(brand.SMSType == null)
                    {
                        p14.Value = DBNull.Value;
                    }
                   SqlParameter p15 = cmd2.Parameters.AddWithValue("@BrandNameSMS", brand.BrandNameSMS);
                    if(brand.BrandNameSMS == null)
                    {
                        p15.Value = DBNull.Value;
                    }
                   SqlParameter p16 = cmd2.Parameters.AddWithValue("@JsonConfigUrl", brand.JsonConfigUrl);
                    if(brand.JsonConfigUrl == null)
                    {
                        p16.Value = DBNull.Value;
                    }
                   SqlParameter p17 = cmd2.Parameters.AddWithValue("@BrandFeatureFilter", brand.BrandFeatureFilter);
                    if(brand.BrandFeatureFilter == null)
                    {
                        p17.Value = DBNull.Value;
                    }
                   SqlParameter p18 = cmd2.Parameters.AddWithValue("@WiskyId", brand.WiskyId);
                    if(brand.WiskyId == null)
                    {
                        p18.Value = DBNull.Value;
                    }
                   SqlParameter p19 = cmd2.Parameters.AddWithValue("@DefaultDashBoard", brand.DefaultDashBoard);
                    if(brand.DefaultDashBoard == null)
                    {
                        p19.Value = DBNull.Value;
                    }
                   SqlParameter p20 = cmd2.Parameters.AddWithValue("@RSAPrivateKey", brand.RSAPrivateKey);
                    if(brand.RSAPrivateKey == null)
                    {
                        p20.Value = DBNull.Value;
                    }
                   SqlParameter p21 = cmd2.Parameters.AddWithValue("@RSAPublicKey", brand.RSAPublicKey);
                    if(brand.RSAPublicKey == null)
                    {
                        p21.Value = DBNull.Value;
                    }
                   SqlParameter p22 = cmd2.Parameters.AddWithValue("@PGPPassword", brand.PGPPassword);
                    if(brand.PGPPassword == null)
                    {
                        p22.Value = DBNull.Value;
                    }
                   SqlParameter p23 = cmd2.Parameters.AddWithValue("@PGPPrivateKey", brand.PGPPrivateKey);
                    if(brand.PGPPrivateKey == null)
                    {
                        p23.Value = DBNull.Value;
                    }
                   SqlParameter p24 = cmd2.Parameters.AddWithValue("@PGPPulblicKey", brand.PGPPulblicKey);
                    if(brand.PGPPulblicKey == null)
                    {
                        p24.Value = DBNull.Value;
                    }
                   SqlParameter p25 = cmd2.Parameters.AddWithValue("@DesKey", brand.DesKey);
                    if(brand.DesKey == null)
                    {
                        p25.Value = DBNull.Value;
                    }
                   SqlParameter p26 = cmd2.Parameters.AddWithValue("@DesVector", brand.DesVector);
                    if(brand.DesVector == null)
                    {
                        p26.Value = DBNull.Value;
                    }
                   SqlParameter p27 = cmd2.Parameters.AddWithValue("@AccessToken", brand.AccessToken);
                    if (brand.AccessToken == null) {
                        p27.Value = DBNull.Value;
                    }
                   SqlParameter p28 = cmd2.Parameters.AddWithValue("@TaxCode", brand.TaxCode);
                    if (brand.TaxCode == null)
                    {
                        p28.Value = DBNull.Value;
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
