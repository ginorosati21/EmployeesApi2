using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Models.Employees
{
    public class PostEmployeeRequest
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

}
