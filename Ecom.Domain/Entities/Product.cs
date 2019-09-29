using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ecom.Domain.Entities.BaseModels;

namespace Ecom.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public byte[] Thumb { get; set; }

        #region Auction Details

        public bool IsAuction { get; set; }
        public ICollection<AuctionDetail> AuctionDetails { get; set; }
        #endregion
    }
}
