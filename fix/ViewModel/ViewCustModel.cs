using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fix.Models;

namespace fix.ViewModel
{
    public class ViewCustModel
    {
        public Movies Movies { get; set; }
        public List<Customers> Customers { get; set; }
    }
}