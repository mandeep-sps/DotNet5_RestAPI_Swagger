using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class CouponApplied
    {
        public Guid Id { get; set; }
        public Guid CouponId { get; set; }
        public Guid StudentId { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual Coupon Coupon { get; set; } = null!;
        public virtual User Student { get; set; } = null!;
    }
}
