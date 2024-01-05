using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using ExportVINDataAPI.JsonClass;
using ExportVINDataAPI.BAL;
using System.Data;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using System.Web.Script.Services;
using System.Web.Services;

namespace ExportVINDataAPI
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class VINData : IVINData
    {


        public  List<DownloadVINData> GetExportVINData(string VIN, string FromDate,string ToDate)
        {
            string _GetExportVINData = string.Empty;
            List<DownloadVINData> DownloadVINData = new List<DownloadVINData>();
            UserDetailsBAL _obj = new UserDetailsBAL();
            try
            {
                DownloadVINData = _obj.GetExportVINData(VIN, FromDate,ToDate);
            }
            catch (Exception ex)
            {
                ErrorLog.WriteToLog("GetExportVINData" + " " + ex.Message);
            }
            return DownloadVINData;

        }
     


    }
}
