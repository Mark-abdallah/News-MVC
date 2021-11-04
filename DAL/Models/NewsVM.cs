using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class NewsVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
