using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo2<TYPE, ID, RET> : IRepo<TYPE, ID, RET>
    {
        List<StudentCourse> GetCourse(ID id);
        List<Assignment> GetCoursewithAssignment(ID id);
    }
}
