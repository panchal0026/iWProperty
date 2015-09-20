using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace iWProperty
{
    class BuildingManager
    {
        public int BuildingID { get; set; }
        public int LocationID { get; set; }
        public string BuildingName { get; set; }
        public string BuildingDesc { get; set; }

        public bool AddNewBuilding(BuildingManager building) 
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@LocationID", building.LocationID);
            sp[1] = new SqlParameter("@BuildingName", building.BuildingName);
            sp[2] = new SqlParameter("@BuildingDesc", building.BuildingDesc);
            sp[3] = new SqlParameter("@CreatedDate", DateTime.Now);

            return datalayer.Execute_NonQuery("sp_AddNewBuilding", CommandType.StoredProcedure, sp);
        }

        public bool UpdateBuilding(BuildingManager building) 
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@BuildingID", building.BuildingID);
            sp[1] = new SqlParameter("@BuildingName", building.BuildingName);
            sp[2] = new SqlParameter("@BuildingDesc", building.BuildingDesc);

            return datalayer.Execute_NonQuery("sp_UpdateBuilding", CommandType.StoredProcedure, sp);
        }

        public DataSet listBuildingbyLocation(int LocationID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@LocationID", LocationID);
            return datalayer.get_data("sp_ListBuildingbyLocationID", CommandType.StoredProcedure, sp);
        }


    }
}
