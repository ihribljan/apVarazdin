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
    class TableKarte
    {
        public int Id { get; set; }
        public int BrojKarte { get; set; }
        public decimal Cijena { get; set; }
        public DateTime VrijemeIzdavanja { get; set; }
        public decimal Popust { get; set; }
        public int ZaposleniciId { get; set; }
        public decimal IznosRacuna { get; set; }
        public int VoznjeId { get; set; }

        public static BindingList<TableKarte> getAll()
        {
            BindingList<TableKarte> lista = new BindingList<TableKarte>();
            TableKarte it = null;

            DbHelper dbHelper = new DbHelper();

            try
            {
                dbHelper.DbCommand.CommandText = "select * from Karte";
                dbHelper.OpenConnection();
                SqlDataReader r = dbHelper.QExecReader();
                while(r != null && r.Read())
                {
                    it = new TableKarte();
                    it.Id = (int)r["Id"];
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

        public static int getMaxBrojKarte()
        {
            int broj = 0;

            DbHelper dbHelper = new DbHelper();

            try
            {
                dbHelper.DbCommand.CommandText = "select max(BrojKarte) from Karte";
                dbHelper.OpenConnection();
                object ret = dbHelper.QExecScalarReturnObject();

                if (ret != null && ret != DBNull.Value)
                {
                    broj = Convert.ToInt32(ret);
                }
            }
            catch (DbException e)
            { }
            finally
            {
                dbHelper.CloseConnection();
            }

            return broj;
        }

        public bool dodaj()
        {
            bool status = false;

            DbHelper dbHelper = new DbHelper();

            try
            {
                dbHelper.DbCommand.CommandText = 
                    "insert into Karte values(" + BrojKarte + ", " + 
                    Cijena.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + ", '" + 
                    VrijemeIzdavanja.ToString("yyyy-MM-dd HH:mm:ss") + "', " + 
                    Popust.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + ", " + ZaposleniciId + ", " +
                    IznosRacuna.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + ", " + VoznjeId + ")";
                dbHelper.OpenConnection();

                Console.WriteLine(dbHelper.DbCommand.CommandText);

                int broj = dbHelper.QExecNonQuery();

                if (broj > 1)
                    status = true;
            }
            catch (DbException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dbHelper.CloseConnection();
            }

            return status;
        }
    }
}
