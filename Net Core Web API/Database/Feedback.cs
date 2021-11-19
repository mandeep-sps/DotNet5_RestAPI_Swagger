using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class Feedback
    {
        public Guid Id { get; set; }
        public string FeedbackMessage { get; set; } = null!;
        public Guid TeacherId { get; set; }
        public Guid StudentId { get; set; }
        public Guid LectureId { get; set; }
        public decimal FeedbackScore { get; set; }
        public bool IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid? RequestId { get; set; }

        public virtual User Student { get; set; } = null!;
        public virtual User Teacher { get; set; } = null!;
    }
}
