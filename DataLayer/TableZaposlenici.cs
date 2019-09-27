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
    class TableZaposlenici
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mobitel { get; set; }
        public int RadnaMjestaId { get; set; }
        public string Oib { get; set; }
        public int MjestaId { get; set; }
        public string Zaporka { get; set; }

        public static BindingList<TableZaposlenici> getAll()
        {
            BindingList<TableZaposlenici> lista = new BindingList<TableZaposlenici>();
            TableZaposlenici it = null;

            DbHelper dbHelper = new DbHelper();

            try
            {
                dbHelper.DbCommand.CommandText = "select * from Zaposlenici order by Id asc";
                dbHelper.OpenConnection();
                SqlDataReader r = dbHelper.QExecReader();
                while(r != null && r.Read())
                {
                    it = new TableZaposlenici();
                    it.Id = (int)r["Id"];
                    it.Ime = r["Ime"].ToString();
                    it.Prezime = r["Prezime"].ToString();
                    it.Mobitel = r["Mobitel"].ToString();
                    it.RadnaMjestaId = (int)r["RadnaMjestaId"];
                    it.Oib = r["Oib"].ToString();
                    it.MjestaId = (int)r["MjestaId"];
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
