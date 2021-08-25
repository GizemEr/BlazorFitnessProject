using System;
using System.Collections.Generic;

namespace Blazorapp.Shared.Models
{
    public partial class Activity
    {
        public int Id { get; set; }
        public int ActivityFeature { get; set; }
        public int Hour { get; set; }
        public DateTime? Date { get; set; }
        public double TotalCalorie { get; set; }
        public string UserId { get; set; }

        public virtual ActivityValue ActivityFeatureNavigation { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
