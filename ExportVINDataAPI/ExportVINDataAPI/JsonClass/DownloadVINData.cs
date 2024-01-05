using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExportVINDataAPI.JsonClass
{

    [Serializable]
    [DataContract]
    public class ProgressMonitorVINHistroyDetails
    {
        [DataMember]
        public List<VINHistoryDetails> _vinHistroyDetails { get; set; }
        [DataMember]
        public List<VINHistoryGateName> _vinHistroyGateName { get; set; }
        [DataMember]
        public List<EditableFields> _EditField { get; set; }
    }

            [Serializable]
            [DataContract]
            public class VINHistoryDetails
            {
                [DataMember]
                public string CheckedItem { get; set; }
                [DataMember]
                public long GateId { get; set; }
                [DataMember]
                public string GateName { get; set; }
                [DataMember]
                public string Status { get; set; }
                [DataMember]
                public string CheckedOn { get; set; }

                [DataMember]
                public string CreatedTime { get; set; }

                [DataMember]
                public string CheckedBy { get; set; }
                [DataMember]
                public long CreatedById { get; set; }
                [DataMember]
                public string Actual { get; set; }
                [DataMember]
                public string Comment { get; set; }

                [DataMember]
                public string PartName { get; set; }

                [DataMember]
                public string CheckListRefNo { get; set; }

                [DataMember]
                public string SPEC { get; set; }

                [DataMember]
                public string ReworkModifiedBy { get; set; }

                [DataMember]
                public string ReworkModifiedDate { get; set; }

                [DataMember]
                public string ReworkModifiedTime { get; set; }

                [DataMember]
                public string Responsible { get; set; }

                [DataMember]
                public string DamageCode { get; set; }

                [DataMember]
                public string Attachment { get; set; }

                [DataMember]
                public string CreatedDateTime { get; set; }

                [DataMember]
                public string ReworkModifiedDateTime { get; set; }

            }

            [Serializable]
            [DataContract]
            public class VINHistoryGateName
            {
                [DataMember]
                public string GateName { get; set; }
                [DataMember]
                public long GateId { get; set; }
                [DataMember]
                public string VINName { get; set; }

                [DataMember]
                public string VariantName { get; set; }
            }

            [Serializable]
            [DataContract]
            public class EditableFields
            {
                [DataMember]
                public string VIN { get; set; }
                [DataMember]
                public string Customer { get; set; }
                [DataMember]
                public string CompletionDate { get; set; }
                [DataMember]
                public string BaseVIN { get; set; }
                [DataMember]
                public string PlantId { get; set; }

                [DataMember]
                public string Color { get; set; }

                [DataMember]
                public string Memo { get; set; }

                [DataMember]
                public int UserId { get; set; }
            }


    [Serializable]
    [DataContract]
    public class Inputs
    {

        [DataMember]
        public List<Inputs> inputs { get; set; }

        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public int RoleId { get; set; }
        [DataMember]
        public int VariantId { get; set; }
        [DataMember]
        public string VariantName { get; set; }
        [DataMember]
        public int PlantId { get; set; }
        [DataMember]
        public string Mode { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int QGateId { get; set; }
        [DataMember]
        public string QGateName { get; set; }
        [DataMember]
        public int LineId { get; set; }
       
        [DataMember]
        public string CheckListQGateId { get; set; }
        [DataMember]
        public int CheckListId { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string VIN { get; set; }
        [DataMember]
        public int ModelId { get; set; }
        [DataMember]
        public string Specifications { get; set; }

        [DataMember]
        public string Responsible { get; set; }

        [DataMember]
        public string DamageCode { get; set; }

        [DataMember]
        public string Comments { get; set; }
       
        [DataMember]
        public string QGateRefNo { get; set; }
        [DataMember]
        public string CheckListRefNo { get; set; }
        [DataMember]
        public string ModelName { get; set; }
        [DataMember]
        public string PartName { get; set; }
        [DataMember]
        public string DefectClass { get; set; }
        [DataMember]
        public int SpecMin { get; set; }
        [DataMember]
        public int SpecMax { get; set; }
        [DataMember]
        public string CheckItem { get; set; }
        [DataMember]
        public string AssemblyName { get; set; }
        [DataMember]
        public string Spec { get; set; }
        [DataMember]
        public string MethodOfInspection { get; set; }
        [DataMember]
        public string PartLevel3 { get; set; }
        [DataMember]
        public string PartLevel4 { get; set; }
        [DataMember]
        public string PartLevel5 { get; set; }
        [DataMember]
        public string Option1 { get; set; }
        [DataMember]
        public string Option2 { get; set; }
        [DataMember]
        public string AccessType { get; set; }
        [DataMember]
        public string FromDate { get; set; }
        [DataMember]
        public string ToDate { get; set; }
        [DataMember]
        public bool Rework { get; set; }
        [DataMember]
        public int VehicleTypeId { get; set; }
        [DataMember]
        public string VehicleTypeName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Customer { get; set; }
        [DataMember]
        public string ModelIds { get; set; }
        [DataMember]
        public string VariantIds { get; set; }
        [DataMember]
        public string QGateIds { get; set; }
        [DataMember]
        public string Year { get; set; }

        [DataMember]
        public string checkItemsXML { get; set; }

        [DataMember]
        public string OthersStatus { get; set; }

        [DataMember]
        public string VinRefNo { get; set; }

        [DataMember]
        public string ReworkStatus { get; set; }

        [DataMember]
        public int ToolType { get; set; }

        [DataMember]
        public string PlannedCompletionDate { get; set; }

        [DataMember]
        public string LastUpdatedDate { get; set; }
        [DataMember]
        public int VINCheckListId { get; set; }

    }



    [Serializable]
    [DataContract]
    public class DownloadVINData

        
    {
        [DataMember]
        public List<dynamic> Information { get; set; }

        [DataMember]
        public string VIN { get; set; }
        [DataMember]
        public string Customer { get; set; }
        [DataMember]
        public string PlannedCompletionDate { get; set; }
        [DataMember]
        public string Variant { get; set; }
        [DataMember]
        public string GateName { get; set; }

        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string StartTime { get; set; }

        [DataMember]
        public string FinishTime { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string InspectedBy { get; set; }

        [DataMember]
        public string NumberOfRework{ get; set; }

        [DataMember]
        public string ReworkCompleted { get; set; }

        [DataMember]
        public string ReworkCompletedDate { get; set; }

        [DataMember]
        public string ReworkCompletedTime { get; set; }

        [DataMember]
        public string ReworkedBy { get; set; }

        [DataMember]
        public string ReworkCheckDate { get; set; }

        [DataMember]
        public string ReworkCheckTime { get; set; }

        [DataMember]
        public string ReworkCheck    { get; set; }

        [DataMember]
        public string ReworkCheckedBy { get; set; }

        [DataMember]
        public string LineName { get; set; }
       
    }

 

}