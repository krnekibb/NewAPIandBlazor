using BlazorWebServer.DataAccess;
using BlazorWebServer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebServer.Pages
{
    public class StudentDetailsBase : ComponentBase
    {
        [Inject]
        public IEnrollmentService EnrollmentService { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        public Student Student { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        //public ICollection<Student> Student { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Student = await StudentService.GetStudent(int.Parse(Id));
            Enrollments = (await EnrollmentService.GetEnrollmentBySID(int.Parse(Id))).ToList();
            //Student = (await StudentService.GetStudent(int.Parse(Id))).ToList();
        }
    }
}
