using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExportDefectData
{
    [Serializable()]
    [DataContract]
    public class PMExcelIssuedateRequest
    {
        [DataMember]
        public int PlantId { get; set; }

        [DataMember]
        public string VIN { get; set; }

        [DataMember]
        public string FromDate { get; set; }

        [DataMember]
        public string ToDate { get; set; }

    }

    [Serializable()]
    [DataContract]
    public class PMExcelIssuedateResponse
    {
        [DataMember]
        public List<PMExcelIssuedate> pmExcels { get; set; }

        //[DataMember]
        //public List<PMExcelIssueLineName> lineName { get; set; }
    }


    [Serializable()]
    [DataContract]
    public class PMExcelIssueLineName
    {
        [DataMember]
        public string LineName { get; set; }
    }

    [Serializable()]
    [DataContract]
    public class PMExcelIssuedate
    {
        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string Time { get; set; }

        [DataMember]
        public string VIN { get; set; }

        [DataMember]
        public string QGateName { get; set; }

        [DataMember]
        public string PlanDate { get; set; }

        [DataMember]
        public string Customer { get; set; }

        [DataMember]
        public string BodyTypeVariant { get; set; }

        [DataMember]
        public string DefectClass { get; set; }

        [DataMember]
        public string PartNumber { get; set; }

        [DataMember]
        public string DefectDescription { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string ReworkCompleteStatus { get; set; }

        [DataMember]
        public string CheckDate { get; set; }

        [DataMember]
        public string ReworkStatus { get; set; }

        [DataMember]
        public string ReworkDate { get; set; }

        [DataMember]
        public string ResponsibleName { get; set; }

        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        public string Responsible { get; set; }

        [DataMember]
        public string ActualValue { get; set; }

        [DataMember]
        public string DamageCode { get; set; }

        [DataMember]
        public string ReworkedBy { get; set; }

        [DataMember]
        public string CheckedBy { get; set; }

        [DataMember]
        public string Attachment { get; set; }

        [DataMember]
        public string Remarks1 { get; set; }

        [DataMember]
        public string Remarks2 { get; set; }

        [DataMember]
        public string LineName { get; set; }
    }
}