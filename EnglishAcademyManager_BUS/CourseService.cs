using EnglishAcademyManager_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManager_BUS
{
    public class CourseService
    {
        private readonly EnglishAcademyDbContext _context;

        public CourseService()
        {
            _context = new EnglishAcademyDbContext();
        }

        public List<Course> GetAll()
        {
            return _context.Course.ToList();
        }

        public void AddCourse(Course course)
        {
            _context.Course.Add(course);
            _context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            var existingCourse = _context.Course.SingleOrDefault(c => c.course_id == course.course_id);
            if (existingCourse != null)
            {
                existingCourse.course_name = course.course_name;
                existingCourse.level = course.level;
                existingCourse.fee = course.fee;
                _context.SaveChanges();
            }
        }

        public void DeleteCourse(string courseId)
        {
            var course = _context.Course.SingleOrDefault(c => c.course_id == courseId);
            if (course != null)
            {
                _context.Course.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}

