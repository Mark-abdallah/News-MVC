using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string CategoryType { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
