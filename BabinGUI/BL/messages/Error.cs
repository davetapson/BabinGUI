namespace BabinGUI.BL.messages
{
    public class Error
    {
        public Error(int requestId, int errorCode, string message)
        {
            Message = message;
            RequestId = requestId;
            ErrorCode = errorCode;
        }

        public string Message { get; set; }
        public int ErrorCode { get; set; }
        public int RequestId { get; set; }
        
        public override string ToString()
        {
            return "Error - Request: " + RequestId + ", Code: " + ErrorCode + " - " + Message;
        }
    }
}
