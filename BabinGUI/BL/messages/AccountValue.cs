using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabinGUI.messages
{
    public class AccountValue
    {
        private string key;
        private string value;
        private string currency;
        private string accountName;

        public AccountValue(string key, string value, string currency, string accountName)
        {
            this.key = key;
            this.value = value;
            this.currency = currency;
            this.accountName = accountName;
        }

        public string Key() { return key; }
        public string Value() { return value; }
        public string Currency() { return currency; }
        public string AccountName() { return accountName; }
    }
}
