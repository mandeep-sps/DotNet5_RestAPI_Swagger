using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class Qualification
    {
        public Guid Id { get; set; }
        public string? HighestQualification { get; set; }
        public string? HighestQualificationUniversity { get; set; }
        public Guid TeacherId { get; set; }
        public bool IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual User Teacher { get; set; } = null!;
    }
}
