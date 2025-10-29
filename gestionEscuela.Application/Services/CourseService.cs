using System.Net;
using gestionEscuela.Domain.Entities;
using gestionEscuela.Domain.Repositories;

namespace gestionEscuela.Application.Services;

public class CourseService
{
    private readonly IGenericRepository<Course> _courseRepository;

    public CourseService(IGenericRepository<Course> courseRepository)
    {
        _courseRepository = courseRepository;
    }
    
    // -----------------------------------------------------------
    
    // TODO
    
    // GET BY ID
    // GET ALL
    // CREATE
    // UPDATE
    // DELETE
}