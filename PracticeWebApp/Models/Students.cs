using System;
using System.Collections.Generic;

namespace PracticeWebApp.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
