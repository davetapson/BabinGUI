namespace IBClient
{
    public enum IBClientType { Gateway = 4002, TWS = 4001 }

    public class IBGatewayClientConnectionData
    {
        public IBGatewayClientConnectionData(string server, int port, int clientId)
        {
            Server = server;
            Port = port;
            ClientId =clientId;
        }

        // default settings
        public IBGatewayClientConnectionData()
        {
            Server = "";
            Port = (int)IBClientType.Gateway;
            ClientId = 1001;
        }

        public string Server { get; set; }  // Server that the IB Gateway Client is running on
        public int Port { get; set; }       // Port on the Server the IBGC is configured to use
        public int ClientId { get; set; }   // The Id of this client

        public string Account { get; set; } // Account to subscribe to
    }
}
