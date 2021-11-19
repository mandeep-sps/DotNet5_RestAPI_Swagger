using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class Lecture
    {
        public Guid Id { get; set; }
        public string LectureDescription { get; set; } = null!;
        public Guid TeacherId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsCancelled { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public decimal? Credit { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? CancelledBy { get; set; }
        public bool? IsStudentJoined { get; set; }
        public bool? IsTeacherJoined { get; set; }
        public bool? IsComplete { get; set; }
        public TimeSpan? CallDuration { get; set; }
        public bool? IsBooked { get; set; }
        public Guid? StudentCompleted { get; set; }
        public Guid? TeacherCompleted { get; set; }
        public DateTime? CancellationDate { get; set; }
        public bool? IsTicketRefunded { get; set; }
        public DateTime? TicketRefundedDate { get; set; }
        public DateTime? LectureBookingDate { get; set; }
        public DateTime? LectureCompletionDate { get; set; }
        public string? Boardurl { get; set; }
        public string? Combinedtime { get; set; }

        public virtual User? Student { get; set; }
        public virtual User Teacher { get; set; } = null!;
    }
}
