using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSiteBanHang.Models;

namespace WebSiteBanHang.ViewModel
{
    public class bigViewModel
    {
        public Category Category { get; set; }
        public Product Product { get; set; }
        public UserProduct UserProduct { get; set; }
    }
}