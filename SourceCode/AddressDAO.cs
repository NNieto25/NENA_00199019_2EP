using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public static class AddressDAO
    {
        public static List<Address> GetAddress(int idUser)
        {
            var table = ConnectionDB.ExecuteQuery($"SELECT * FROM ADDRESS WHERE iduser = {idUser} " +
                                                  $"ORDER BY idaddress ASC;");
            List<Address> list = new List<Address>();
            foreach (DataRow row in table.Rows)
            {
                Address address = new Address();
                address.IdAddress = Convert.ToInt32(row[0].ToString());
                address.IdUser = Convert.ToInt32(row[1].ToString());
                address.SAddress = row[2].ToString();
                list.Add(address);
            }

            return list;
        }
        public static Address GetAddress(int index,int idUser)
        {
            String querySql = $"SELECT * FROM ADDRESS WHERE idaddress = {index} AND iduser = {idUser};";
            DataTable table = ConnectionDB.ExecuteQuery(querySql);
            Address address = new Address();
            address.IdUser = idUser;
            address.IdAddress = index;
            foreach (DataRow row in table.Rows)
            {
                address.IdAddress = Convert.ToInt32(row[0].ToString());
                address.SAddress = row[2].ToString();
            }
            return address;
        }
        public static DataTable GetAddressTable(int idUser)
        {
            String querySql = $"SELECT idaddress, address FROM ADDRESS WHERE iduser = {idUser} ORDER BY idaddress ASC;";
            var table = ConnectionDB.ExecuteQuery(querySql);
            return table;
        }

        public static void CreateAddress(Address address)
        {
            String querySql = $"INSERT INTO ADDRESS(iduser,address) VALUES ({address.IdUser},'{address.SAddress}');";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static void UpdateAddress(Address address)
        {
            String querySql = $"UPDATE ADDRESS SET address = '{address.SAddress}' WHERE idaddress = " +
                              $"{address.IdAddress};";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static void DeleteAddress(Address address)
        {
            String querySql = $"DELETE FROM ADDRESS WHERE idaddress = {address.IdAddress} " +
                              $"AND iduser = {address.IdUser}";
            ConnectionDB.ExecuteNonQuery(querySql);
        }
        
    }
}