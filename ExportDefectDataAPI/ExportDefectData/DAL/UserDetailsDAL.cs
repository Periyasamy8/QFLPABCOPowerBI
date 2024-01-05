using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ExportVINDataAPI.JsonClass;
using ExportDefectData;

namespace ExportVINDataAPI.DAL
{
    public class UserDetailsDAL : DataComponent
    {




        public DataSet PMExcelDownloadforDefectData(string VIN, string FromDate, string ToDate)
        {
            SqlCommand cmd = new SqlCommand("PMExcelDownloadforDefectDataFORAPI", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PlantId", Convert.ToString(4));

            if (!string.IsNullOrEmpty(VIN))
            {
                cmd.Parameters.AddWithValue("@VIN", VIN);
            }

            if (!string.IsNullOrEmpty(FromDate))
            {
                cmd.Parameters.AddWithValue("@FromDate", Convert.ToString(FromDate));
               // cmd.Parameters.AddWithValue("@ToDate", Convert.ToString(ToDate));
            }
            if (!string.IsNullOrEmpty(ToDate))
            {
                cmd.Parameters.AddWithValue("@ToDate", Convert.ToString(ToDate));
                // cmd.Parameters.AddWithValue("@ToDate", Convert.ToString(ToDate));
            }
            return SelectCmd(cmd, sql_cs);
        }



    }
}