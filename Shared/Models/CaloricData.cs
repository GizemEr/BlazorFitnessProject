using System;
using System.Collections.Generic;

namespace Blazorapp.Shared.Models
{
    public partial class CaloricData
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public double Maintenance { get; set; }
        public int Result { get; set; }
        public string UserId { get; set; }

        public virtual GenderId GenderNavigation { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
