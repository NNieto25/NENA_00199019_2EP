using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public static class BusinessDAO
    {
        public static void CreateBusiness(Business business)
        {
            String querySql = $"INSERT INTO BUSINESS(name, description) VALUES('{business.Name}'," +
                              $"'{business.Description}');";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static List<Business> GetBusiness()
        {
            String querySql = "SELECT * FROM BUSINESS";
            var table = ConnectionDB.ExecuteQuery(querySql);
            List<Business> list = new List<Business>();
            foreach (DataRow row in table.Rows)
            {
                Business business = new Business();
                business.IdBusiness = Convert.ToInt32(row[0].ToString());
                business.Name = row[1].ToString();
                business.Description = row[2].ToString();
                list.Add(business);
            }
            return list;
        }

        public static void DeleteBusiness(Business business)
        {
            String querySql = $"DELETE FROM BUSINESS WHERE idbusiness = {business.IdBusiness}";
            ConnectionDB.ExecuteNonQuery(querySql);
        }
    }
}