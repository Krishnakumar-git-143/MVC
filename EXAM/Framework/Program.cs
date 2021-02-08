using System;
using System.Data;
using BAL;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ProductId");
            var ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter OrderId");
            var OrderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            var Quantity = int.Parse(Console.ReadLine());
            DataSet dataSet = new DataSet();
            try
            {
                dataSet = new Context().combine(ProductId, OrderId, Quantity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine(row["ProductId"]);
            }
            foreach (DataRow row1 in dataSet.Tables[1].Rows)
            {
                Console.WriteLine(row1["OrderId"]);
            }
            foreach (DataRow row2 in dataSet.Tables[2].Rows)
            {
                Console.WriteLine(row2["Quantity"]);
            }
        }
    }
}
