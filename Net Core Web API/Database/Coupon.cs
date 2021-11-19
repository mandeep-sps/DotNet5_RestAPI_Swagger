using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponApplieds = new HashSet<CouponApplied>();
        }

        public Guid Id { get; set; }
        public string CouponCode { get; set; } = null!;
        public bool IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public decimal? Credit { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? IsEveryone { get; set; }
        public Guid? StudentId { get; set; }

        public virtual ICollection<CouponApplied> CouponApplieds { get; set; }
    }
}
