using BabinGUI.messages;
using System;

namespace BabinGUI.BL.eventArgs
{
    public class AccountValueArgs : EventArgs
    {
        public AccountValueArgs(AccountValue accountValue)
        {
            AccountValue = accountValue;
        }

        public AccountValue AccountValue { get; }
    }
}
