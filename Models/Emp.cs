using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.RoleAuthorization.Models
{
    public class Emp
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmailId { get; set; }
        public string MobileNum { get; set; }
    }
}
