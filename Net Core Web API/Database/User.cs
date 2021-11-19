using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class User
    {
        public User()
        {
            CouponApplieds = new HashSet<CouponApplied>();
            FeedbackStudents = new HashSet<Feedback>();
            FeedbackTeachers = new HashSet<Feedback>();
            LectureStudents = new HashSet<Lecture>();
            LectureTeachers = new HashSet<Lecture>();
            PaymentHistories = new HashSet<PaymentHistory>();
            Qualifications = new HashSet<Qualification>();
        }

        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid RoleId { get; set; }
        public string? BoardId { get; set; }
        public string? BoardUrl { get; set; }
        public string UserId { get; set; } = null!;
        public string Token { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool? IsOnline { get; set; }
        public DateTime? LastActive { get; set; }
        public string? ResetCode { get; set; }
        public string? Image { get; set; }
        public decimal? Strike { get; set; }
        public decimal? Credit { get; set; }
        public string? About { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<CouponApplied> CouponApplieds { get; set; }
        public virtual ICollection<Feedback> FeedbackStudents { get; set; }
        public virtual ICollection<Feedback> FeedbackTeachers { get; set; }
        public virtual ICollection<Lecture> LectureStudents { get; set; }
        public virtual ICollection<Lecture> LectureTeachers { get; set; }
        public virtual ICollection<PaymentHistory> PaymentHistories { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }
    }
}
