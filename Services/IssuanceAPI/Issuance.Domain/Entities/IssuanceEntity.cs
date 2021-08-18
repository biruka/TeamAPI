using System;
using System.Collections.Generic;
using System.Text;
using Issuance.Domain.Seed;
using Issuance.Domain.Model;
namespace Issuance.Domain.Entities
{
    public class IssuanceEntity : BaseEntity<Model.Issuance>
    {
        public IssuanceEntity()
        {

        }
        public int requestId { get; set; }

        public string issurer { get; set; }

        public DateTime issuedDate { get; set; }

        public List<ItemIssuanceEntity> itemIssuance {get; set;} 

        public override Model.Issuance MapToModel()
        {
            Domain.Model.Issuance objIssuanceModel = new Domain.Model.Issuance();
            objIssuanceModel.issuedBy = issurer;
            objIssuanceModel.issuedDate = issuedDate;
            objIssuanceModel.requestId = requestId;
            return objIssuanceModel;
        }

        public override Model.Issuance MapToModel(Model.Issuance objIssuanceModel)
        {
            objIssuanceModel.issuedBy = issurer;
            objIssuanceModel.issuedDate = issuedDate;
            objIssuanceModel.requestId = requestId;
            return objIssuanceModel;
        }
    }
}
