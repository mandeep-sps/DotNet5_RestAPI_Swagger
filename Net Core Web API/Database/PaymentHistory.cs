using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class PaymentHistory
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? MerchantUid { get; set; }
        public string? ImpUid { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? PaymentStatus { get; set; }
        public int Ticket { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
