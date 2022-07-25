using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission
{
    internal class Mixin
    {
        public String Check(int num, String name, SqlDataReader reader)
        {
            if (reader.IsDBNull(num))
            {
                name = null;
            }
            else
            {
                name = reader.GetString(num);
            }
            return name;
        }
        public int Check(int num, int? name, SqlDataReader reader)
        {
            if (reader.IsDBNull(num))
            {
                name = null;
            }
            else
            {
                name = reader.GetInt32(num);
            }
            return Convert.ToInt32(name);
        }
        public double Check(int num, double? name, SqlDataReader reader)
        {
            if (reader.IsDBNull(num))
            {
                name = null;
            }
            else
            {
                name = reader.GetDouble(num);
            }
            return (double)Convert.ToDouble(name);
        }
        public bool Check(int num, Boolean? name, SqlDataReader reader)
        {
            if (reader.IsDBNull(num))
            {
                name = null;
            }
            else
            {
                name = reader.GetBoolean(num);
            }
            return Convert.ToBoolean(name);
        }
        public DateTime Check(int num, DateTime? name, SqlDataReader reader)
        {
            if (reader.IsDBNull(num))
            {
                name = null;
            }
            else
            {
                name = reader.GetDateTime(num);
            }
            return Convert.ToDateTime(name);
        }
    }
}
