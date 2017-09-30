using System;
using System.Collections.Generic;

namespace ScrummatesV4.Models
{
    public partial class Users
    {
        public int AppId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public Applications App { get; set; }
    }
}
