using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APVarazdin.DataLayer
{
    class DbHelper
    {
        private String _db_server = "IVAN-PC\\SQLEXPRESS";
        private String _db_database = "apVarazdin";

        private String _ConnectionString;
        private SqlConnection _DbConnection;
        private SqlCommand _DbCommand;

        public SqlCommand DbCommand
        {
            get { if (_DbCommand == null) _DbCommand = new SqlCommand(); return _DbCommand; }
            set { _DbCommand = value; }
        }

        public DbHelper()
        {
            _ConnectionString = @"Data Source=" + _db_server
                + "; Initial Catalog=" + _db_database
                + "; Integrated Security = SSPI"
                + "; Connect Timeout=30";

            _DbConnection = new SqlConnection(_ConnectionString);
            _DbCommand = new SqlCommand();
            _DbCommand.Connection = _DbConnection;
        }

        public void OpenConnection()
        {
            _DbCommand.Parameters.Clear();

            if (_DbCommand.Connection.State != ConnectionState.Open)
            {
                try
                {
                    _DbCommand.Connection.Open();
                }
                catch (DbException e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void CloseConnection()
        {
            if (_DbCommand.Connection.State == ConnectionState.Open)
            {
                _DbCommand.Connection.Close();
            }
        }

        public SqlDataReader QExecReader()
        {
            SqlDataReader reader = null;

            _DbCommand.CommandType = CommandType.Text;

            reader = _DbCommand.ExecuteReader();

            return reader;
        }

        public int QExecNonQuery()
        {
            _DbCommand.CommandType = CommandType.Text;

            int ret = -1;
            ret = _DbCommand.ExecuteNonQuery();
            return ret;
        }

        public object QExecNonQueryReturnObject()
        {
            _DbCommand.CommandType = CommandType.Text;

            object ret = -1;
            ret = _DbCommand.ExecuteNonQuery();
            return ret;
        }

        public object QExecScalarReturnObject()
        {
            _DbCommand.CommandType = CommandType.Text;

            object ret = null;
            ret = _DbCommand.ExecuteScalar();
            return ret;
        }
    }
}
