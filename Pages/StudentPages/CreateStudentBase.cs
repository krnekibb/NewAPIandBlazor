using BlazorWebServer.DataAccess;
using BlazorWebServer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebServer.Pages.StudentPages
{
    public class CreateStudentBase : ComponentBase
    {
        //[Inject]
        //public IStudentService StudentService { get; set; }

        [Inject]
        public IEnrollmentService EnrollmentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        //public Student Student { get; set; } = new Student();

        public List<Enrollment> Enrollments { get; set; }

        public Enrollment Enrollment { get; set; } = new Enrollment();

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            int.TryParse(Id, out int studentId);

            if (studentId != 0)
            {
                Enrollments = (await EnrollmentService.GetEnrollmentBySID(int.Parse(Id))).ToList();
            }
            else
            {
                Enrollments = new List<Enrollment>
   
            //    Enrollments = new Enrollment
            //    {
            //        EnrollmentDate = DateTime.Now
            //    };
            }
        }

        //protected override async Task OnInitializedAsync()
        //{
        //    int.TryParse(Id, out int studentId);

        //    if(studentId != 0)
        //    {
        //        Student = await StudentService.GetStudent(int.Parse(Id));
        //    }
        //    else
        //    {
        //        Student = new Student
        //        {
        //            EnrollmentDate = DateTime.Now
        //        };
        //    }
        //}

        public async Task CreateStudent()
        {
            Enrollment result = null;

            result = await EnrollmentService.CreateEnrollment(Enrollment);

            if(result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
