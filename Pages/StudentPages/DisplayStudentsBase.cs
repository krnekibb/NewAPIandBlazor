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

        [Parameter]
        public string Id { get; set; }
        public List<Student> Students { get; set; }

        public Student Student { get; set; }
        public List<Course> Courses { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Student = await StudentService.GetStudent(int.Parse(Id));
            Students = (await StudentService.GetAllStudents()).ToList();
            Courses = (await CourseService.GetAllCourses()).ToList();
            Enrollments = (await EnrollmentService.GetAllEnrollments()).ToList();
        }
    }
}
