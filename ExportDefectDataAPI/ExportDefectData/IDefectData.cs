using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExportDefectData
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDefectData" in both code and config file together.
    [ServiceContract]
    public interface IDefectData
    {

        [OperationContract(Name = "PMExcelDownloadforDefectData")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/PMExcelDownloadforDefectData?VIN={VIN}&FromDate={FromDate}&ToDate={ToDate}")]
        List<PMExcelIssuedate> PMExcelDownloadforDefectData(string VIN, string FromDate, string ToDate );

    }
}
