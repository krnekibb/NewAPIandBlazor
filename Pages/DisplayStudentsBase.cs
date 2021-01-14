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
        public ICourseService CourseService { get; set; }
        public IEnrollmentService EnrollmentService { get; set; }


        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public List<Enrollment> Enrollments { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if(Enrollments == null)
            { 
                Enrollments = (await EnrollmentService.GetAllEnrollments()).ToList();
            }
            Enrollments = (await EnrollmentService.GetAllEnrollments()).ToList();
        }
    }
}
