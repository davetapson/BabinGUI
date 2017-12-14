using BabinGUI.BL.messages;
using BabinGUI.messages;
using System;

namespace BabinGUI.BL.eventArgs
{
    public class ErrorArgs : EventArgs
    {
        public ErrorArgs(Error error)
        {
            Error = error;
        }

        public Error Error { get; }
    }
}
