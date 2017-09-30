using System;
using System.Collections.Generic;

namespace ScrummatesV4.Models
{
    public partial class Applications
    {
        public Applications()
        {
            Users = new HashSet<Users>();
        }

        public int AppId { get; set; }
        public string AppName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
