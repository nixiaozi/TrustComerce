using System;
using System.Collections.Generic;
using System.Text;

namespace Trust.Data.Entity
{
    public class UserBaseInfo
    {
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public DateTime LastLoginOutDate { get; set; }

        public int PresentEmail { get; set; }   

        public int LastEmail { get; set; }

        public int PresentPhone { get; set; }

        public int LastPhone { get; set; }

        public int PresentLocation { get; set; }

        public int LastLocation { get; set; }

    }
}
