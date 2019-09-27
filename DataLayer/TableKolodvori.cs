using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APVarazdin.DataLayer
{
    class TableKolodvori
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public static BindingList<TableKolodvori> getAll()
        {
            BindingList<TableKolodvori> lista = new BindingList<TableKolodvori>();
            TableKolodvori it = null;

            DbHelper dbHelper = new DbHelper();

            try
            {
                dbHelper.DbCommand.CommandText = "select * from Kolodvori order by Id asc";
                dbHelper.OpenConnection();
                SqlDataReader r = dbHelper.QExecReader();
                while(r != null && r.Read())
                {
                    it = new TableKolodvori();
                    it.Id = (int)r["Id"];
                    it.Naziv = r["Naziv"].ToString();
                    it.Adresa = r["Adresa"].ToString();
                    lista.Add(it);
                }
            }
            catch (DbException e)
            { }
            finally
            {
                dbHelper.CloseConnection();
            }

            return lista;
        }
    }
}
