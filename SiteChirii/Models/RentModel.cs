using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteChirii.Models
{
    public class RentModel
    {
        public decimal Price { get; set; }
        public IEnumerable<string> ImagePaths { get; set; }
    }
}