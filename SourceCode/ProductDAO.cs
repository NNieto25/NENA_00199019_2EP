using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public static class ProductDAO
    {
        public static List<Product> GetProducts(int idBusiness)
        {
            String querySql = $"SELECT * FROM PRODUCT WHERE idbusiness = {idBusiness};";
            var table = ConnectionDB.ExecuteQuery(querySql);
            List<Product> products = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product();
                product.IdProduct = Convert.ToInt32(row[0].ToString());
                product.IdBusiness = Convert.ToInt32(row[1].ToString());
                product.Name = row[2].ToString();
                products.Add(product);
            }
            return products;
        }

        public static void CreateProduct(Product product)
        {
            String querySql = $"INSERT INTO PRODUCT(idbusiness,name) VALUES ({product.IdBusiness}, '{product.Name}');";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static void DeleteProduct(Product product, int idBusiness)
        {
            String querySql = $"DELETE FROM PRODUCT WHERE name = '{product.Name}' AND idbusiness = {idBusiness} " +
                              $"AND idproduct = {product.IdProduct};";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static DataTable GetSumByProduct()
        {
            String query = $"SELECT b.name AS \"Negocio\", sum(cp.cant) AS \"Total pedidos\"" +
            " FROM BUSINESS b,"  +
            " (SELECT p.idBusiness, p.name, count(ap.idProduct) AS \"cant\" "+
            " FROM PRODUCT p, APPORDER ap " +
                "WHERE p.idProduct = ap.idProduct" +
            " GROUP BY p.idProduct " +
                "ORDER BY p.name ASC) AS cp" +
            " WHERE b.idBusiness = cp.idBusiness" +
            " GROUP BY b.idBusiness;";
            return ConnectionDB.ExecuteQuery(query);
        }
    }
}