using BabinGUI.messages;
using System;

namespace BabinGUI.BL.eventArgs
{
    public class AccountValueArgs : EventArgs
    {
        public AccountValueArgs(AccountValue accountValue)
        {
            this.AccountValue = accountValue;
        }

        public AccountValue AccountValue { get; }
    }
}
