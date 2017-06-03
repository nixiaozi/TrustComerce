using System;
using System.Collections.Generic;
using System.Text;

namespace Trust.Data.Entity
{
    public class UserAccountInfo
    {
        public string UserId { get; set; }

        public string AccountType { get; set; }

        public string ArchivesID { get; set; }

        public Boolean AccountCheck { get; set; }

        public decimal UseableMoney { get; set; }

        public decimal ForzenMoney { get; set; }

        public decimal BuyPoint { get; set; }

        public decimal SellPoint { get; set; }

        public decimal ActivePoint { get; set; }

        public int CreditLay { get; set; }

        public decimal SellWithAcount { get; set; }

        public decimal BuyWithAccount { get; set; }
        
        public int CreditBreakTime { get; set; }

        public int CreditBreakAcountTime { get; set; }
    }
}
