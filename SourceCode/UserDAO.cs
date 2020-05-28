using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public static class UserDAO
    {
        public static List<User> getUsers()
        {
            
            List<User> users = new List<User>();
            var table = GetUsersTable();
            foreach (DataRow row in table.Rows)
            {
                User user = new User();
                user.IdUser = Convert.ToInt32(row[0].ToString());
                user.Fullname = row[1].ToString();
                user.Username = row[2].ToString();
                user.Password = row[3].ToString();
                user.UserType = Convert.ToBoolean(row[4].ToString());
            }
            return users;
        }

        public static DataTable GetUsersTable()
        {
            String querySql = "SELECT * FROM APPUSER ORDER BY iduser ASC;";
            DataTable table = ConnectionDB.ExecuteQuery(querySql);
            return table;
        }
        public static User VerifyUser(String username, String password)
        {
            String querySql = $"SELECT * FROM APPUSER WHERE username = '{username}' AND password = '{password}';";
            User loginUser = new User();
            var table = ConnectionDB.ExecuteQuery(querySql);
            loginUser.IdUser = Convert.ToInt32(table.Rows[0][0].ToString());
            loginUser.Fullname = table.Rows[0][1].ToString();
            loginUser.Username = table.Rows[0][2].ToString();
            loginUser.Password = table.Rows[0][3].ToString();
            loginUser.UserType = Convert.ToBoolean(table.Rows[0][4].ToString());
            return loginUser;
        }

        public static void CreateUser(User user)
        {
            String querySql = $"INSERT INTO APPUSER(fullname,username,password,usertype)" +
                              $"VALUES ('{user.Fullname}','{user.Username}','{user.Password}', {user.UserType});";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static void DeleteUser(int id)
        {
            String querySql = $"DELETE FROM APPUSER WHERE iduser = {id};";
            ConnectionDB.ExecuteNonQuery(querySql);
        }

        public static void UpdatePassword(User user, String password)
        {
            String querySql = $"UPDATE APPUSER SET password = '{password}' WHERE iduser = {user.IdUser};";
        }
    }
}