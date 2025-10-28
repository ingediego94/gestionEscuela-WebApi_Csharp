using gestionEscuela.Domain.Entities;
using gestionEscuela.Domain.Repositories;

namespace gestionEscuela.Application.Services;

public class StudentService : IStudentRepository
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }


    public Task<Student?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Student>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    
    // Create
    public async Task<Student> CreateAsync(Student student)
    {
        return await _studentRepository.CreateAsync(student);
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