using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo4<TYPE, ID, RET> : IRepo<TYPE, ID, RET>
    {
        List<Enroll> Filter(DateTime date);
    }
}
