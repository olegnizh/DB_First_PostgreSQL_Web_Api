using System;
using System.Collections.Generic;

namespace DB_First_PostgreSQL_Web_Api.Models
{
    public partial class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
