using System;
using System.Collections.Generic;

namespace DB_First_PostgreSQL_Web_Api.Models
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? DepartmentId { get; set; }

        public virtual Department IdNavigation { get; set; }
    }
}
