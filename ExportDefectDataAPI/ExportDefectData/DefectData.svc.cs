using ExportVINDataAPI.BAL;
using ExportVINDataAPI.JsonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace ExportDefectData
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class DefectData : IDefectData
    {
        public List <PMExcelIssuedate> PMExcelDownloadforDefectData(string VIN, string FromDate,string ToDate)
        {
            List<PMExcelIssuedate> response = new List<PMExcelIssuedate>();
            
            UserDetailsBAL userDetailsBAL = new UserDetailsBAL();
            try
            {
                response = userDetailsBAL.PMExcelDownloadforDefectData( VIN,  FromDate,  ToDate);
            }
            catch (Exception ex)
            {
                ErrorLog.WriteToLog("PMExcelDownloadforDefectData" + " " + ex.Message);
            }
            return response;
        }

    }
}
