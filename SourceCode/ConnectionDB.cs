﻿using System;
using System.Data;
using Npgsql;

namespace SourceCode
{
    public static class ConnectionDB
    {
        private static String host = "localhost",
            database = "2doParcialLocal",
            userId = "postgres",
            password = "";

        private static String dbConnection =
            $"Host={host};Port = 5432; User Id = {userId}; Password={password};Database={database};";
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(dbConnection);
            DataSet dataS = new DataSet();
            connection.Open();
            
            NpgsqlDataAdapter dataA = new NpgsqlDataAdapter(query, connection);
            dataA.Fill(dataS);
            connection.Close();
            
            return dataS.Tables[0];
        }

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(dbConnection);
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}