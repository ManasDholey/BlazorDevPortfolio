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
            public  string Name { get; set; }

            [Required]
            [MaxLength(1024)]
            public  string Description { get; set; }
            public List<Post> Posts { get; set; }
    }
}
