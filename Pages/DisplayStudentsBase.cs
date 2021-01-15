using BlazorWebServer.DataAccess;
using BlazorWebServer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebServer.Pages
{
    public class DisplayStudentsBase : ComponentBase
    {
        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public ICourseService CourseService { get; set; }

        [Inject]
        public IEnrollmentService EnrollmentService { get; set; }


        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        protected override async Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAllStudents()).ToList();
            Courses = (await CourseService.GetAllCourses()).ToList();
            Enrollments = (await EnrollmentService.GetAllEnrollments()).ToList();
        }
    }
}
