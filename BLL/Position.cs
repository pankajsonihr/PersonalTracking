using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Position
    {
        public static void AddPosition(POSITION position)
        {
            DAL.DAO.PositionDAO.AddPosition(position);
        }
    }
}
