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
    public partial class TableVoznje
    {
        public int Id { get; set; }
        public int RelacijeId { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public DateTime VrijemeDolaska { get; set; }
        public int ZaposleniciId { get; set; }
        public int AutobusiId { get; set; }

        public static BindingList<TableVoznje> getAll(int kolodvoriIdPolazak, int kolodvoriIdDolazak)
        {
            BindingList<TableVoznje> lista = new BindingList<TableVoznje>();
            TableVoznje it = null;

            DbHelper dbHelper = new DbHelper();

            try
            {
                dbHelper.DbCommand.CommandText = 
                    "select v.* " +
                    "from Voznje v " +
                    "inner join Relacije r ON (r.Id = v.RelacijeId)" +
                    "where r.KolodvoriIdPolazak = " + kolodvoriIdPolazak +
                    "and r.KolodvoriIdDolazak = " + kolodvoriIdDolazak +
                    "order by v.VrijemePolaska asc";

                dbHelper.OpenConnection();
                SqlDataReader r = dbHelper.QExecReader();
                while(r != null && r.Read())
                {
                    it = new TableVoznje();
                    it.Id = (int)r["Id"];
                    it.RelacijeId = (int)r["RelacijeId"];
                    it.VrijemePolaska = (DateTime)r["VrijemePolaska"];
                    it.VrijemeDolaska = (DateTime)r["VrijemeDolaska"];
                    it.ZaposleniciId = (int)r["ZaposleniciId"];
                    it.AutobusiId = (int)r["AutobusiId"];
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
