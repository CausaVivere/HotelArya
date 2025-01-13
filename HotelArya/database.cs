using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelArya
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/pauls/source/repos/HotelArya/HotelArya/hotel_arya.accdb;";
        private static OleDbConnection _connection;

        public static OleDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new OleDbConnection(ConnectionString);
                }
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }
    }
}
