using System;
using FineArts.Entities;
using FineArts.Dal;
using System.Collections.Generic; // List<T>.

namespace FineArts.Bll
{
    public class TeacherService
    {
        public static bool SeedData()
        {
            bool HasTestData = false;
            var Repository = new Repository();
            if (!Repository.HasTeachers())
            {
                var Teachers = new Teacher[]
                {
                    new Teacher
                    {
                        FirstName="Esther",
                        LastName="Valle",
                        Class="3C",
                        Students = new List<Student>
                        {
                            new Student
                            {
                                FirstName="Kevin",
                                LastName="Liu",
                                DateOfBirth=new DateTime(2005,10,10)
                            },
                            new Student
                            {
                                FirstName="Martin",
                                LastName="Weber",
                                DateOfBirth=new DateTime(2005,09,07)
                            },
                            new Student
                            {
                                FirstName="George",
                                LastName="Li",
                                DateOfBirth=new DateTime(2005,08,10)
                            },
                            new Student
                            {
                                FirstName="Lisa",
                                LastName="Miller",
                                DateOfBirth=new DateTime(2005,05,04)
                            },
                            new Student
                            {
                                FirstName="Run",
                                LastName="Liu",
                                DateOfBirth=new DateTime(2005,10,23)
                            }
                        }
                    },
                    new Teacher
                    {
                        FirstName="David",
                        LastName="Waite",
                        Class="4B",
                        Students= new List<Student>
                        {
                            new Student
                            {
                                FirstName="Sean",
                                LastName="Stewart",
                                DateOfBirth=new DateTime(2003,02,18)
                            },
                            new Student
                            {
                                FirstName="Olinda",
                                LastName="Turner",
                                DateOfBirth=new DateTime(2003,05,17)
                            },
                            new Student
                            {
                                FirstName="Jon",
                                LastName="Orton",
                                DateOfBirth=new DateTime(2002,08,10)
                            },
                            new Student
                            {
                                FirstName="Toby",
                                LastName="Nixon",
                                DateOfBirth=new DateTime(2002,12,15)
                            },
                            new Student
                            {
                                FirstName="Daniela",
                                LastName="Guinot",
                                DateOfBirth=new DateTime(2002,08,01)
                            }
                        }
                    },
                    new Teacher
                    {
                        FirstName="Belinda",
                        LastName="Newman",
                        Class="2A",
                        Students=new List<Student>
                        {
                            new Student
                            {
                                FirstName="Vijay",
                                LastName="Sundaram",
                                DateOfBirth=new DateTime(2007,02,03)
                            },
                            new Student
                            {
                                FirstName="Eric",
                                LastName="Gruber",
                                DateOfBirth=new DateTime(2007,05,26)
                            },
                            new Student
                            {
                                FirstName="Chris",
                                LastName="Meyer",
                                DateOfBirth=new DateTime(2006,05,09)
                            },
                            new Student
                            {
                                FirstName="Yuhong",
                                LastName="Li",
                                DateOfBirth=new DateTime(2007,05,28)
                            },
                            new Student
                            {
                                FirstName="Yan",
                                LastName="Li",
                                DateOfBirth=new DateTime(2007,03,31)
                            }
                        }
                    }
                };
                HasTestData = Repository.AddTeachers(Teachers);
            }
            return HasTestData;
        }//Initilizar datos de prueba.


        public List<Teacher> GetTeachers()
        {
            var Repository = new Repository();
            return Repository.GetTeachers();
        }
        public List<Student> GetStudentsByTeacher(int teacherId)
        {
            var Repository = new Repository();
            return Repository.GetStudentsByTeacherId(teacherId);
        }
    }
}
