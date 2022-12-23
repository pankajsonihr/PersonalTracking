using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Department
    {
        public static void AddDepartment(DEPARTMENT department)
        {
            DAL.DAO.DepartmentDAO.AddDepartment(department);
        }

        public static List<DEPARTMENT> GetDepartment()
        {
            return DAL.DAO.DepartmentDAO.GetDepartment();
        }
    }
}
