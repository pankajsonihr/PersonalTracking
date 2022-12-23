using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class EmployeeContext
    {
      public static EmployeeDataClassDataContext db = new EmployeeDataClassDataContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PersonalTracking;User ID=pankaj;Password=020306@1");
    }
}
