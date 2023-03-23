using System;
using System.Data;
using Npgsql;

class Sample
{
    static void Main(string[] args)
    {
        // Connect to a PostgreSQL database
        NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1:5433;User Id=postgres; " +
           "Password=wizardry;Database=prods;");
        conn.Open();

        // Define a query returning a single row result set
        NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM product", conn);

        // Execute the query and obtain the value of the first column of the first row
        Int64 count = (Int64)command.ExecuteScalar();
        Console.Write("{0}\n", count);

        //NpgsqlDataReader reader = command.ExecuteReader();

        /*while (reader.Read())
        {
            Console.WriteLine(reader[0]);
        }*/


        /*foreach (DataColumn column in dt.Columns)
          Console.Write(column.ColumnName.ToString());
        Console.WriteLine(dt.Rows[1].ItemArray[0].ToString());*/

        conn.Close();
    }
}