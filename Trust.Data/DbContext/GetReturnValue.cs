using System;
using System.Collections.Generic;
using System.Text;

namespace Trust.Data.DbContext
{
    public class GetReturnValue
    {
        public int ReturnedInt { get; set; }

        public decimal ReturnedDecimal { get; set; }

        public DateTime ReturnedUtcDate { get; set; }

        public string ReturnedString { get; set; }

        public bool ReturnedBoolean { get; set; }
    }

    public enum TheReturnType
    {
        Int,
        Decimal,
        Date,
        String,
        Boolean,
    }
}
