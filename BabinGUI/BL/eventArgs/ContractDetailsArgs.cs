using BabinGUI.BL.messages;
using System;

namespace BabinGUI.BL.eventArgs
{
    public class ContractDetailArgs : EventArgs
    {
        public ContractDetailArgs(ContractDetail contractDetail)
        {
            ContractDetail = contractDetail;
        }
        public ContractDetail ContractDetail { get; }
    }
}

    
