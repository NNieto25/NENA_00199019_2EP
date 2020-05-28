using System;
using System.Data;

namespace SourceCode
{
    public static class OrderDAO
    {
        public static void CreateOrder(Order order)
        {
            String querySql = $"INSERT INTO APPORDER(createdate,idproduct,idaddress) VALUES " +
                              $"('{order.CreateDate.ToString("d")}',{order.IdProduct}," +
                              $"{order.IdAddress});";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static DataTable GetOrderTable(int userId)
        {
            String querySql = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address" + 
            " FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au" + 
            " WHERE ao.idProduct = pr.idProduct" + 
            " AND ao.idAddress = ad.idAddress" + 
            " AND ad.idUser = au.idUser" + 
            $" AND au.idUser = {userId};";
            
            var table = ConnectionDB.ExecuteQuery(querySql);
            return table;
        }
        
        public static DataTable GetOrderTable()
        {
            String querySql = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address" + 
                              " FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au" + 
                              " WHERE ao.idProduct = pr.idProduct" + 
                              " AND ao.idAddress = ad.idAddress" + 
                              " AND ad.idUser = au.idUser;";
            var table = ConnectionDB.ExecuteQuery(querySql);
            return table;
        }
        public static void DeleteOrder(int userID, int orderID)
        {
            String query = $"DELETE from apporder where idorder = {orderID} AND idaddress IN " +
                           $"(SELECT idaddress FROM ADDRESS WHERE iduser = " +
                           $"(SELECT iduser FROM APPUSER WHERE iduser = {userID}));";
            ConnectionDB.ExecuteNonQuery(query);
        }
    }
}