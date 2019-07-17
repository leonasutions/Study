using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fix.Models;

namespace fix.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers customers { get; set; }
    }
}