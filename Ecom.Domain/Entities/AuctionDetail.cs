using System;
using System.ComponentModel.DataAnnotations;

namespace Ecom.Domain.Entities
{
    public class AuctionDetail
    {
        [Key]
        public string ProductId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsStarted => CheckIfStarted();

        private bool CheckIfStarted()
        {
            return (StartTime - DateTime.UtcNow).TotalSeconds < 0 && (EndTime - DateTime.UtcNow).TotalSeconds >= 0;
        }
    }
}
}