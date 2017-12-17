using IBApi;

namespace BabinGUI.BL.messages
{
    public class ContractDetail
    {
        public ContractDetail(int reqId, ContractDetails contractDetails)
        {
            ReqId = reqId;
            ContractDetails = contractDetails;
        }

        public int ReqId { get; set; }
        public ContractDetails ContractDetails {get; set;}
    }
}
