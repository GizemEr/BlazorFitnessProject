using System;
using System.Collections.Generic;

namespace Blazorapp.Shared.Models
{
    public partial class ActivityValue
    {
        public ActivityValue()
        {
            Activity = new HashSet<Activity>();
        }

        public int Id { get; set; }
        public string ActivityName { get; set; }
        public double Point { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
    }
}
