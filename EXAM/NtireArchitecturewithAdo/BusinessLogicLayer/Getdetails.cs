using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class Getdetails
    {
        public DataSet GetBanks()
        {
            DataSet set = new DataSet();

            DetaisDAL department = new DetaisDAL();
            var data = department.Banksdetails();

            set.Tables.Add(data);
            return set;
        }


    }
}
