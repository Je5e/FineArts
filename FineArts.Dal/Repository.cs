using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FineArts.Entities;

namespace FineArts.Dal
{
   public class Repository
    {
        public bool HasTeachers()
        {
            using var Context = new FineArtsContext();
            return Context.Teachers.Any(); 
        } 
        
        public List<Teacher> GetTeachers()
        {
            using var Context = new FineArtsContext();
            // SELECT * FROM Teachers
            return Context.Teachers.ToList(); 
        }
        // CRUD (Create - Read  Update Delete)
        public bool AddTeachers(Teacher[] teachers)
        {
            using var Context = new FineArtsContext();
            Context.AddRange(teachers);
            return Context.SaveChanges() > 0;
        }

        public List<Student> GetStudentsByTeacherId(int teacherId)
        {
            using var Context = new FineArtsContext();
            return Context.Students // LINQ
                .Where(student => student.TeacherId == teacherId)
                .ToList();
        }
    }
}
