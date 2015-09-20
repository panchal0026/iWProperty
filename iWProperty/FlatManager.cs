using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace iWProperty
{
    class FlatManager
    {

        public int FlatID { get; set; }
        public string FlatNo { get; set; }
        public long Price { get; set;}
        public long DownPayment { get; set; }
        public long AmountPayed { get; set; }
        public bool IsSelled { get; set; }
        public int BuildingID { get; set; }

        public bool AddFlat(FlatManager flat) 
        {
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@BuildingID", flat.BuildingID);
            sp[1] = new SqlParameter("@FlatNo", flat.FlatNo);
            sp[2] = new SqlParameter("@Price", flat.Price);
            sp[3] = new SqlParameter("@DownPayment", flat.DownPayment);
            sp[4] = new SqlParameter("@AmountPayed", flat.AmountPayed);
            sp[5] = new SqlParameter("@IsSelled", false);

            return datalayer.Execute_NonQuery("sp_AddFlat", CommandType.StoredProcedure, sp);

        }

        public DataSet ListFlats(int BuildingID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@BuildingID", BuildingID);
            return datalayer.get_data("sp_ListFlats", CommandType.StoredProcedure, sp);
        }
        public DataSet ListUnsoldFlats(int BuildingID)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@BuildingID", BuildingID);
            return datalayer.get_data("sp_ListUnsoldFlats", CommandType.StoredProcedure, sp);
        }
    }
}
