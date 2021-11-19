using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class CancelLecture
    {
        public Guid Id { get; set; }
        public Guid LectureId { get; set; }
        public Guid StudentId { get; set; }
        public DateTime CancellationTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
