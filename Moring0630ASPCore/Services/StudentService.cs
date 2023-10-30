using Microsoft.EntityFrameworkCore;
using Moring0630ASPCore.Data;
using Moring0630ASPCore.Models;

namespace Moring0630ASPCore.Services
{
    public class StudentService : IStudentService
    {
        private AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }
        public Task<int> Add(Student model)
        {
            _context.Students.Add(model);
            return _context.SaveChangesAsync();
        }

        public Task<int> Delete(Student model)
        {
            _context.Students.Remove(model);
            return _context.SaveChangesAsync();
        }

        public async Task<Student> Find(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public Task< List<Student>> ToList()
        {
            return _context.Students.ToListAsync();
        }

        public Task<int> Update(Student model)
        {
            _context.Students.Update(model);
            return _context.SaveChangesAsync();
        }
    }
}
