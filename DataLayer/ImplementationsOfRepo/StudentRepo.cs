using DataLayer.InterfacesOfRepo;
using EntityLayer.Models;


namespace DataLayer.ImplementationsOfRepo
{
    public class StudentRepo : Repository<Student, int>, IStudentRepo
    {
        public StudentRepo(MyContext context) : base(context)
        {

        }
    }
}
