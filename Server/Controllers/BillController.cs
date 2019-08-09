using Newtonsoft.Json;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Controllers
{
    class BillController
    {
        public string getBillsByBankAccountId(string accountId)
        {
            Bill[] bankAccounts = Bill.findByAccountId(accountId);

            string biilsJsonString = JsonConvert.SerializeObject(bankAccounts);

            return biilsJsonString;
        }
    }
}
