using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DetaisDAL
    {
        static string _connection = "Data Source=192.168.50.95;Initial Catalog=ktikkala;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        public DataTable Banksdetails()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                var sql = "Select * from Banks";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
        //public DataTable Tagsdetails()
        //{
        //    DataTable table = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(_connection))
        //    {
        //        var sql = "Select * from Tags";
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                adapter.Fill(table);
        //            }
        //        }
        //    }
        //    return table;
        //}
        //public DataTable Customerdetails()
        //{
        //    DataTable table = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(_connection))
        //    {
        //        var sql = "Select * from Customers";
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                adapter.Fill(table);
        //            }
        //        }
        //    }
        //    return table;
        //}
    }
}
