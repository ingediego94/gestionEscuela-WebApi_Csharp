using gestionEscuela.Domain.Entities;
using gestionEscuela.Domain.Repositories;
using gestionEscuela.Infrastructure.Data;

namespace gestionEscuela.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;
    
    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    // Interfaces to implement
    public Task<Student?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Student>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    // Create:
    public async Task<Student> CreateAsync(Student student)
    {
        try
        {
            _context.students_tb.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"It has presented an error. Error {ex.Message}");
            return null;
        }
    }

    public Task<Student?> UpdateAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}