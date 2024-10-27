using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipBuddyWebApplication.Domain.Models
{
    public class UpdateProductByGuidAndUserGuidRequest
    {
        public Guid Guid { get; set; }

        public Guid UserGuid { get; set; } 

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public decimal PurchasedPrice { get; set; }

        [Required]
        public decimal SellPrice { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; } = 1;

        [Required]
        public string Currency { get; set; } = string.Empty;

        [Required]
        public int ConditionId { get; set; }

        public string BarCode { get; set; } = string.Empty;

        public DateOnly? DateSold { get; set; } 
    }
}
