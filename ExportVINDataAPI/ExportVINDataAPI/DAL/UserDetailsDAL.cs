using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ExportVINDataAPI.JsonClass;

namespace ExportVINDataAPI.DAL
{
    public class UserDetailsDAL : DataComponent
    {



        public DataSet GetExportVINData(string VIN, string FromDate, string ToDate )
        {
            SqlCommand cmd = new SqlCommand("ASP_GetVinDataDownLoadFORAPI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PlantId", 4);

            if (!string.IsNullOrEmpty(VIN))
            {
                cmd.Parameters.AddWithValue("@VIN",VIN);
            }

            if (!string.IsNullOrEmpty(FromDate))
            {
                cmd.Parameters.AddWithValue("@FromDate", FromDate);
                //cmd.Parameters.AddWithValue("@ToDate", ToDate);
            }
            if (!string.IsNullOrEmpty(ToDate))
            {
                cmd.Parameters.AddWithValue("@ToDate", ToDate);
                //cmd.Parameters.AddWithValue("@ToDate", ToDate);
            }
            return SelectCmd(cmd, sql_cs);
        }



    }
}