using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class CreditPrice
    {
        public Guid Id { get; set; }
        public int Credit { get; set; }
        public decimal Price { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
