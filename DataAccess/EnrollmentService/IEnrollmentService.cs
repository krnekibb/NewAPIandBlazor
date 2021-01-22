using BlazorWebServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<Enrollment>> GetAllEnrollments();

        Task<IEnumerable<Enrollment>> GetEnrollmentBySID(int id);

        Task<Enrollment> GetSingleEnrollmentBySID(int id);

        Task<Enrollment> CreateEnrollment(Enrollment newEnrollment);
    }
}