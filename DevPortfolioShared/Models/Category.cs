using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPortfolioShared.Models
{
    public class Category
    {
       
            [Key]
            public int CategoryId { get; set; }

            [Required]
            [MaxLength(256)]
            public required string ThumbnailImagePath { get; set; }

            [Required]
            [MaxLength(128)]
            public required string Name { get; set; }

            [Required]
            [MaxLength(1024)]
            public required string Description { get; set; }
        
    }
}
