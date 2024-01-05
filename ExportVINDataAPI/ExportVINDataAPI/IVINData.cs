using ExportVINDataAPI.JsonClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExportVINDataAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVINData" in both code and config file together.
    [ServiceContract]
    public interface IVINData
    {
       
        [OperationContract(Name = "GetExportVINData")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/GetExportVINData?VIN={VIN}&FromDate={FromDate}&ToDate={ToDate}")]
        List<DownloadVINData> GetExportVINData(string VIN,string FromDate,string ToDate);


   



    }
}
