using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExportVINDataAPI.JsonClass;
using System.Data;
using ExportVINDataAPI.DAL;
using System.Text;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using System.Dynamic;
//using Castle.Components.DictionaryAdapter;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;


namespace ExportVINDataAPI.BAL
{
    public class UserDetailsBAL
    {


        public List<DownloadVINData> GetExportVINData(string VIN, string FromDate,string ToDate)
        {
            List<DownloadVINData> downloadVINDatas = new List<DownloadVINData>();
            UserDetailsDAL _ob = new UserDetailsDAL();
            DataTable dt = new DataTable();
            DataSet ds = _ob.GetExportVINData(VIN, FromDate, ToDate);


            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    downloadVINDatas.Add(new DownloadVINData
                    {

                        LineName = Convert.ToString(ds.Tables[0].Rows[i]["LineName"]),
                        VIN = Convert.ToString(ds.Tables[0].Rows[i]["VIN"]),
                        Variant = Convert.ToString(ds.Tables[0].Rows[i]["Variant"]),
                        Customer = Convert.ToString(ds.Tables[0].Rows[i]["Customer"]),
                        PlannedCompletionDate = Convert.ToString(ds.Tables[0].Rows[i]["Planned Completion Date"]),
                        GateName = Convert.ToString(ds.Tables[0].Rows[i]["GateName"]),
                        Date = Convert.ToString(ds.Tables[0].Rows[i]["CreatedDate"]),
                        StartTime = Convert.ToString(ds.Tables[0].Rows[i]["StartTime"]),
                        FinishTime = Convert.ToString(ds.Tables[0].Rows[i]["FinishTime"]),
                        Status = Convert.ToString(ds.Tables[0].Rows[i]["Status"]),
                        InspectedBy = Convert.ToString(ds.Tables[0].Rows[i]["InspectedBy"]),
                        NumberOfRework = Convert.ToString(ds.Tables[0].Rows[i]["Number of Rework"]),
                        ReworkCompleted = Convert.ToString(ds.Tables[0].Rows[i]["Rework Completed"]),
                        ReworkCompletedDate = Convert.ToString(ds.Tables[0].Rows[i]["Rework Completed Date"]),
                        ReworkCompletedTime = Convert.ToString(ds.Tables[0].Rows[i]["Rework Completed Time"]),
                        ReworkedBy = Convert.ToString(ds.Tables[0].Rows[i]["Reworked by"]),
                        ReworkCheckDate = Convert.ToString(ds.Tables[0].Rows[i]["Rework Check Date"]),
                        ReworkCheckTime = Convert.ToString(ds.Tables[0].Rows[i]["Rework Check Time"]),
                        ReworkCheck = Convert.ToString(ds.Tables[0].Rows[i]["Rework Check"]),
                        ReworkCheckedBy = Convert.ToString(ds.Tables[0].Rows[i]["Rework Checked By"]),



                    });
                }
            }


            return downloadVINDatas;


        }
    }
}
     
