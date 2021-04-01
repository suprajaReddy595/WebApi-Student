﻿using WebApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class StudentsController : ApiController
    {
        static List<Student> _studentList = null;
        void Initialize()
        {
            _studentList = new List<Student>()
           {
               new Student() { StudentId=1, Name="Ajay" , Batch="B001", Marks=89, DateOfBirth=Convert.ToDateTime("12/12/2020")},

               new Student() { StudentId=2, Name="Deepak" , Batch="B002", Marks=78, DateOfBirth=Convert.ToDateTime("10/06/2020")},
           };

        }
        public StudentsController()
        {
            if (_studentList == null)
            {
                Initialize();
            }
        }
        // GET: api/Students
        public IEnumerable<Student> Get()
        {
            return _studentList;
        }

        // GET: api/Students/5
        public Student Get(int id)
        {
            Student student = _studentList.Where(x => x.StudentId == id).FirstOrDefault();
            return student;
        }

        // POST: api/Students
        public void Post(Student student)
        {
            if (student != null)
            {
                _studentList.Add(student);
            }

        }

        // PUT: api/Students/5
        public void Put(int id, Student objStudent)
        {
            Student student = _studentList.Where(x => x.StudentId == id).FirstOrDefault();

            if (student != null)
            {
                foreach (Student temp in _studentList)
                {
                    if (temp.StudentId == id)
                    {
                        temp.Name = objStudent.Name;
                        temp.DateOfBirth = objStudent.DateOfBirth;
                        temp.Batch = objStudent.Batch;
                        temp.Marks = objStudent.Marks;
                    }
                }
            }

        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
            Student student = _studentList.Where(x => x.StudentId == id).FirstOrDefault();

            if (student != null)
            {
                _studentList.Remove(student);
            }
        }
    }
}
