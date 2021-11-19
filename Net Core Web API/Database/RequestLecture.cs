using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class RequestLecture
    {
        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
        public Guid StudentId { get; set; }
        public int Status { get; set; }
        public DateTime RequestTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool? IsComplete { get; set; }
        public Guid? StudentCompleted { get; set; }
        public Guid? TeacherCompleted { get; set; }
        public string? Boardurl { get; set; }
        public bool? IsTicketRefunded { get; set; }
        public string? Combinedtime { get; set; }
    }
}
