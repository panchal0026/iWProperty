using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace iWProperty
{
    class ClientManager
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ContactNo { get; set; }
        public long DepositAmount { get; set; }
        public int FlatID { get; set; }


        public bool sellFlatTo(ClientManager cl) 
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@FlatID", cl.FlatID);
            sp[1] = new SqlParameter("@ClientName", cl.ClientName);
            sp[2] = new SqlParameter("@ContactNo", cl.ContactNo);
            sp[3] = new SqlParameter("@DepositAmout", cl.DepositAmount);

            return datalayer.Execute_NonQuery("sp_SellFlat", CommandType.StoredProcedure, sp);
        }
    }
}
