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
using ExportDefectData;

namespace ExportVINDataAPI.BAL
{
    public class UserDetailsBAL
    {

        public List<PMExcelIssuedate> PMExcelDownloadforDefectData(string VIN, string FromDate, string ToDate)
        {
            UserDetailsDAL _ob = new UserDetailsDAL();
            List<PMExcelIssuedate> pmResponse = new List<PMExcelIssuedate>();
            DataSet ds = new DataSet();
            try
            {
                ds = _ob.PMExcelDownloadforDefectData( VIN,  FromDate, ToDate);

               

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                                pmResponse.Add(new PMExcelIssuedate
                                {

                                   Date = Convert.ToString(ds.Tables[0].Rows[i]["CreatedDate"]),
                                   Time = Convert.ToString(ds.Tables[0].Rows[i]["Time"]),
                                   QGateName = Convert.ToString(ds.Tables[0].Rows[i]["QGate"]),
                                   PlanDate = Convert.ToString(ds.Tables[0].Rows[i]["PlanDate"]),
                                   VIN = Convert.ToString(ds.Tables[0].Rows[i]["VIN"]),
                                   Customer = Convert.ToString(ds.Tables[0].Rows[i]["Customer"]),
                                   BodyTypeVariant = Convert.ToString(ds.Tables[0].Rows[i]["Type"]),
                                   PartNumber = Convert.ToString(ds.Tables[0].Rows[i]["Item"]),
                                   DefectDescription = Convert.ToString(ds.Tables[0].Rows[i]["DefectDescription"]),
                                    //issuedate.DefectClass = Convert.ToString(row["DefectClass"]);
                                   Responsible = Convert.ToString(ds.Tables[0].Rows[i]["Responsible"]),
                                   Comment = Convert.ToString(ds.Tables[0].Rows[i]["Comment"]),
                                   Status = Convert.ToString(ds.Tables[0].Rows[i]["Inspection"]),
                                   ReworkStatus = Convert.ToString(ds.Tables[0].Rows[i]["Rework"]),
                                   ReworkDate = Convert.ToString(ds.Tables[0].Rows[i]["ReworkDate"]),
                                   ReworkCompleteStatus = Convert.ToString(ds.Tables[0].Rows[i]["Check"]),
                                   CheckDate = Convert.ToString(ds.Tables[0].Rows[i]["CheckDate"]),
                                   ResponsibleName = Convert.ToString(ds.Tables[0].Rows[i]["InspectedBy"]),
                                   ReworkedBy = Convert.ToString(ds.Tables[0].Rows[i]["ReworkedBy"]),
                                   CheckedBy = Convert.ToString(ds.Tables[0].Rows[i]["CheckedBy"]),
                                   Attachment = Convert.ToString(ds.Tables[0].Rows[i]["Attachment"]),
                                   ActualValue = Convert.ToString(ds.Tables[0].Rows[i]["Specifications"]),
                                   DamageCode = Convert.ToString(ds.Tables[0].Rows[i]["DamageCode"]),
                                   Remarks1 = Convert.ToString(ds.Tables[0].Rows[i]["Remarks1"]),
                                   Remarks2 = Convert.ToString(ds.Tables[0].Rows[i]["Remarks2"]),
                                   LineName = Convert.ToString(ds.Tables[0].Rows[i]["LineName"]),
                           

                                });
                        }
                    }
                  
                }

            catch (Exception ex)
            {

            }
            return pmResponse;
        }




    }
}