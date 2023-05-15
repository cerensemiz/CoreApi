using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesOfRepo
{
    public interface IStudentRepo : IRepository<Student, int>
    {

    }
}
