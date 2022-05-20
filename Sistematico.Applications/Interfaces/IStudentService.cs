using Sistematico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico.Applications.Interfaces
{
    public interface IStudentService : IService<Estudiante>
    {
        decimal GetAverageByStudent(Estudiante estudiante);
        Estudiante FindById(int id);
        List<Estudiante> FindByName(string name);
    }
}
