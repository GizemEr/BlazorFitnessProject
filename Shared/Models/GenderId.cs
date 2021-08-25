using System;
using System.Collections.Generic;

namespace Blazorapp.Shared.Models
{
    public partial class GenderId
    {
        public GenderId()
        {
            CaloricData = new HashSet<CaloricData>();
        }

        public int Id { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<CaloricData> CaloricData { get; set; }
    }
}
